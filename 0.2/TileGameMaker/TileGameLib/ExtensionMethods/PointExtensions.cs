namespace TileGameLib.ExtensionMethods;

public static class PointExtensions
{
	public static bool IsInside(this Point point, int x, int y, int width, int height) =>
		point.X >= x && point.Y >= y && point.X < width && point.Y < height;

	public static bool IsOutside(this Point point, int x, int y, int width, int height) =>
		!IsInside(point, x, y, width, height);
}
