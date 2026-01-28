namespace TileGameLib.Core;

public class Palette
{
	public const int Size = 256;

	private readonly List<int> colors = [];

	public Palette()
	{
		for (int i = 0; i < Size; i++)
			AddColor(0x000000);
	}

	public void AddColor(int rgb)
	{
		colors.Add(rgb);
	}

	public int GetColor(int index)
	{
		return colors[index];
	}

	public void SetColor(int index, int rgb)
	{
		colors[index] = rgb;
	}

	public void Load(string path)
	{
		string[] lines = File.ReadAllLines(path);
		
		colors.Clear();

		foreach (string line in lines)
			AddColor(Convert.ToInt32(line.Trim(), 16));

		while (colors.Count != Size)
			AddColor(0x000000);
	}
}
