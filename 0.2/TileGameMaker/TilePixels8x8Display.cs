using TileGameLib.Controls;
using TileGameLib.Core;

namespace TileGameMaker;

public partial class TilePixels8x8Display : PixelCanvasDisplay
{
	public TilePixels8x8Display(Control parent) : base(8 * Tile.Width, 8 * Tile.Height, parent)
	{
		InitializeComponent();
	}

	public void DrawTilePixels(Charset charset, int index)
	{
		string pixels = charset.GetChar(index);

		int x = 0;
		int y = 0;

		foreach (char pix in pixels)
		{
			if (pix == '1')
				canvas.DrawSolidPixelBlock(x, y, 0x000000);
			else
				canvas.DrawSolidPixelBlock(x, y, 0xffffff);

			x++;
			if (x > 7)
			{
				x = 0; y++;
			}
		}
	}
}
