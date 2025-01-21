using TileGameLib.Controls;
using TileGameLib.Core;
using TileGameMaker.Core;

namespace TileGameMaker.StandaloneTools;

public partial class ColorPaletteEditorWindow : WindowBase
{
	private readonly ColorPalette Palette = new();
	private readonly ColorPaletteDisplay PaletteDisplay;

	public ColorPaletteEditorWindow(TileGameMakerApp app) : base(app)
	{
		InitializeComponent();

		PaletteDisplay = new ColorPaletteDisplay(
			new Size(16, 16), new Size(16, 16),
			new Size(8, 8), Color.White, new Point(0, 0), 3);

		PaletteDisplay.SetColors(Palette);

		PaletteDisplay.Parent = PalettePanel;
		PaletteDisplay.MouseDown += PaletteDisplay_MouseClick;
	}

	private void PaletteDisplay_MouseClick(object sender, MouseEventArgs e)
	{
		Point cellPos = PaletteDisplay.GetCellPosFromMousePos(e.Location);
		int cellIndex = PaletteDisplay.GetCellIndexFromMousePos(e.Location);

		PaletteDisplay.UnselectAllCells();
		PaletteDisplay.SelectCell(cellPos);
		PaletteDisplay.RemoveAllTextOverlay();
		PaletteDisplay.SetTextOverlay(cellIndex.ToString(), cellPos);
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

	private void BtnGrid_Click(object sender, EventArgs e)
	{
		PaletteDisplay.ShowGrid = BtnGrid.Checked;
		PaletteDisplay.Refresh();
	}
}
