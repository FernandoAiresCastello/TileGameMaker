using TileGameLib;

namespace TileGameMaker;

public partial class MainWindow : Form
{
	private readonly TileBoardDisplay display;
	private readonly Palette palette;
	private readonly Charset charset;

	public MainWindow()
    {
        InitializeComponent();

		palette = new();
		palette.Load("palette.dat");
		charset = new();
		charset.Load("charset.dat");

		display = new TileBoardDisplay(256 / 8, 192 / 8, charset, palette, 400, PnlDisplay);
		display.Zoom = 3;

		Tile tile = new Tile();
		tile.AddChar('-', 0, 15);
		tile.AddChar('+', 0, 15);
		display.Board.Fill(tile);

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
