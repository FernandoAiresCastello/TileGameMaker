using TileGameLib.Core;
using TileGameMaker.Forms;

namespace TileGameMaker;

public class Workspace
{
	public Palette Palette { get; set; } = new();
	public Charset Charset { get; set; } = new();
	public Tile CurrentTile { get; set; } = new Tile('?', 0, 15);
	public WorkspaceWindow WorkspaceWindow { get; set; }

	public Workspace(WorkspaceWindow workspaceWindow)
	{
		WorkspaceWindow = workspaceWindow;

		Palette.Load("palette.dat");
		Charset.Load("charset.dat");

		CurrentTile.Data.Set("Test Data", "12345");
	}
}
