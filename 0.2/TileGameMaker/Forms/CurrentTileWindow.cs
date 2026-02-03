using TileGameLib.Controls;
using TileGameLib.Core;

namespace TileGameMaker.Forms;

public partial class CurrentTileWindow : Form
{
	private readonly Workspace workspace;
	private readonly TileBoardDisplay display;

	public CurrentTileWindow(Workspace workspace)
	{
		InitializeComponent();

		this.workspace = workspace;

		display = new TileBoardDisplay(1, 1, workspace.Charset, workspace.Palette, 200, PnlTile);
		display.ShowGrid = false;

		DataGrid.CellValueChanged += DataGrid_CellValueChanged;

		DrawTile();
	}

	private void DataGrid_CellValueChanged(object sender, DataGridViewCellEventArgs e)
	{
		workspace.CurrentTile.Data.Clear();

		foreach (DataGridViewRow row in DataGrid.Rows)
		{
			string key = row.Cells[0].Value?.ToString();
			string value = row.Cells[1].Value?.ToString();

			if (key == null)
				continue;

			workspace.CurrentTile.Data.Set(key, value ?? "");
		}
	}

	public void DrawTile()
	{
		display.Board.SetTile(workspace.CurrentTile, 0, 0, TileBoard.Layer.Base);
		display.DrawTiles();

		DataGrid.Rows.Clear();

		foreach (var data in workspace.CurrentTile.Data.GetAll())
		{
			string key = data.Key;
			string val = data.Value;

			DataGrid.Rows.Add(key, val);
		}
	}
}
