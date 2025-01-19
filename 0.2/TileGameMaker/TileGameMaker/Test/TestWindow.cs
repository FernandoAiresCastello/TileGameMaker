using TileGameLib.Controls;
using TileGameLib.Core;
using TileGameLib.Core.TileTypes;
using TileGameLib.ExtensionMethods;

namespace TileGameMaker.Test;

public partial class TestWindow : Form
{
	private readonly TileDisplay DrawingDisplay;
	private readonly ColorPaletteWindow PaletteWindow;

	private Color LeftDrawingColor { get; set; } = Color.Black;
	private Color RightDrawingColor { get; set; } = Color.White;

	public TestWindow()
	{
		InitializeComponent();
		KeyPreview = true;
		KeyDown += TestWindow_KeyDown;

		Size palWndBufSize = new(16, 16);
		PaletteWindow = new ColorPaletteWindow(palWndBufSize, palWndBufSize, new(8, 8), Color.White, new Point(0, 0), 2);
		PaletteWindow.LoadColors("test/palettes/default_sort_hue.pal");

		Size bufSize = new(32, 24);
		DrawingDisplay = new TileDisplay(bufSize, bufSize, new Size(8, 8), Color.White, new Point(0, 0), 2);
		DrawingDisplay.MouseClick += DrawingDisplay_MouseClick;
		DrawingDisplay.MouseDown += DrawingDisplay_MouseClick;
		DrawingDisplay.MouseMove += DrawingDisplay_MouseClick;
		DrawingDisplay.Parent = DrawingPanel;

		DrawingDisplay.SetTextOverlay("Text", 2, 3);
		DrawingDisplay.SetTextOverlay("#", 2, 1);

		DrawingDisplay.SelectCellRegion(10, 10, 15, 15);
	}

	private void TestWindow_KeyDown(object? sender, KeyEventArgs e)
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

	private void DrawingDisplay_MouseClick(object? sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
			SetColorTile(e.Location, LeftDrawingColor);
		else if (e.Button == MouseButtons.Right)
			SetColorTile(e.Location, RightDrawingColor);
		else if (e.Button == MouseButtons.Middle)
			DeleteTile(e.Location);
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

	private void BtnColorPalette_Click(object sender, EventArgs e)
	{
		PaletteWindow.Title = "Select paint color";
		PaletteWindow.OnColorClicked = PaintColorSelected;
		PaletteWindow.ShowDialog(this);
	}

	private void PaintColorSelected(Form wnd, Color color, MouseButtons button)
	{
		if (button == MouseButtons.Left)
		{
			LeftDrawingColor = color;
			wnd.Close();
		}
		else if (button == MouseButtons.Right)
		{
			RightDrawingColor = color;
			wnd.Close();
		}
		else if (button == MouseButtons.Middle)
		{

		}
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
		DrawingDisplay.Fill(new SolidColorTile(LeftDrawingColor));
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
}
