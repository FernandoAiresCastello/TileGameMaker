using TileGameLib.Controls;

namespace TileGameMaker;

public partial class TestWindow : Form
{
    readonly TileDisplay display;

    public TestWindow()
    {
        InitializeComponent();

        int tileSize = 8;
		int cols = 320 / tileSize;
		int rows = 200 / tileSize;

		display = new TileDisplay(cols, rows, tileSize, tileSize, Color.White)
		{
			Parent = RootPanel,
			Zoom = 2
		};

		display.MouseClick += Display_MouseClick;
		display.MouseDown += Display_MouseClick;
		display.MouseMove += Display_MouseClick;
	}

	private void Display_MouseClick(object? sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
			PutPixel(e.Location);
	}

	private void PutPixel(Point point)
	{
		Point cellPos = display.GetCellPos(point);
		Text = string.Format("X:{0} Y:{1}", cellPos.X, cellPos.Y);

		display.Canvas.DrawColor(Color.Black, cellPos.X, cellPos.Y);
		display.Refresh();
	}
}
