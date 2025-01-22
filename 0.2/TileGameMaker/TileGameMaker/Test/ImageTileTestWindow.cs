using System.Drawing.Imaging;
using TileGameLib.Controls;
using TileGameLib.Core;
using TileGameLib.Core.TileTypes;
using TileGameLib.ExtensionMethods;
using TileGameMaker.Core;

namespace TileGameMaker.Test;

public partial class ImageTileTestWindow : WindowBase
{
	private readonly TileDisplay DrawingDisplay;
	private readonly ColorPickerWindow PaletteWindow;
	private readonly AnimatedTile Tile;

	public ImageTileTestWindow(TileGameMakerApp app) : base(app)
	{
		InitializeComponent();

		KeyPreview = true;
		KeyDown += TestWindow_KeyDown;

		Size palWndBufSize = new(16, 16);
		PaletteWindow = new ColorPickerWindow(palWndBufSize, palWndBufSize, new(8, 8), Color.White, new Point(0, 0), 2);
		PaletteWindow.LoadColors("test/palettes/default_sort_hue.pal");

		Size bufSize = new(32, 24);
		Size canvasCellSize = new(8, 8);
		DrawingDisplay = new TileDisplay(bufSize, bufSize, canvasCellSize, Color.White, new Point(0, 0), 2);
		DrawingDisplay.MouseClick += DrawingDisplay_MouseClick;
		DrawingDisplay.MouseDown += DrawingDisplay_MouseClick;
		DrawingDisplay.MouseMove += DrawingDisplay_MouseClick;
		DrawingDisplay.Parent = DrawingPanel;

		Tile = new AnimatedTile([
			new("test/images/brick_1.png"), 
			new("test/images/brick_2.png")]);

		DrawingDisplay.BeginAutoRefresh(500, Tile.NextFrame);
	}

	private void TestWindow_KeyDown(object sender, KeyEventArgs e)
	{
		Keys key = e.KeyCode;

		if (key == Keys.D)
			DrawingDisplay.ScrollView(1, 0);
		else if (key == Keys.A)
			DrawingDisplay.ScrollView(-1, 0);
		else if (key == Keys.W)
			DrawingDisplay.ScrollView(0, -1);
		else if (key == Keys.S)
			DrawingDisplay.ScrollView(0, 1);
		else if (key == Keys.Home)
			DrawingDisplay.SetView(0, 0);
	}

	private void DrawingDisplay_MouseClick(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
			SetAnimatedTile(e.Location, Tile);
		else if (e.Button == MouseButtons.Right)
			SetColorTile(e.Location, DrawingDisplay.BackColor);
		else if (e.Button == MouseButtons.Middle)
			DeleteTile(e.Location);
	}

	private void SetAnimatedTile(Point mousePos, AnimatedTile tile)
	{
		Point cellPos = DrawingDisplay.GetCellPosFromMousePos(mousePos);
		if (cellPos.IsOutside(0, 0, DrawingDisplay.Cols, DrawingDisplay.Rows))
			return;

		DrawingDisplay.SetTile(tile, cellPos);
		DrawingDisplay.Refresh();
	}

	private void SetColorTile(Point mousePos, Color color)
	{
		Point cellPos = DrawingDisplay.GetCellPosFromMousePos(mousePos);
		if (cellPos.IsOutside(0, 0, DrawingDisplay.Cols, DrawingDisplay.Rows))
			return;

		DrawingDisplay.SetTile(new SolidColorTile(color), cellPos);
		DrawingDisplay.Refresh();
	}

	private void DeleteTile(Point mousePos)
	{
		Point cellPos = DrawingDisplay.GetCellPosFromMousePos(mousePos);
		if (cellPos.IsOutside(0, 0, DrawingDisplay.Cols, DrawingDisplay.Rows))
			return;

		DrawingDisplay.DeleteTile(cellPos);
		DrawingDisplay.Refresh();
	}

	private void BtnCanvasColor_Click(object sender, EventArgs e)
	{
		PaletteWindow.Title = "Select canvas color";
		PaletteWindow.OnColorClicked = CanvasColorSelected;
		PaletteWindow.ShowDialog(this);
	}

	private void CanvasColorSelected(Form wnd, Color color, MouseButtons button)
	{
		if (button == MouseButtons.Left)
		{
			DrawingDisplay.BackColor = color;
			DrawingDisplay.Refresh();
			wnd.Close();
		}
	}

	private void BtnToggleGrid_Click(object sender, EventArgs e)
	{
		DrawingDisplay.ShowGrid = !DrawingDisplay.ShowGrid;
		DrawingDisplay.Refresh();
	}

	private void BtnClear_Click(object sender, EventArgs e)
	{
		DrawingDisplay.Clear();
		DrawingDisplay.Refresh();
	}

	private void BtnFill_Click(object sender, EventArgs e)
	{
		DrawingDisplay.Fill(Tile);
		DrawingDisplay.Refresh();
	}

	private void BtnNorth_Click(object sender, EventArgs e)
	{
		DrawingDisplay.ScrollView(0, -1);
	}

	private void BtnSouth_Click(object sender, EventArgs e)
	{
		DrawingDisplay.ScrollView(0, 1);
	}

	private void BtnWest_Click(object sender, EventArgs e)
	{
		DrawingDisplay.ScrollView(-1, 0);
	}

	private void BtnEast_Click(object sender, EventArgs e)
	{
		DrawingDisplay.ScrollView(1, 0);
	}

	private void BtnOrigin_Click(object sender, EventArgs e)
	{
		DrawingDisplay.SetView(0, 0);
	}

	private void BtnSaveImage_Click(object sender, EventArgs e)
	{
		SaveFileDialog dialog = new();
		if (dialog.ShowDialog(this) != DialogResult.OK)
			return;

		DrawingDisplay.SaveImage(dialog.FileName, ImageFormat.Png);
	}
}
