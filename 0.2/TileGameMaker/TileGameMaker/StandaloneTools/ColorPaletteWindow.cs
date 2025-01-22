using TileGameLib.Controls;
using TileGameLib.Core;
using TileGameLib.ExtensionMethods;
using TileGameMaker.Core;

namespace TileGameMaker.StandaloneTools;

public partial class ColorPaletteWindow : WindowBase
{
	private const int InvalidColorIndex = -1;
	private const int PaletteSize = 256;

	private readonly ColorPalette Palette;
	private readonly ColorPickerDisplay PaletteDisplay;
	private readonly Color BlankColor = Color.White;
	private Color CopiedColor;
	
	private int ColorIndex { get; set; } = InvalidColorIndex;
	private int DraggedIndex { get; set; } = InvalidColorIndex;

	private readonly Cursor DraggingCursor;

	public ColorPaletteWindow(TileGameMakerApp app) : base(app)
	{
		InitializeComponent();

		DraggingCursor = new Cursor("box_drag.cur");

		Palette = new ColorPalette(BlankColor, PaletteSize);
		CopiedColor = BlankColor;
		KeyPreview = true;

		PaletteDisplay = new ColorPickerDisplay(
			new Size(16, 16), new Size(16, 16),
			new Size(8, 8), Color.White, new Point(0, 0), 3);

		PaletteDisplay.SetColors(Palette);

		PaletteDisplay.Parent = PalettePanel;
		PaletteDisplay.Cursor = Cursors.Default;
		PaletteDisplay.MouseDown += PaletteDisplay_MouseDown;
		PaletteDisplay.MouseUp += PaletteDisplay_MouseUp;
		PaletteDisplay.MouseMove += PaletteDisplay_MouseMove;

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

	private void PaletteDisplay_MouseDown(object sender, MouseEventArgs e)
	{
		PaletteDisplay.Focus();

		Point cellPos = PaletteDisplay.GetCellPosFromMousePos(e.Location);
		int cellIndex = PaletteDisplay.GetCellIndexFromMousePos(e.Location);

		if (e.Button == MouseButtons.Left)
			SelectColorWithMouse(cellPos, cellIndex);
		if (e.Button == MouseButtons.Right)
			BeginDragColor(cellIndex);
	}

	private void PaletteDisplay_MouseUp(object sender, MouseEventArgs e)
	{
		PaletteDisplay.Focus();
		int cellIndex = PaletteDisplay.GetCellIndexFromMousePos(e.Location);
		EndDragColor(cellIndex);
		PaletteDisplay.Cursor = Cursors.Default;
	}

	private void PaletteDisplay_MouseMove(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Right)
			PaletteDisplay.Cursor = DraggingCursor;
	}

	private void SelectColorWithMouse(Point cellPos, int cellIndex)
	{
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

	private void BeginDragColor(int cellIndex)
	{
		if (cellIndex == InvalidColorIndex)
			return;

		DraggedIndex = cellIndex;
	}

	private void EndDragColor(int cellIndex)
	{
		if (cellIndex < 0 || cellIndex >= Palette.Count || 
			DraggedIndex < 0 || DraggedIndex >= Palette.Count)
			return;

		Color originalDraggedColor = Palette.Get(DraggedIndex);
		Color targetColor = Palette.Get(cellIndex);

		Palette.Set(cellIndex, originalDraggedColor);
		Palette.Set(DraggedIndex, targetColor);
		PaletteDisplay.Update();

		DraggedIndex = InvalidColorIndex;
	}

	private void BtnLoad_Click(object sender, EventArgs e)
	{
		OpenFileDialog dialog = new();
		if (dialog.ShowDialog(this) != DialogResult.OK)
			return;

		PaletteDisplay.UnselectAllCells();
		PaletteDisplay.RemoveAllTextOverlay();

		ColorIndex = InvalidColorIndex;
		TxtIndex.Text = "";
		TxtRgb.Text = "";

		Palette.Load(dialog.FileName, PaletteSize, BlankColor);
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
