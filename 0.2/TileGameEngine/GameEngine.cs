using TileGameEngine.Exceptions;
using TileGameLib.Core;

namespace TileGameEngine;

public class GameEngine
{
	public GameWindow Window { get; private set; }
	public Entity Player { get; private set; }
	public TileBoard Board { get; private set; }

	public GameEngine()
	{
		Window = new GameWindow(this);
	}

	public void OnGameLoaded(TileBoard firstBoard)
	{
		firstBoard.Entities.Clear();

		TilePosition playerPos = firstBoard.FindPosWithData(TileBoard.Layer.Top, "type", "player") ?? 
			throw new PlayerNotFoundException();

		Tile tile = new();
		tile.SetEqual(firstBoard.GetTile(playerPos.X, playerPos.Y, playerPos.Layer));

		firstBoard.DeleteTile(playerPos.X, playerPos.Y, playerPos.Layer);

		Player = new()
		{
			Tile = tile,
			Pos = playerPos
		};

		firstBoard.Entities.Add(Player);

		Board = firstBoard;
	}

	public bool OnKeyPress(Keys key)
	{
		if (key == Keys.Right)
		{
			if (Player.Pos.X + 1 >= Board.Cols)
			{
				if (NextBoard(Direction.East))
					Player.Pos.X = 0;
				else
				{
					SayCannotGoAnyFarther();
				}
			}
			else
			{
				Tile tile = PlayerPeek(Direction.East, TileBoard.Layer.Top);
				if (!tile.HasAnyChar)
				{
					Player.Pos.X++;
				}
			}

			Window.RedrawDisplay();
			return true;
		}
		else if (key == Keys.Left)
		{
			if (Player.Pos.X - 1 < 0)
			{
				if (NextBoard(Direction.West))
					Player.Pos.X = Board.Cols - 1;
				else
				{
					SayCannotGoAnyFarther();
				}
			}
			else
			{
				Tile tile = PlayerPeek(Direction.West, TileBoard.Layer.Top);
				if (!tile.HasAnyChar)
				{
					Player.Pos.X--;
				}
			}

			Window.RedrawDisplay();
			return true;
		}
		else if (key == Keys.Up)
		{
			if (Player.Pos.Y - 1 < 0)
			{
				if (NextBoard(Direction.North))
					Player.Pos.Y = Board.Rows - 1;
				else
				{
					SayCannotGoAnyFarther();
				}
			}
			else
			{
				Tile tile = PlayerPeek(Direction.North, TileBoard.Layer.Top);
				if (!tile.HasAnyChar)
				{
					Player.Pos.Y--;
				}
			}

			Window.RedrawDisplay();
			return true;
		}
		else if (key == Keys.Down)
		{
			if (Player.Pos.Y + 1 >= Board.Rows)
			{
				if (NextBoard(Direction.South))
					Player.Pos.Y = 0;
				else
				{
					SayCannotGoAnyFarther();
				}
			}
			else
			{
				Tile tile = PlayerPeek(Direction.South, TileBoard.Layer.Top);
				if (!tile.HasAnyChar)
				{
					Player.Pos.Y++;
				}
			}

			Window.RedrawDisplay();
			return true;
		}

		return false;
	}

	private Tile PlayerPeek(Direction dir, TileBoard.Layer layer)
	{
		if (dir == Direction.North)
			return Board.GetTile(Player.Pos.X, Player.Pos.Y - 1, layer);
		if (dir == Direction.South)
			return Board.GetTile(Player.Pos.X, Player.Pos.Y + 1, layer);
		if (dir == Direction.East)
			return Board.GetTile(Player.Pos.X + 1, Player.Pos.Y, layer);
		if (dir == Direction.West)
			return Board.GetTile(Player.Pos.X - 1, Player.Pos.Y, layer);

		return null;
	}

	private bool NextBoard(Direction dir)
	{
		if (dir == Direction.North && string.IsNullOrWhiteSpace(Board.NorthFilename))
			return false;
		if (dir == Direction.East && string.IsNullOrWhiteSpace(Board.EastFilename))
			return false;
		if (dir == Direction.South && string.IsNullOrWhiteSpace(Board.SouthFilename))
			return false;
		if (dir == Direction.West && string.IsNullOrWhiteSpace(Board.WestFilename))
			return false;

		return true;
	}

	private void SayCannotGoAnyFarther()
	{
		Say("You cannot go any farther.");
	}

	private void Say(string message)
	{
		TextWindow wnd = new(message, Board.AccentForeColor, Board.AccentBackColor);
		wnd.ShowDialog();
	}
}
