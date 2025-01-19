namespace TileGameLib.Core;

/// <summary>
///		A container for tile objects.
/// </summary>
public class TileBuffer
{
	public int Cols { get; private set; }
	public int Rows { get; private set; }
	public int LastCol { get; private set; }
	public int LastRow { get; private set; }
	public int CellCount { get; private set; }

	public Tile[,] Tiles { get; private set; }

	/// <summary>
	///		Constructs a new TileBuffer
	/// </summary>
	/// <param name="cols">Number of tile columns</param>
	/// <param name="rows">Number of tile rows</param>

	public TileBuffer(int cols, int rows)
	{
		SetSize(cols, rows);
	}

	private void SetSize(int cols, int rows)
	{
		Cols = cols;
		Rows = rows;
		LastCol = cols - 1;
		LastRow = rows - 1;
		CellCount = cols * rows;

		Tiles = new Tile[Cols, Rows];

		for (int row = 0; row < rows; row++)
			for (int col = 0; col < cols; col++)
				Tiles[row, col] = new();
	}

	public Tile At(Point cellPos) => At(cellPos.X, cellPos.Y);

	public Tile At(int col, int row)
	{
		if (col >= 0 && row >= 0 && col < Cols && row < Rows)
			return Tiles[col, row];

		throw new Exception($"Cell position out of bounds. Col:{col} Row:{row}");
	}

	public Tile At(int cellIndex)
	{
		int col = cellIndex % Cols;
		int row = cellIndex / Cols;

		return At(col, row);
	}
}
