using TileGameLib.Controls;
using TileGameLib.Core;

namespace TileGameMaker.Forms;

public partial class CharsetWindow : Form
{
	private readonly Palette palette;
	private readonly Workspace workspace;
	private readonly TileBoardDisplay display;

	public CharsetWindow(Workspace workspace)
	{
		InitializeComponent();

		this.workspace = workspace;
		DoubleBuffered = true;

		palette = new Palette();
		palette.SetColor(0, 0x000000);
		palette.SetColor(1, 0xffffff);
		palette.SetColor(2, 0x0000ff);

		display = new TileBoardDisplay(16, 16, workspace.Charset, palette, 200, PnlCharset);
		display.Board.BackColor = palette.GetColor(1);

		display.MouseDown += Display_MouseDown;

		DrawChars();
	}

	public void DrawChars()
	{
		for (int i = 0; i < 256; i++)
		{
			int x = i % 16;
			int y = i / 16;

			display.Board.SetTile(new Tile(i, 0, 1), x, y);
		}

		display.DrawTiles();
	}

	private void Display_MouseDown(object sender, MouseEventArgs e)
	{
		int x = display.GetTileX(e.X);
		int y = display.GetTileY(e.Y);

		Tile tile = display.Board.GetTile(x, y);
		int tileChar = tile.Chars[0].Index;
		int foreColor = workspace.CurrentTile.Chars.Count > 0 ? workspace.CurrentTile.Chars[0].ForeColor : 15;
		int backColor = workspace.CurrentTile.Chars.Count > 0 ? workspace.CurrentTile.Chars[0].BackColor : 0;

		workspace.CurrentTile.Chars.Clear();
		workspace.CurrentTile.Chars.Add(new TileChar(tileChar, foreColor, backColor));

		workspace.WorkspaceWindow.CurTileWindow.DrawTile();
	}
}
