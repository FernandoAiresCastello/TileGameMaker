﻿namespace TileGameLib.Core.TileTypes;

public class AnimatedTile : Tile
{
	public List<TileImage> Images { get; set; } = [];
	public static int CurrentFrame { get; set; } = 0;
	public static bool AnimationEnabled { get; set; } = true;

	public AnimatedTile() {}
	public AnimatedTile(List<TileImage> images) => Images = images;

	public override void Draw(TileCanvas canvas, int col, int row)
	{
		canvas.DrawTile(Images[CurrentFrame % Images.Count], col, row);
	}

	public static void NextFrame()
	{
		if (AnimationEnabled)
			CurrentFrame++;
	}
}
