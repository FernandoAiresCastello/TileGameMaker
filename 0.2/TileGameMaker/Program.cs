using TileGameMaker.Forms;

namespace TileGameMaker;

internal static class Program
{
    [STAThread]
    static void Main()
    {
        ApplicationConfiguration.Initialize();
        Application.Run(new WorkspaceWindow());
    }
}
