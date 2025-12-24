namespace TileGameLib;

public class Tile
{
	public List<TileChar> Chars { get; set; } = [];

	public TileChar GetChar(int index) => Chars[index % Chars.Count];
}
