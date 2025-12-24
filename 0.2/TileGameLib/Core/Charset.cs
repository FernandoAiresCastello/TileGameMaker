namespace TileGameLib.Core;

public class Charset
{
	public const int Size = 512;

	public static readonly string BlankChar = new('0', 64);
	public static readonly string FilledChar = new('1', 64);

	private readonly List<string> chars = [];

	public Charset()
	{
		for (int i = 0; i < Size; i++)
			AddChar(BlankChar);
	}

	public void AddChar(string bits)
	{
		chars.Add(bits);
	}

	public string GetChar(int index)
	{
		return chars[index];
	}

	public void Load(string path)
	{
		string[] lines = File.ReadAllLines(path);
		
		chars.Clear();

		foreach (string line in lines)
			AddChar(line);

		while (chars.Count != Size)
			AddChar(BlankChar);
	}
}
