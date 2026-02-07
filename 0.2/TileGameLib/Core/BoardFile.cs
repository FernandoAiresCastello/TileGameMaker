namespace TileGameLib.Core;

public class BoardFile
{
	public static void Save(string path, TileBoard board, Palette palette, Charset charset)
	{
		RecordFile file = new();
		file.OpenToWrite(path);

		file.Write(board.Name);

		foreach (var color in palette.GetAll())
			file.Write(color);

		foreach (var chara in charset.GetAll())
			file.Write(chara);

		// BASE
		for (int y = 0; y < board.Rows; y++)
		{
			for (int x = 0; x < board.Cols; x++)
			{
				Tile tile = board.GetTile(x, y, TileBoard.Layer.Base);
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

		// TOP
		for (int y = 0; y < board.Rows; y++)
		{
			for (int x = 0; x < board.Cols; x++)
			{
				Tile tile = board.GetTile(x, y, TileBoard.Layer.Top);
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

		file.Write(board.NorthFilename);
		file.Write(board.EastFilename);
		file.Write(board.SouthFilename);
		file.Write(board.WestFilename);

		file.Write(board.AccentForeColor.ToArgb());
		file.Write(board.AccentBackColor.ToArgb());

		file.Save();
	}

	public static void Load(string path, TileBoard board, Palette palette, Charset charset)
	{
		RecordFile file = new();
		file.OpenToRead(path);

		board.Clear(TileBoard.Layer.Base);
		board.Clear(TileBoard.Layer.Top);

		board.Name = file.Read();

		for (int i = 0; i < Palette.Size; i++)
		{
			int color = file.ReadInt();
			palette.SetColor(i, color);
		}

		for (int i = 0; i < Charset.Size; i++)
		{
			string chara = file.Read();
			charset.SetChar(i, chara);
		}

		// BASE
		for (int y = 0; y < board.Rows; y++)
		{
			for (int x = 0; x < board.Cols; x++)
			{
				Tile tile = board.GetTile(x, y, TileBoard.Layer.Base);
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

		// TOP
		for (int y = 0; y < board.Rows; y++)
		{
			for (int x = 0; x < board.Cols; x++)
			{
				Tile tile = board.GetTile(x, y, TileBoard.Layer.Top);
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

		board.NorthFilename = file.Read();
		board.EastFilename = file.Read();
		board.SouthFilename = file.Read();
		board.WestFilename = file.Read();

		board.AccentForeColor = Color.FromArgb(file.ReadInt());
		board.AccentBackColor = Color.FromArgb(file.ReadInt());
	}
}
