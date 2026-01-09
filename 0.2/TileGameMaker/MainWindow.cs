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

		palette = new();
		palette.Load("palette.dat");
		charset = new();
		charset.Load("charset.dat");

		display = new TileBoardDisplay(160 / 8, 144 / 8, charset, palette, 100, PnlDisplay);
		display.Zoom = 3;
		display.Board.BackColor = 0xffffff;
		display.Board.SetTile(new Tile('?', 15, 0), 0, 0);
	}
}
