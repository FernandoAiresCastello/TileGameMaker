using TileGameLib.Controls;
using TileGameLib.Core;

namespace TileGameMaker;

public partial class Tile8x8Editor : Form
{
	private readonly Charset charset;
	private readonly int charIndex;

	private TilePixels8x8Display display;

	public Tile8x8Editor(Charset charset, int charIndex, int zoom)
	{
		InitializeComponent();

		display = new TilePixels8x8Display(PnlDisplay);
		display.Zoom = zoom;

		this.charset = charset;
		this.charIndex = charIndex;

		display.DrawTilePixels(charset, charIndex);
		display.MouseDown += Display_MouseDown;
	}

	private void Display_MouseDown(object sender, MouseEventArgs e)
	{
		int x = display.GetTileX(e.X);
		int y = display.GetTileY(e.Y);

		int pixelIndex = y * Tile.Width + x;

		char[] pixels = charset.GetChar(1).ToCharArray();
		if (pixels[pixelIndex] == '0')
			pixels[pixelIndex] = '1';
		else
			pixels[pixelIndex] = '0';

		charset.SetChar(1, new string(pixels));

		display.DrawTilePixels(charset, charIndex);
		display.Invalidate();
	}
}
