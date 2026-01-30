using TileGameLib.Core;
using TileGameMaker.Forms;

namespace TileGameMaker;

public class Workspace
{
	public Palette Palette { get; set; } = new();
	public Charset Charset { get; set; } = new();
	public Tile CurrentTile { get; set; } = new Tile('?', 0, 15);
	public WorkspaceWindow WorkspaceWindow { get; set; }
	public string FilesPath { get; set; }

	public Workspace(WorkspaceWindow workspaceWindow, string filesPath)
	{
		WorkspaceWindow = workspaceWindow;
		FilesPath = Path.Combine("projects", filesPath);

		Palette.Load(Path.Combine(FilesPath, "palette.dat"));
		Charset.Load(Path.Combine(FilesPath, "charset.dat"));
	}
}
