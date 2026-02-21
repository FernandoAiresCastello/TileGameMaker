using System.Text;

namespace TileGameLib.Core;

public class RecordFile
{
	public const string RecordSeparator = "|";
	
	private StringBuilder contents;
	private int readIndex = 0;
	private bool readMode = false;
	private string path;
	private List<string> readBuffer;
	private bool isOpen = false;

	public void Write(object o)
	{
		if (readMode)
			throw new InvalidOperationException("Cannot write to file in read mode.");

		if (!isOpen)
			throw new InvalidOperationException("Cannot write to closed file.");

		contents.Append(o.ToString() + RecordSeparator);
	}

	public string Read()
	{
		if (readIndex >= readBuffer.Count)
			throw new InvalidOperationException("Cannot read past end of file.");

		if (!isOpen)
			throw new InvalidOperationException("Cannot read from closed file.");

		return readBuffer[readIndex++];
	}

	public int ReadInt()
	{
		return int.Parse(Read());
	}

	public void Save()
	{
		File.WriteAllText(path, contents.ToString(), Encoding.UTF8);
	}

	public void OpenToRead(string path)
	{
		this.path = path;
		readMode = true;
		contents = new();
		isOpen = true;
		readIndex = 0;

		string rawContents = File.ReadAllText(path, Encoding.UTF8);
		readBuffer = [.. rawContents.Split(RecordSeparator)];
	}

	public void OpenToWrite(string path)
	{
		this.path = path;
		readMode = false;
		contents = new();
		isOpen = true;
	}
}
