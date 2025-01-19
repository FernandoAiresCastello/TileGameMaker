namespace TileGameLib.Core;

/// <summary>
///		Represents an off-screen graphical object where tile-based images can be drawn on a grid.
///		To actually show this object on screen, a <see cref="TileDisplay"/> control is required.
/// </summary>
public class TileCanvas(int cols, int rows, int cellWidth, int cellHeight, Color color)
{
	public readonly int Cols = cols;
	public readonly int Rows = rows;
	public readonly int LastCol = cols - 1;
	public readonly int LastRow = rows - 1;
	public readonly int CellCount = cols * rows;
	public readonly int CellWidth = cellWidth;
	public readonly int CellHeight = cellHeight;

	public PixelBuffer Buffer { get; private set; } = new PixelBuffer(cols * cellWidth, rows * cellHeight, color);

	public int Width => Buffer.Width;
	public int Height => Buffer.Height;

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
}
