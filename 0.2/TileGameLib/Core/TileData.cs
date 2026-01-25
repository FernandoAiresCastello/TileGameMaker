namespace TileGameLib.Core;

public class TileData
{
	private readonly Dictionary<string, string> Entries = [];

	public TileData()
	{
	}

	public TileData(Dictionary<string, string> entries)
	{
		Entries = new Dictionary<string, string>(entries);
	}

	public void Set(string key, string value)
	{
		Entries[key] = value;
	}

	public Dictionary<string, string> GetAll()
	{
		return Entries;
	}

	public TileData GetCopy()
	{
		return new TileData(Entries);
	}

	public void CopyFrom(TileData other)
	{
		Entries.Clear();
		foreach (string key in other.Entries.Keys)
			Entries[key] = other.Entries[key];
	}

	public string Get(string key)
	{
		if (Entries.TryGetValue(key, out string value))
			return value;

		throw new KeyNotFoundException();
	}

	public int GetInt(string key)
	{
		if (Entries.TryGetValue(key, out string value))
			return int.Parse(value);

		throw new KeyNotFoundException();
	}

	public bool Has(string key)
	{
		return Entries.ContainsKey(key);
	}

	public bool Has(string key, string value)
	{
		if (!Has(key))
			return false;

		return Get(key) == value;
	}

	public void Clear()
	{
		Entries.Clear();
	}
}
