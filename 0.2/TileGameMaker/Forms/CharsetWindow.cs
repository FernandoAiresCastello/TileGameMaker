using TileGameLib.Controls;
using TileGameLib.Core;

namespace TileGameMaker.Forms;

public partial class CharsetWindow : Form
{
	private readonly Palette palette;
	private readonly Workspace workspace;
	private readonly TileBoardDisplay display;

	private int FirstChar = 0;
	private const int CharsPerRow = 16;
	private const int CharsPerCol = 16;

	public CharsetWindow(Workspace workspace)
	{
		InitializeComponent();

		this.workspace = workspace;
		DoubleBuffered = true;

		palette = new Palette();
		palette.SetColor(0, 0x000000);
		palette.SetColor(1, 0xffffff);

		display = new TileBoardDisplay(CharsPerRow, CharsPerCol, workspace.Charset, palette, 200, PnlCharset);
		display.Board.BackColor = palette.GetColor(1);

		display.MouseDown += Display_MouseDown;
		display.MouseWheel += Display_MouseWheel;

		DrawChars();
	}

	private void Display_MouseWheel(object sender, MouseEventArgs e)
	{
		if (e.Delta > 0)
		{
			FirstChar -= CharsPerRow;
			if (FirstChar < 0)
				FirstChar = 0;
		}
		else
		{
			FirstChar += CharsPerRow;
			if (FirstChar >= Charset.Size - CharsPerRow * CharsPerCol)
				FirstChar = Charset.Size - CharsPerRow * CharsPerCol;
		}

		DrawChars();
	}

	public void DrawChars()
	{
		int x = 0;
		int y = 0;

		for (int i = FirstChar; i < FirstChar + 256; i++)
		{
			display.Board.SetTile(new Tile(i, 0, 1), x, y);

			x++;
			if (x >= CharsPerRow)
			{
				x = 0;
				y++;
			}
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

	private void BtnLoad_Click(object sender, EventArgs e)
	{
		OpenFileDialog dialog = new();
		if (dialog.ShowDialog() != DialogResult.OK)
			return;

		workspace.Charset.Load(dialog.FileName);

		FirstChar = 0;

		DrawChars();
	}

	private void BtnSave_Click(object sender, EventArgs e)
	{
		SaveFileDialog dialog = new();
		if (dialog.ShowDialog() != DialogResult.OK)
			return;

		workspace.Charset.Save(dialog.FileName);
	}
}
