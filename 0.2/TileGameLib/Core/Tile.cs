namespace TileGameLib.Core;

public class Tile
{
	public const int Width = 8;
	public const int Height = 8;

	public List<TileChar> Chars { get; set; } = [];
	public bool HasAnyChar => Chars.Count > 0;
	public TileData Data { get; set; }

	public bool Transparent { get; set; } = false;

	public Tile()
	{
	}

	public Tile(int index, int foreColor, int backColor)
	{
		Chars.Add(new TileChar(index, foreColor, backColor));
	}

	public TileChar GetChar(int index) => Chars[index % Chars.Count];
	public void AddChar(TileChar tileChar) => Chars.Add(tileChar);
	public void AddChar(int index, int foreColor, int backColor) => Chars.Add(new TileChar(index, foreColor, backColor));

	public void SetEqual(Tile other)
	{
		Chars.Clear();
		foreach (var ch in other.Chars)
			Chars.Add(new(ch.Index, ch.ForeColor, ch.BackColor));

		Data.CopyFrom(other.Data);
		Transparent = other.Transparent;
	}
}
