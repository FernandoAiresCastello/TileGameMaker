namespace TileGameLib.Util;

/// <summary>
///		Collection of key-value pairs for storing arbitrary data.
/// </summary>
public class Dataset
{
	private readonly Dictionary<string, object> Data = [];

	public int Count => Data.Count;

	public void Clear() => Data.Clear();

	public void Set(string key, object value) => Data.Add(key.ToLower(), value);

	public bool Has(string key) => Data.ContainsKey(key.ToLower());

	public bool Has(string key, string value) => 
		Has(key) && GetString(key) == value.ToString();

	public bool Has(string key, int value) =>
		Has(key) && GetNumber(key) == value;

	public T Get<T>(string key) => Has(key) ? (T)Data[key] : default;

	public object GetObject(string key) =>
		Data.TryGetValue(key.ToLower(), out var value) ? value : default;

	public string GetString(string key) =>
		Data.TryGetValue(key.ToLower(), out var value) ? value.ToString() : default;

	public int GetNumber(string key) =>
		Data.TryGetValue(key.ToLower(), out var value) ? int.Parse(value.ToString()) : default;
}
