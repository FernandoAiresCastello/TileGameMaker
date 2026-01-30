using TileGameLib.Controls;
using TileGameLib.Core;

namespace TileGameMaker.Forms;

public partial class BoardWindow : Form
{
	private readonly Workspace workspace;
	private readonly TileBoardDisplay display;

	public BoardWindow(Workspace workspace)
	{
		InitializeComponent();

		this.workspace = workspace;
		DoubleBuffered = true;

		display = new TileBoardDisplay(160 / 8, 144 / 8, workspace.Charset, workspace.Palette, 200, PnlBoard);
		display.Board.BackColor = 0xffffff;

		display.MouseMove += Display_MouseMove;
		display.MouseDown += Display_MouseDown;
		display.MouseUp += Display_MouseUp;
	}

	private void Display_MouseUp(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Middle)
			InsertTile(e);
	}

	private void Display_MouseDown(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
			PutTile(e);
		else if (e.Button == MouseButtons.Right)
			GrabTile(e);
	}

	private void Display_MouseMove(object sender, MouseEventArgs e)
	{
		int x = display.GetTileX(e.X);
		int y = display.GetTileY(e.Y);

		if (e.Button == MouseButtons.Left)
			PutTile(e);
	}

	private void PutTile(MouseEventArgs e)
	{
		int x = display.GetTileX(e.X);
		int y = display.GetTileY(e.Y);

		if (x >= 0 && y >= 0 && x < display.Board.Cols && y < display.Board.Rows)
		{
			display.Board.GetTile(x, y).SetEqual(workspace.CurrentTile);
			display.DrawTiles();
		}
	}

	private void InsertTile(MouseEventArgs e)
	{
		int x = display.GetTileX(e.X);
		int y = display.GetTileY(e.Y);

		if (x >= 0 && y >= 0 && x < display.Board.Cols && y < display.Board.Rows)
		{
			display.Board.GetTile(x, y).AddChars(workspace.CurrentTile);
			display.DrawTiles();
		}
	}

	private void GrabTile(MouseEventArgs e)
	{
		int x = display.GetTileX(e.X);
		int y = display.GetTileY(e.Y);

		Tile tile = display.Board.GetTile(x, y);

		workspace.CurrentTile.SetEqual(tile);
		workspace.WorkspaceWindow.CurTileWindow.DrawTile();
	}

	private void BtnGridToggle_Click(object sender, EventArgs e)
	{
		display.ShowGrid = BtnGridToggle.Checked;
		display.Invalidate();
	}

	private void BtnLoad_Click(object sender, EventArgs e)
	{
		OpenFileDialog dialog = new();
		if (dialog.ShowDialog() != DialogResult.OK)
			return;

		LoadBoard(dialog.FileName);
	}

	private void BtnSave_Click(object sender, EventArgs e)
	{
		SaveFileDialog dialog = new();
		if (dialog.ShowDialog() != DialogResult.OK)
			return;

		SaveBoard(dialog.FileName);
	}

	private void LoadBoard(string path)
	{
		TileBoard board = display.Board;
		Palette palette = workspace.Palette;
		Charset charset = workspace.Charset;

		BoardFile.Load(path, board, palette, charset);
	}

	private void SaveBoard(string path)
	{
		TileBoard board = display.Board;
		Palette palette = workspace.Palette;
		Charset charset = workspace.Charset;

		BoardFile.Save(path, board, palette, charset);
	}
}
