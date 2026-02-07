using TileGameLib.Controls;
using TileGameLib.Core;
using TileGameMaker.Dialogs;

namespace TileGameMaker.Forms;

public partial class BoardWindow : Form
{
	private readonly Workspace workspace;
	private readonly TileBoardDisplay display;

	private TileBoard.Layer layer = TileBoard.Layer.Base;

	public BoardWindow(Workspace workspace)
	{
		InitializeComponent();

		this.workspace = workspace;
		DoubleBuffered = true;

		display = new TileBoardDisplay(160 / 8, 144 / 8, workspace.Charset, workspace.Palette, 400, PnlBoard);
		display.Board.BackColor = 0xffffff;

		display.MouseMove += Display_MouseMove;
		display.MouseDown += Display_MouseDown;
		display.MouseUp += Display_MouseUp;

		LbName.Text = display.Board.Name;
		PnlTitle.ForeColor = display.Board.AccentForeColor;
		PnlTitle.BackColor = display.Board.AccentBackColor;

		LbLayer.Text = "Base";
	}

	private void Display_MouseUp(object sender, MouseEventArgs e)
	{
		if (BtnPencil.Checked)
		{
			if (e.Button == MouseButtons.Middle)
				InsertTile(e);
		}
	}

	private void Display_MouseDown(object sender, MouseEventArgs e)
	{
		if (BtnPencil.Checked)
		{
			if (e.Button == MouseButtons.Left)
				PutTile(e);
			else if (e.Button == MouseButtons.Right)
				GrabTile(e);
		}
		else if (BtnEraser.Checked)
		{
			if (e.Button == MouseButtons.Left)
				DeleteTile(e);
		}
	}

	private void Display_MouseMove(object sender, MouseEventArgs e)
	{
		if (BtnPencil.Checked)
		{
			if (e.Button == MouseButtons.Left)
				PutTile(e);
		}
		else if (BtnEraser.Checked)
		{
			if (e.Button == MouseButtons.Left)
				DeleteTile(e);
		}
	}

	private void PutTile(MouseEventArgs e)
	{
		int x = display.GetTileX(e.X);
		int y = display.GetTileY(e.Y);

		if (x >= 0 && y >= 0 && x < display.Board.Cols && y < display.Board.Rows)
		{
			display.Board.GetTile(x, y, layer).SetEqual(workspace.CurrentTile);
			display.DrawTiles();
		}
	}

	private void DeleteTile(MouseEventArgs e)
	{
		int x = display.GetTileX(e.X);
		int y = display.GetTileY(e.Y);

		if (x >= 0 && y >= 0 && x < display.Board.Cols && y < display.Board.Rows)
		{
			display.Board.GetTile(x, y, layer).Clear();
			display.DrawTiles();
		}
	}

	private void InsertTile(MouseEventArgs e)
	{
		int x = display.GetTileX(e.X);
		int y = display.GetTileY(e.Y);

		if (x >= 0 && y >= 0 && x < display.Board.Cols && y < display.Board.Rows)
		{
			display.Board.GetTile(x, y, layer).AddChars(workspace.CurrentTile);
			display.DrawTiles();
		}
	}

	private void GrabTile(MouseEventArgs e)
	{
		int x = display.GetTileX(e.X);
		int y = display.GetTileY(e.Y);

		Tile tile = display.Board.GetTile(x, y, layer);

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

		LbName.Text = board.Name;
		PnlTitle.ForeColor = board.AccentForeColor;
		PnlTitle.BackColor = board.AccentBackColor;
	}

	private void SaveBoard(string path)
	{
		TileBoard board = display.Board;
		Palette palette = workspace.Palette;
		Charset charset = workspace.Charset;

		BoardFile.Save(path, board, palette, charset);
	}

	private void BtnPencil_Click(object sender, EventArgs e)
	{
		BtnEraser.Checked = false;
	}

	private void BtnEraser_Click(object sender, EventArgs e)
	{
		BtnPencil.Checked = false;
	}

	private void BtnDirections_Click(object sender, EventArgs e)
	{
		DirectionsDialog dialog = new(display.Board);
		if (dialog.ShowDialog() != DialogResult.OK)
			return;

		display.Board.NorthFilename = dialog.NorthFilename;
		display.Board.SouthFilename = dialog.SouthFilename;
		display.Board.EastFilename = dialog.EastFilename;
		display.Board.WestFilename = dialog.WestFilename;
	}

	private void BtnLayer_Click(object sender, EventArgs e)
	{
		if (BtnLayer.Checked)
		{
			layer = TileBoard.Layer.Top;
			LbLayer.Text = "Top";
		}
		else
		{
			layer = TileBoard.Layer.Base;
			LbLayer.Text = "Base";
		}
	}

	private void BtnProperties_Click(object sender, EventArgs e)
	{
		MapPropertiesDialog dialog = new(display.Board.Name, display.Board.AccentForeColor, display.Board.AccentBackColor);
		if (dialog.ShowDialog() != DialogResult.OK)
			return;

		display.Board.Name = dialog.Title;
		display.Board.AccentBackColor = dialog.AccentBackColor;
		display.Board.AccentForeColor = dialog.AccentForeColor;

		LbName.Text = display.Board.Name;
		PnlTitle.BackColor = dialog.AccentBackColor;
		PnlTitle.ForeColor = dialog.AccentForeColor;
	}
}
