using TileGameLib.Controls;
using TileGameLib.Core;

namespace TileGameMaker.Forms;

public partial class BoardWindow : Form
{
	private readonly Palette palette;
	private readonly Charset charset;
	private readonly Workspace workspace;

	private readonly TileBoardDisplay display;

	public BoardWindow(Workspace workspace)
	{
		InitializeComponent();

		this.workspace = workspace;
		DoubleBuffered = true;

		palette = new();
		palette.Load("palette.dat");
		charset = new();
		charset.Load("charset.dat");

		display = new TileBoardDisplay(160 / 8, 144 / 8, charset, palette, 200, PnlBoard);
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

		display.Board.SetTile(workspace.CurrentTile, x, y);
	}
}
