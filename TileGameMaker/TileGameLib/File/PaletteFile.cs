﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TileGameLib.Exceptions;
using TileGameLib.Graphics;
using TileGameLib.Util;

namespace TileGameLib.File
{
    public static class PaletteFile
    {
        public static void Export(PaletteExportFormat format, Palette palette, string file)
        {
            switch (format)
            {
                case PaletteExportFormat.RawBytes: SaveAsRawBytes(palette, file); break;
                case PaletteExportFormat.HexadecimalRgb: SaveAsHexadecimalRgb(palette, file); break;
                case PaletteExportFormat.HexadecimalCsv: SaveAsHexadecimalCsv(palette, file); break;

                default: throw new TGLException("Invalid export format: " + format.ToString());
            }
        }

        public static Palette Import(PaletteExportFormat format, string file)
        {
            switch (format)
            {
                case PaletteExportFormat.RawBytes: return LoadFromRawBytes(file);
                case PaletteExportFormat.HexadecimalRgb: return LoadFromHexadecimalRgb(file);
                case PaletteExportFormat.HexadecimalCsv: return LoadFromHexadecimalCsv(file);

                default: throw new TGLException("Invalid export format: " + format.ToString());
            }
        }

        public static void SaveAsRawBytes(Palette palette, string path)
        {
            MemoryFile file = new MemoryFile();

            foreach (int argb in palette.Colors)
            {
                Color color = Color.FromArgb(argb);
                file.WriteByte(color.R);
                file.WriteByte(color.G);
                file.WriteByte(color.B);
            }

            file.SaveToPhysicalFile(path);
        }

        public static Palette LoadFromRawBytes(string path)
        {
            MemoryFile file = new MemoryFile(path);
            Palette palette = new Palette();

            int paletteSize = file.Length / 3;

            palette.Clear(paletteSize);

            for (int i = 0; i < palette.Size; i++)
            {
                int r = file.ReadByte();
                int g = file.ReadByte();
                int b = file.ReadByte();
                palette.Set(i, r, g, b);
            }

            return palette;
        }

        public static void SaveAsHexadecimalRgb(Palette palette, string path)
        {
            List<string> rgbStrings = new List<string>();

            for (int index = 0; index < palette.Size; index++)
            {
                Color color = palette.GetColorObject(index);
                string line = color.ToArgb().ToString("x").Substring(2);
                rgbStrings.Add(line);
            }

            string str = string.Join(Environment.NewLine, rgbStrings.ToArray());
            System.IO.File.WriteAllText(path, str);
        }

        public static Palette LoadFromHexadecimalRgb(string path)
        {
            string[] rgbStrings = System.IO.File.ReadAllLines(path);
            Palette palette = new Palette();
            palette.Clear(256, 0x000000);

            int i = 0;
            foreach (string rgb in rgbStrings)
                palette.Set(i++, int.Parse(rgb, NumberStyles.HexNumber));

            return palette;
        }

        public static void SaveAsHexadecimalCsv(Palette palette, string path)
        {
            MemoryFile file = new MemoryFile();

            for (int index = 0; index < palette.Size; index++)
            {
                Color color = palette.GetColorObject(index);

                string line = 
                    color.R.ToString("x").PadLeft(2, '0') + "," +
                    color.G.ToString("x").PadLeft(2, '0') + "," +
                    color.B.ToString("x").PadLeft(2, '0') + MemoryFile.NewLine;

                file.WriteString(line);
            }

            file.SaveToPhysicalFile(path);
        }

        public static Palette LoadFromHexadecimalCsv(string path)
        {
            throw new NotImplementedException();
        }
    }
}
