namespace TileGameEngine;

internal static class Program
{
	[STAThread]
	static void Main(string[] args)
	{
		ApplicationConfiguration.Initialize();

		GameEngine engine = new();
		Application.Run(engine.Window);
	}
}
