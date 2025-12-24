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
		canvas.Clear(0x000080);
		canvas.DrawString(charset, palette, "Hello World! This is a long string.", 0, 0, 15);
		canvas.DrawString(charset, palette, "Hello World! This is a long string.", 0, 1, 15, 0);

		Resize += (s, e) => display.Invalidate();
	}
}
