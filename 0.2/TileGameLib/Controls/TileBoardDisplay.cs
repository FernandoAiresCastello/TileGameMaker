using System.ComponentModel;
using TileGameLib.Core;
using Timer = System.Windows.Forms.Timer;

namespace TileGameLib.Controls;

public partial class TileBoardDisplay : PixelCanvasDisplay
{
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public TileBoard Board { get; set; }
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Charset Charset { get; set; }
	[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
	public Palette Palette { get; set; }

	// Animation
	private readonly Timer animationTimer;
	private int animationIndex = 0;

	public TileBoardDisplay(int cols, int rows, Charset charset, Palette palette, int animationInterval, Control control) : 
		base(cols * Tile.Width, rows * Tile.Height, control)
	{
		InitializeComponent();

		Stretch = true;
		Board = new TileBoard(cols, rows);
		Charset = charset;
		Palette = palette;

		DrawTiles();

		animationTimer = new();
		animationTimer.Interval = animationInterval;
		animationTimer.Tick += (sender, e) => DrawTiles();
		animationTimer.Start();
	}

	private void DrawTiles()
	{
		canvas.Clear(Board.BackColor);

		for (int y = 0; y < Board.Rows; y++)
		{
			for (int x = 0; x < Board.Cols; x++)
			{
				Tile tile = Board.GetTile(x, y);
				if (!tile.HasAnyChar)
					continue;

				TileChar tileChar = tile.GetChar(animationIndex);

				if (tile.Transparent)
					canvas.DrawPixelBlock(Charset, Palette, tileChar.Index, x, y, tileChar.ForeColor);
				else
					canvas.DrawPixelBlock(Charset, Palette, tileChar.Index, x, y, tileChar.ForeColor, tileChar.BackColor);
			}
		}

		animationIndex++;

		Invalidate();
	}
}
