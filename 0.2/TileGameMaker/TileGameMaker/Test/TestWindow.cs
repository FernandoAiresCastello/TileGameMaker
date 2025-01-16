using TileGameLib.Controls;
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

		DrawingDisplay = new TileDisplay(32, 24, 8, 8, BackgroundColor)
		{
			Parent = DrawingPanel,
			Zoom = 2
		};

		DrawingDisplay.MouseClick += DrawingDisplay_MouseClick;
		DrawingDisplay.MouseDown += DrawingDisplay_MouseClick;
		DrawingDisplay.MouseMove += DrawingDisplay_MouseClick;
	}

	private void DrawingDisplay_MouseClick(object? sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
			DrawColoredTile(e.Location, LeftDrawingColor);
		else if (e.Button == MouseButtons.Right)
			DrawColoredTile(e.Location, RightDrawingColor);
		else if (e.Button == MouseButtons.Middle)
			DrawColoredTile(e.Location, BackgroundColor);
	}

	private void DrawColoredTile(Point mousePos, Color color)
	{
		Point cellPos = DrawingDisplay.GetCellPos(mousePos);
		if (cellPos.IsOutside(0, 0, DrawingDisplay.Cols, DrawingDisplay.Rows))
			return;

		DrawingDisplay.Canvas.DrawColor(color, cellPos.X, cellPos.Y);
		DrawingDisplay.Refresh();
	}

	private void BtnColorPalette_Click(object sender, EventArgs e)
	{
		ColorPaletteWindow wnd = new();
		wnd.SetColors(["000000", "ff0000", "ff8000", "00ff00", "0000ff", "ffff00", "00ffff", "ff00ff"]);
		wnd.OnColorClicked = ColorClicked;
		wnd.ShowDialog(this);
	}

	private void ColorClicked(Form wnd, Color? color, MouseButtons button)
	{
		if (!color.HasValue)
			return;

		if (button == MouseButtons.Left)
			LeftDrawingColor = color.Value;
		else if (button == MouseButtons.Right)
			RightDrawingColor = color.Value;
		else
			return;

		wnd.Close();
	}

	private void BtnToggleGrid_Click(object sender, EventArgs e)
	{
		DrawingDisplay.ShowGrid = !DrawingDisplay.ShowGrid;
		DrawingDisplay.Refresh();
	}

	private void BtnClear_Click(object sender, EventArgs e)
	{
		DrawingDisplay.Canvas.Clear(BackgroundColor);
		DrawingDisplay.Refresh();
	}
}
