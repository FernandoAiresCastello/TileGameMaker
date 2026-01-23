using TileGameLib.Controls;
using TileGameLib.Core;

namespace TileGameMaker;

public partial class MainWindow : Form
{
	private readonly Palette palette;
	private readonly Charset charset;

	private readonly TileBoardDisplay display;

	public MainWindow()
	{
		InitializeComponent();
		DoubleBuffered = true;

		palette = new();
		palette.Load("palette.dat");
		charset = new();
		charset.Load("charset.dat");

		display = new TileBoardDisplay(160 / 8, 144 / 8, charset, palette, 100, PnlBoard);
		display.Zoom = 3;
		display.Board.BackColor = 0xffffff;

		display.MouseMove += Display_MouseMove;
		display.MouseDown += Display_MouseDown;
	}

	private void Display_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
			PutTile(e);
	}

	private void Display_MouseMove(object sender, MouseEventArgs e)
	{
		int x = display.GetTileX(e.X);
		int y = display.GetTileY(e.Y);

		Text = $"{x}, {y}";

		if (e.Button == MouseButtons.Left)
			PutTile(e);
	}

	private void PutTile(MouseEventArgs e)
	{
		int x = display.GetTileX(e.X);
		int y = display.GetTileY(e.Y);

		display.Board.SetTile(new Tile('X', 15, 0), x, y);
	}
}
