﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TileGameLib.Graphics
{
    public class MCTile
    {
        public const int Width = 8;
        public const int Height = 8;
        public const int TransparentColorIndex = -1;

        private int[,] Pixels;

        public MCTile()
        {
            Pixels = new int[Width, Height];
            SetAllPixels(TransparentColorIndex);
        }

        public MCTile(string pattern)
        {
            SetPattern(pattern);
        }

        public MCTile(MCTile other)
        {
            SetEqual(other);
        }

        public MCTile Copy()
        {
            return new MCTile(this);
        }

        public static MCTile MakeTransparent()
        {
            MCTile tile = new MCTile();
            tile.SetAllPixels(TransparentColorIndex);
            return tile;
        }

        public static MCTile MakeSolidColor(int paletteIndex)
        {
            MCTile tile = new MCTile();
            tile.SetAllPixels(paletteIndex);
            return tile;
        }

        public void SetEqual(MCTile other)
        {
            Pixels = new int[Width, Height];

            for (int row = 0; row < Height; row++)
                for (int col = 0; col < Width; col++)
                    Pixels[col, row] = other.Pixels[col, row];
        }

        public void SetAllPixels(int paletteIndex)
        {
            for (int row = 0; row < Height; row++)
                for (int col = 0; col < Width; col++)
                    Pixels[col, row] = paletteIndex;
        }

        public void SetPattern(string pattern)
        {
            int col = 0;
            int row = 0;

            foreach (string ix in pattern.Split(','))
            {
                int paletteIndex = int.Parse(ix.Trim());
                SetPixelPaletteIndex(col, row, paletteIndex);

                col++;
                if (col >= Width)
                {
                    col = 0;
                    row++;
                    if (row >= Height)
                        break;
                }
            }
        }

        public void SetPixelPaletteIndex(int col, int row, int paletteIndex)
        {
            Pixels[col, row] = paletteIndex;
        }

        public int GetPixelPaletteIndex(int col, int row)
        {
            return Pixels[col, row];
        }
    }
}
