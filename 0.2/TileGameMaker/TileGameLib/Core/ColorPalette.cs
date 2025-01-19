using TileGameLib.ExtensionMethods;

namespace TileGameLib.Core;

public class ColorPalette
{
	public List<Color> Colors { get; private set; } = [];

	public int Count => Colors.Count;

	public void Add(Color color) => Colors.Add(color);
	public void Add(string hexColor)
	{
		string hex = hexColor;

		if (hex.StartsWith('#'))
			hex = hex[1..];
		else if (hex.StartsWith("0x"))
			hex = hex[2..];

		Add(ColorTranslator.FromHtml("#" + hex));
	}

	public void Set(int index, Color color) => Colors[index] = color;
	public void Set(int index, string hexColor)
	{
		Set(index, ColorUtils.FromHex(hexColor).Value);
	}

	public void SetColors(List<Color> colors) => Colors = colors;
	public void SetColors(List<string> hexColors)
	{
		foreach (string hexColor in hexColors)
			Add(hexColor);
	}

	public Color? Get(int index)
	{
		if (index >= 0 && index < Colors.Count)
			return Colors[index];

		return null;
	}

	public string GetHex(int index)
	{
		if (index >= 0 && index < Colors.Count)
			return Colors[index].ToHex();

		return null;
	}

	public void Load(string path)
	{
		RemoveAll();

		foreach (string line in File.ReadAllLines(path))
		{
			if (!string.IsNullOrWhiteSpace(line))
				Add(line);
		}
	}

	public void RemoveAll()
	{
		Colors.Clear();
	}
}
