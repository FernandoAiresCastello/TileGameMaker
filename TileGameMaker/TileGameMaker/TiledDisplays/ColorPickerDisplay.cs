﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TileGameLib.Components;
using TileGameLib.Graphics;
using TileGameMaker.Util;

namespace TileGameMaker.TiledDisplays
{
    public class ColorPickerDisplay : TiledDisplay
    {
        public int SelectedForeColor { set; get; }
        public int SelectedBackColor { set; get; }

        private readonly int SwatchTileIx = Config.ReadInt("ColorPickerSwatchTile");
        private readonly int SelectedForeColorSwatchTile = Config.ReadInt("ColorPickerSelectedForeColorSwatchTile");
        private readonly int SelectedBackColorSwatchTile = Config.ReadInt("ColorPickerSelectedBackColorSwatchTile");
        private readonly int SelectedBothColorsEqualSwatchTile = Config.ReadInt("ColorPickerSelectedBothColorsEqualSwatchTile");

        private int RearrangeColorSrc = 0;
        private int RearrangeColorDst = 0;

        public ColorPickerDisplay(Control parent, Palette palette, int cols, int rows, int zoom)
            : base(parent, cols, rows, zoom)
        {
            Graphics.Palette = palette;
            SelectedForeColor = Config.ReadInt("DefaultTileForeColor");
            SelectedBackColor = Config.ReadInt("DefaultTileBackColor");
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int x = 0;
            int y = 0;

            int black = PaletteIndex.Black;
            int white = PaletteIndex.White;

            for (int i = 0; i < Graphics.Palette.Size; i++)
            {
                if (i < Graphics.Palette.Size)
                {
                    int selectionIndicatorColor = Graphics.Palette.GetBrightness(i) > 0.5 ? black : white;

                    if (i == SelectedForeColor && i == SelectedBackColor)
                        Graphics.PutTile(x, y, SelectedBothColorsEqualSwatchTile, selectionIndicatorColor, i, false);
                    else if (i == SelectedForeColor)
                        Graphics.PutTile(x, y, SelectedForeColorSwatchTile, selectionIndicatorColor, i, false);
                    else if (i == SelectedBackColor)
                        Graphics.PutTile(x, y, SelectedBackColorSwatchTile, selectionIndicatorColor, i, false);
                    else
                        Graphics.PutTile(x, y, SwatchTileIx, i, i, false);

                    x++;

                    if (x >= Graphics.Cols)
                    {
                        x = 0;
                        y++;
                    }
                }
                else
                {
                    Graphics.PutTile(x, y, 0, PaletteIndex.White, PaletteIndex.White, false);
                }
            }

            base.OnPaint(e);
        }

        public int GetForeColorIndexAtMousePos(Point mousePos)
        {
            Point p = GetMouseToCellPos(mousePos);
            Tile tile = Graphics.GetTile(p.X, p.Y);
            return tile.ForeColor;
        }

        public int GetBackColorIndexAtMousePos(Point mousePos)
        {
            Point p = GetMouseToCellPos(mousePos);
            Tile tile = Graphics.GetTile(p.X, p.Y);
            return tile.BackColor;
        }

        public int GetColor(int index)
        {
            return Graphics.Palette.Colors[index];
        }

        public void SetColor(int index, int color)
        {
            Graphics.Palette.Colors[index] = color;
        }

        public void SetColor(int index, Color color)
        {
            Color opaqueColor = Color.FromArgb(255, color);
            SetColor(index, opaqueColor.ToArgb());
        }

        public Color GetForeColor()
        {
            return Graphics.Palette.GetColorObject(SelectedForeColor);
        }

        public Color GetBackColor()
        {
            return Graphics.Palette.GetColorObject(SelectedBackColor);
        }

        public void Clear()
        {
            Graphics.Palette.Clear();
            SelectedForeColor = Config.ReadInt("DefaultTileForeColor");
            SelectedBackColor = Config.ReadInt("DefaultTileBackColor");
            Refresh();
        }

        public void ResetToDefault()
        {
            Graphics.Palette.InitDefault();
            SelectedForeColor = Config.ReadInt("DefaultTileForeColor");
            SelectedBackColor = Config.ReadInt("DefaultTileBackColor");
            Refresh();
        }

        public void StartRearrange(int colorIx)
        {
            RearrangeColorSrc = colorIx;
            Refresh();
        }

        public void UpdateRearrange(int colorIx)
        {
            RearrangeColorDst = colorIx;
            Refresh();
        }

        public void EndRearrange(int colorIx)
        {
            RearrangeColorDst = colorIx;
            Graphics.Palette.Swap(RearrangeColorSrc, RearrangeColorDst);
            Refresh();
        }
    }
}
