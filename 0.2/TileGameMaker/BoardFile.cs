using TileGameLib.Core;

namespace TileGameMaker;

public class BoardFile
{
	public static void Save(string path, TileBoard board, Palette palette, Charset charset)
	{
		RecordFile file = new();
		file.OpenToWrite(path);

		file.Write(board.Name);
		file.Write(board.BackColor);

		for (int y = 0; y < board.Rows; y++)
		{
			for (int x = 0; x < board.Cols; x++)
			{
				Tile tile = board.GetTile(x, y);
				file.Write(tile.Chars.Count);

				foreach (var ch in tile.Chars)
				{
					file.Write(ch.Index);
					file.Write(ch.ForeColor);
					file.Write(ch.BackColor);
				}

				file.Write(tile.Data.GetAll().Count);

				foreach (var data in tile.Data.GetAll())
				{
					file.Write(data.Key);
					file.Write(data.Value);
				}
			}
		}

		file.Save();
	}

	public static void Load(string path, TileBoard board, Palette palette, Charset charset)
	{
		RecordFile file = new();
		file.OpenToRead(path);

		board.Name = file.Read();
		board.BackColor = file.ReadInt();

		board.Clear();

		for (int y = 0; y < board.Rows; y++)
		{
			for (int x = 0; x < board.Cols; x++)
			{
				Tile tile = board.GetTile(x, y);
				int charCount = file.ReadInt();

				for (int i = 0; i < charCount; i++)
				{
					int index = file.ReadInt();
					int foreColor = file.ReadInt();
					int backColor = file.ReadInt();

					tile.AddChar(index, foreColor, backColor);
				}

				int dataCount = file.ReadInt();

				for (int i = 0; i < dataCount; i++)
				{
					string key = file.Read();
					string value = file.Read();

					tile.Data.Set(key, value);
				}
			}
		}
	}
}
