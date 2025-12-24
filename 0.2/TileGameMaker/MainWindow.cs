using TileGameLib;

namespace TileGameMaker;

public partial class MainWindow : Form
{
	private readonly TileDisplay display;
	private readonly Palette palette;
	private readonly Charset charset;

	public MainWindow()
    {
        InitializeComponent();

		palette = new();
		palette.Load("palette.dat");
		charset = new();
		charset.Load("charset.dat");

		display = new TileDisplay(256, 192, PnlDisplay);
		display.Zoom = 3;

		PixelCanvas canvas = display.Canvas;
		canvas.Clear(0x608060);

		Resize += (s, e) => display.Invalidate();

		display.MouseMove += Display_MouseMove;
		display.MouseDown += Display_MouseDown;
	}

	private void Display_MouseDown(object? sender, MouseEventArgs e)
	{
		int x = display.GetTiledX(e.X);
		int y = display.GetTiledY(e.Y);

		display.Canvas.DrawSolidPixelBlock(x, y, 0xff0000);

		display.Invalidate();
	}

	private void Display_MouseMove(object? sender, MouseEventArgs e)
	{
		Text = display.GetTiledX(e.X) + ", " + display.GetTiledY(e.Y);
	}
}
