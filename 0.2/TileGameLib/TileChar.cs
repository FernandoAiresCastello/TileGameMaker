namespace TileGameLib;

public class TileChar
{
	public int Index { get; set; }
	public int ForeColor { get; set; }
	public int BackColor { get; set; }

	public TileChar()
	{
		Index = 0;
		ForeColor = 0;
		BackColor = 0;
	}

	public TileChar(int index, int foreColor, int backColor)
	{
		Index = index;
		ForeColor = foreColor;
		BackColor = backColor;
	}
}
