using TileGameLib.Core;

namespace TileGameMaker;

public partial class MainWindow : Form
{
	private readonly Palette palette;
	private readonly Charset charset;

	public MainWindow()
    {
        InitializeComponent();

		palette = new();
		palette.Load("palette.dat");
		charset = new();
		charset.Load("charset.dat");

		Tile8x8Editor editor = new Tile8x8Editor(charset, 1, 4);
		editor.Show();
	}
}
