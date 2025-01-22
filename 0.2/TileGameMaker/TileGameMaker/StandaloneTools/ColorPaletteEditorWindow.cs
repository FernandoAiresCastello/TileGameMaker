using TileGameLib.Controls;
using TileGameLib.Core;
using TileGameLib.ExtensionMethods;
using TileGameMaker.Core;

namespace TileGameMaker.StandaloneTools;

public partial class ColorPaletteEditorWindow : WindowBase
{
	private const int InvalidColorIndex = -1;

	private readonly ColorPalette Palette;
	private readonly ColorPaletteDisplay PaletteDisplay;
	private readonly Color BlankColor = Color.White;
	private Color CopiedColor;

	private int ColorIndex { get; set; } = InvalidColorIndex;

	public ColorPaletteEditorWindow(TileGameMakerApp app) : base(app)
	{
		InitializeComponent();

		Palette = new ColorPalette(BlankColor, 256);
		CopiedColor = BlankColor;
		KeyPreview = true;

		PaletteDisplay = new ColorPaletteDisplay(
			new Size(16, 16), new Size(16, 16),
			new Size(8, 8), Color.White, new Point(0, 0), 3);

		PaletteDisplay.SetColors(Palette);

		PaletteDisplay.Parent = PalettePanel;
		PaletteDisplay.MouseDown += PaletteDisplay_MouseClick;

		TxtRgb.KeyPress += TxtRgb_KeyPress;
		TxtRgb.KeyUp += TxtRgb_KeyUp;
	}

	private void TxtRgb_KeyPress(object sender, KeyPressEventArgs e)
	{
		if (!char.IsControl(e.KeyChar) && !("0123456789ABCDEFabcdef".Contains(e.KeyChar)))
			e.Handled = true;
		if (ColorIndex < 0 || ColorIndex >= Palette.Count)
			return;
	}

	private void TxtRgb_KeyUp(object sender, KeyEventArgs e)
	{
		if (ColorIndex == InvalidColorIndex)
			return;
		if (TxtRgb.Text.Length != 6)
			return;

		Color color = ColorTranslator.FromHtml("#" + TxtRgb.Text);
		Palette.Set(ColorIndex, color);
		PaletteDisplay.Update();
	}

	private void PaletteDisplay_MouseClick(object sender, MouseEventArgs e)
	{
		PaletteDisplay.Focus();

		Point cellPos = PaletteDisplay.GetCellPosFromMousePos(e.Location);
		int cellIndex = PaletteDisplay.GetCellIndexFromMousePos(e.Location);

		bool hasOverlay = PaletteDisplay.HasTextOverlay(cellPos);

		PaletteDisplay.UnselectAllCells();
		PaletteDisplay.RemoveAllTextOverlay();

		ColorIndex = InvalidColorIndex;
		TxtIndex.Text = "";
		TxtRgb.Text = "";

		if (!hasOverlay)
		{
			PaletteDisplay.SelectCell(cellPos);
			PaletteDisplay.SetTextOverlay(cellIndex.ToString(), cellPos);

			ColorIndex = cellIndex;
			TxtIndex.Text = ColorIndex.ToString();
			TxtRgb.Text = Palette.Get(ColorIndex).ToHex().ToUpper();
		}

		PaletteDisplay.Refresh();
	}

	private void BtnLoad_Click(object sender, EventArgs e)
	{
		OpenFileDialog dialog = new();
		if (dialog.ShowDialog(this) != DialogResult.OK)
			return;

		Palette.Load(dialog.FileName);
		PaletteDisplay.Update();
	}

	private void BtnSave_Click(object sender, EventArgs e)
	{
		SaveFileDialog dialog = new();
		if (dialog.ShowDialog(this) != DialogResult.OK)
			return;

		Palette.Save(dialog.FileName);
	}

	private void BtnGrid_Click(object sender, EventArgs e)
	{
		PaletteDisplay.ShowGrid = BtnGrid.Checked;
		PaletteDisplay.Refresh();
	}

	private void BtnCopy_Click(object sender, EventArgs e)
	{
		if (ColorIndex == InvalidColorIndex)
			return;

		CopiedColor = Palette.Get(ColorIndex);
	}

	private void BtnPaste_Click(object sender, EventArgs e)
	{
		if (ColorIndex == InvalidColorIndex)
			return;

		Palette.Set(ColorIndex, CopiedColor);
		PaletteDisplay.Update();
		TxtRgb.Text = Palette.Get(ColorIndex).ToHex().ToUpper();
	}

	private void BtnSetBlank_Click(object sender, EventArgs e)
	{
		if (ColorIndex == InvalidColorIndex)
			return;

		Palette.Set(ColorIndex, Color.White);
		PaletteDisplay.Update();
		TxtRgb.Text = Palette.Get(ColorIndex).ToHex().ToUpper();
	}
}
