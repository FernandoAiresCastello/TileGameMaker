using TileGameLib.Controls;
using TileGameLib.Core;

namespace TileGameMaker.Forms;

public partial class PaletteWindow : Form
{
	private readonly Charset charset;
	private readonly Workspace workspace;
	private readonly TileBoardDisplay display;

	public PaletteWindow(Workspace workspace)
	{
		InitializeComponent();

		this.workspace = workspace;
		DoubleBuffered = true;

		charset = new Charset();

		display = new TileBoardDisplay(16, 16, charset, workspace.Palette, 200, PnlPalette);

		display.MouseDown += Display_MouseDown;

		DrawColors();
	}

	public void DrawColors()
	{
		for (int i = 0; i < Palette.Size; i++)
		{
			int x = i % 16;
			int y = i / 16;

			display.Board.SetTile(new Tile(0, i, i), x, y, TileBoard.Layer.Base);
		}

		display.DrawTiles();
	}

	private void Display_MouseDown(object sender, MouseEventArgs e)
	{
		int x = display.GetTileX(e.X);
		int y = display.GetTileY(e.Y);

		Tile tile = display.Board.GetTile(x, y, TileBoard.Layer.Base);
		int tileChar = workspace.CurrentTile.Chars.Count > 0 ? workspace.CurrentTile.Chars[0].Index : 0;

		if (e.Button == MouseButtons.Left)
		{
			int foreColor = tile.Chars[0].ForeColor;
			int backColor = workspace.CurrentTile.Chars.Count > 0 ? workspace.CurrentTile.Chars[0].BackColor : 0;

			workspace.CurrentTile.Chars.Clear();
			workspace.CurrentTile.Chars.Add(new TileChar(tileChar, foreColor, backColor));
		}
		else if (e.Button == MouseButtons.Right)
		{
			int foreColor = workspace.CurrentTile.Chars.Count > 0 ? workspace.CurrentTile.Chars[0].ForeColor : 0;
			int backColor = tile.Chars[0].BackColor;

			workspace.CurrentTile.Chars.Clear();
			workspace.CurrentTile.Chars.Add(new TileChar(tileChar, foreColor, backColor));
		}

		workspace.WorkspaceWindow.CurTileWindow.DrawTile();
	}

	private void BtnLoad_Click(object sender, EventArgs e)
	{
		OpenFileDialog dialog = new();
		if (dialog.ShowDialog() != DialogResult.OK)
			return;

		workspace.Palette.Load(dialog.FileName);

		DrawColors();
	}

	private void BtnSave_Click(object sender, EventArgs e)
	{
		SaveFileDialog dialog = new();
		if (dialog.ShowDialog() != DialogResult.OK)
			return;

		workspace.Palette.Save(dialog.FileName);
	}
}
