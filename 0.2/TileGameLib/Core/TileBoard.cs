namespace TileGameLib.Core;

public class TileBoard
{
	public string Name { get; set; } = "Untitled";

	public int Cols { get; }
	public int Rows { get; }

	public int BackColor { get; set; } = 0xffffff;

	public string NorthFilename { get; set; }
	public string EastFilename { get; set; }
	public string SouthFilename { get; set; }
	public string WestFilename { get; set; }

	public enum Layer { Base, Top }

	public List<Entity> Entities { get; set; } = [];

	private readonly List<Tile> baseTiles = [];
	private readonly List<Tile> topTiles = [];

	public TileBoard(int cols, int rows)
	{
		Cols = cols;
		Rows = rows;

		for (int i = 0; i < cols * rows; i++)
		{
			baseTiles.Add(new Tile());
			topTiles.Add(new Tile());
		}
	}

	public void SetTile(Tile tile, int x, int y, Layer layer)
	{
		if (layer == Layer.Base)
			baseTiles[y * Cols + x] = tile;
		else
			topTiles[y * Cols + x] = tile;
	}

	public Tile GetTile(int x, int y, Layer layer)
	{
		if (layer == Layer.Base)
			return baseTiles[y * Cols + x];

		return topTiles[y * Cols + x];
	}

	public void Fill(Tile tile, Layer layer)
	{
		for (int i = 0; i < baseTiles.Count; i++)
		{
			if (layer == Layer.Base)
				baseTiles[i] = tile;
			else
				topTiles[i] = tile;
		}
	}

	public void Clear(Layer layer)
	{
		for (int i = 0; i < baseTiles.Count; i++)
		{
			if (layer == Layer.Base)
				baseTiles[i] = new Tile();
			else
				topTiles[i] = new Tile();
		}
	}

	public void DeleteTile(int x, int y, Layer layer)
	{
		GetTile(x, y, layer).Clear();
	}

	public Tile FindWithData(Layer layer, string key, string value)
	{
		for (int i = 0; i < baseTiles.Count; i++)
		{
			if (layer == Layer.Base)
			{
				if (baseTiles[i].Data.Has(key, value))
					return baseTiles[i];
			}
			else
			{
				if (topTiles[i].Data.Has(key, value))
					return topTiles[i];
			}
		}

		return null;
	}

	public TilePosition FindPosWithData(Layer layer, string key, string value)
	{
		for (int y = 0; y < Rows; y++)
		{
			for (int x = 0; x < Cols; x++)
			{
				Tile tile = GetTile(x, y, layer);
				if (tile.Data.Has(key, value))
					return new TilePosition(x, y, layer);
			}
		}

		return null;
	}
}
