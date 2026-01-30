namespace TileGameLib.Core;

public class TileBoard
{
	public string Name { get; set; } = "Untitled";

	public int Cols { get; }
	public int Rows { get; }

	public int BackColor { get; set; } = 0xffffff;

	private readonly List<Tile> tiles = [];

	public TileBoard(int cols, int rows)
	{
		Cols = cols;
		Rows = rows;

		for (int i = 0; i < cols * rows; i++)
			tiles.Add(new Tile());
	}

	public void SetTile(Tile tile, int x, int y)
	{
		tiles[y * Cols + x] = tile;
	}

	public Tile GetTile(int x, int y)
	{
		return tiles[y * Cols + x];
	}

	public void Fill(Tile tile)
	{
		for (int i = 0; i < tiles.Count; i++)
			tiles[i] = tile;
	}

	public void Clear()
	{
		for (int i = 0; i < tiles.Count; i++)
			tiles[i] = new Tile();
	}
}
