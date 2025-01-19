using TileGameLib.Controls;
using TileGameLib.Core;
using TileGameLib.Core.TileTypes;
using TileGameLib.ExtensionMethods;

namespace TileGameMaker.Test;

public partial class TestWindow : Form
{
	private readonly TileDisplay DrawingDisplay;
	private Color BackgroundColor { get; set; } = Color.White;
	private Color LeftDrawingColor { get; set; } = Color.Black;
	private Color RightDrawingColor { get; set; } = Color.White;

	public TestWindow()
	{
		InitializeComponent();

		DrawingDisplay = new TileDisplay(
			new Size(32, 24), new Size(8, 8), 2, BackgroundColor)
		{
			Parent = DrawingPanel
		};

		DrawingDisplay.MouseClick += DrawingDisplay_MouseClick;
		DrawingDisplay.MouseDown += DrawingDisplay_MouseClick;
		DrawingDisplay.MouseMove += DrawingDisplay_MouseClick;

		DrawingDisplay.SetTextOverlay("@", 1, 1);
		DrawingDisplay.SetTextOverlay("#", 2, 1);
	}

	private void DrawingDisplay_MouseClick(object? sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
			SetColorTile(e.Location, LeftDrawingColor);
		else if (e.Button == MouseButtons.Right)
			SetColorTile(e.Location, RightDrawingColor);
		else if (e.Button == MouseButtons.Middle)
			SetColorTile(e.Location, BackgroundColor);
	}

	private void SetColorTile(Point mousePos, Color color)
	{
		Point cellPos = DrawingDisplay.GetCellPosFromMousePos(mousePos);
		if (cellPos.IsOutside(0, 0, DrawingDisplay.Cols, DrawingDisplay.Rows))
			return;

		DrawingDisplay.SetTile(new SolidColorTile(color), cellPos.X, cellPos.Y);
		DrawingDisplay.Refresh();
	}

	private void BtnColorPalette_Click(object sender, EventArgs e)
	{
		int tileSize = 8;
		int cols = 16;
		int rows = 256 / cols;
		int zoom = 2;

		ColorPaletteWindow wnd = new(cols, rows, tileSize, tileSize, zoom, Color.White)
		{
			DefaultTitle = "Color Palette",
			OnColorClicked = ColorClicked
		};

		wnd.LoadColors("test/palettes/atari_800.pal");
		wnd.ShowDialog(this);
	}

	private void ColorClicked(Form wnd, Color? color, MouseButtons button)
	{
		if (color.HasValue && button == MouseButtons.Left)
		{
			LeftDrawingColor = color.Value;
			wnd.Close();
		}
		else if (color.HasValue && button == MouseButtons.Right)
		{
			RightDrawingColor = color.Value;
			wnd.Close();
		}
		else if (button == MouseButtons.Middle)
		{
			if (color.HasValue)
				MessageBox.Show($"This is RGB #{color.Value.ToHex()}");
			else
				MessageBox.Show($"This palette index is empty!");
		}
	}

	private void BtnToggleGrid_Click(object sender, EventArgs e)
	{
		DrawingDisplay.ShowGrid = !DrawingDisplay.ShowGrid;
		DrawingDisplay.Refresh();
	}

	private void BtnClear_Click(object sender, EventArgs e)
	{
		DrawingDisplay.Fill(new SolidColorTile(BackgroundColor));
		DrawingDisplay.Refresh();
	}

	private void BtnFill_Click(object sender, EventArgs e)
	{
		DrawingDisplay.Fill(new SolidColorTile(LeftDrawingColor));
		DrawingDisplay.Refresh();
	}
}
