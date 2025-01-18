using TileGameLib.Util;

namespace TileGameLib.GraphicsBase;

/// <summary>
///		Represents an off-screen graphical object where tile-based images can be drawn on a grid.
///		Can also hold arbitrary data (<see cref="Dataset"/>) for each cell on the grid.
///		To actually show this object on screen, a <see cref="TileDisplay"/> control is required.
/// </summary>
public class TileCanvas
{
	public readonly int Cols;
	public readonly int Rows;
	public readonly int CellCount;
	public readonly int CellWidth;
	public readonly int CellHeight;

	public PixelBuffer Buffer { get; private set; }

	public int Width => Buffer.Width;
	public int Height => Buffer.Height;

	private readonly Dataset[,] TileData;

	public TileCanvas(int cols, int rows, int cellWidth, int cellHeight, Color color)
	{
		Cols = cols;
		Rows = rows;
		CellCount = cols * rows;
		CellWidth = cellWidth;
		CellHeight = cellHeight;

		Buffer = new PixelBuffer(cols * cellWidth, rows * cellHeight, color);
		TileData = new Dataset[Rows, Cols];

		for (int row = 0; row < rows; row++)
			for (int col = 0; col < cols; col++)
				TileData[row, col] = new();
	}

	public void Clear(Color color)
	{
		Buffer.Clear(color);
	}

	public void DrawColor(Color color, int col, int row)
	{
		DrawTile(new(CellWidth, CellHeight, color), col, row);
	}

	public void DrawColor(Color color, int cellIndex)
	{
		DrawTile(new(CellWidth, CellHeight, color), cellIndex);
	}

	public void DrawTile(TileImage tile, int col, int row)
	{
		DrawFreeTile(tile, col * CellWidth, row * CellHeight);
	}

	public void DrawTile(TileImage tile, int cellIndex)
	{
		int col = cellIndex % Cols;
		int row = cellIndex / Cols;

		DrawFreeTile(tile, col * CellWidth, row * CellHeight);
	}

	public void DrawFreeTile(TileImage tile, int x, int y)
	{
		int initialX = x;
		int initialY = y;
		int bufX = initialX;
		int bufY = initialY;

		for (int imageY = 0; imageY < tile.Height && imageY < CellHeight; imageY++)
		{
			for (int imageX = 0; imageX < tile.Width && imageY < CellWidth; imageX++)
			{
				Buffer.SetPixel(bufX, bufY, tile.GetPixel(imageX, imageY));
				bufX++;
			}
			bufY++;
			bufX = initialX;
		}
	}

	public Dataset Data(Point cellPos) => Data(cellPos.X, cellPos.Y);

	public Dataset Data(int col, int row)
	{
		if (row >= 0 && col >= 0 && row < Rows && col < Cols)
			return TileData[row, col];

		throw new Exception($"Cell position out of bounds. Col:{col} Row:{row}");
	}

	public Dataset Data(int cellIndex)
	{
		int col = cellIndex % Cols;
		int row = cellIndex / Cols;

		return Data(col, row);
	}
}
