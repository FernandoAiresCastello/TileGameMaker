﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TileGameMaker.MapEditorElements;
using TileGameMaker.Windows;
using TileGameMaker.TiledDisplays;
using TileGameLib.Util;
using TileGameMaker.Util;
using TileGameLib.File;
using TileGameLib.Graphics;

namespace TileGameMaker.Panels
{
    public partial class ColorPickerPanel : UserControl
    {
        public int SelectedForeColor => ColorPicker.SelectedForeColor;
        public int SelectedBackColor => ColorPicker.SelectedBackColor;
        private bool RearrangeMode => BtnRearrange.Checked;

        private MapEditor MapEditor;
        private ColorPickerDisplay ColorPicker;
        private ColorEditorWindow ColorEditorWindow;

        public ColorPickerPanel()
        {
            InitializeComponent();
        }

        public ColorPickerPanel(MapEditor editor)
        {
            InitializeComponent();
            MapEditor = editor;

            ColorPicker = new ColorPickerDisplay(PnlColorPicker,
                editor.Palette,
                Config.ReadInt("ColorPickerCols"), 
                Config.ReadInt("ColorPickerRows"), 
                Config.ReadInt("ColorPickerZoom"));

            int colorsPerRow = Config.ReadInt("ColorPickerColorsPerRow");
            ColorPicker.ResizeGraphicsByTileCount(ColorPicker.Graphics.Palette.Size, colorsPerRow);
            //TxtColorsPerRow.Text = colorsPerRow.ToString();

            ColorPicker.Graphics.Palette = editor.Palette;
            ColorPicker.ShowGrid = true;
            ColorPicker.MouseMove += ColorPicker_MouseMove;
            ColorPicker.MouseLeave += ColorPicker_MouseLeave;
            ColorPicker.MouseDown += ColorPicker_MouseDown;
            ColorPicker.MouseUp += ColorPicker_MouseUp;
            ColorPicker.MouseClick += ColorPicker_MouseClick;
            ColorPicker.MouseDoubleClick += ColorPicker_MouseDoubleClick;

            ForeColorPanel.MouseDown += ColorPanel_Click;
            BackColorPanel.MouseDown += ColorPanel_Click;

            ColorEditorWindow = new ColorEditorWindow(ColorPicker.Graphics.Palette);
            ColorEditorWindow.Subscribe(this);
            ColorEditorWindow.Subscribe(ColorPicker);
            ColorEditorWindow.Subscribe(editor.MapEditorControl);
            //ColorEditorWindow.Subscribe(editor.TemplateControl);

            UpdateDefaultPaletteMenu();
            UpdatePanelColors();
            UpdateStatus();
            SetHoverStatus("");
        }

        private void UpdateDefaultPaletteMenu()
        {
            int defaultPaletteEnumValue = 0;

            foreach (string defaultTileset in Palette.GetDefaultPaletteNames())
            {
                ToolStripMenuItem item = new ToolStripMenuItem(defaultTileset);
                item.Click += DefaultPaletteItem_Click;
                item.Tag = defaultPaletteEnumValue;
                BtnRestoreDefault.DropDownItems.Add(item);
                defaultPaletteEnumValue++;
            }
        }

        private void DefaultPaletteItem_Click(object sender, EventArgs e)
        {
            ColorPicker.SelectedForeColor = Config.ReadInt("DefaultTileForeColor");
            ColorPicker.SelectedBackColor = Config.ReadInt("DefaultTileBackColor");

            ToolStripMenuItem item = (ToolStripMenuItem)sender;
            int defaultPaletteEnumValue = (int)item.Tag;
            ColorPicker.Graphics.Palette.InitDefault((Palette.Default)defaultPaletteEnumValue);
            UpdateStatus();
            Refresh();
        }

        public void SetForeColorIndex(int index)
        {
            ColorPicker.SelectedForeColor = index;
            Refresh();
            UpdatePanelColors();
            UpdateStatus();
        }

        public void SetBackColorIndex(int index)
        {
            ColorPicker.SelectedBackColor = index;
            Refresh();
            UpdatePanelColors();
            UpdateStatus();
        }

        private void ColorPicker_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int colorIx = ColorPicker.GetBackColorIndexAtMousePos(e.Location);
            if (colorIx < 0 || colorIx >= ColorPicker.Graphics.Palette.Size)
                return;

            ColorEditorWindow.SetColor(colorIx);
            ColorEditorWindow.Location = new Point(Location.X, Location.Y + 50);
            ColorEditorWindow.ShowDialog(this);
        }

        private void ColorPicker_MouseClick(object sender, MouseEventArgs e)
        {
            if (RearrangeMode)
                return;

            int colorIx = ColorPicker.GetBackColorIndexAtMousePos(e.Location);
            if (colorIx < 0 || colorIx >= ColorPicker.Graphics.Palette.Size)
                return;

            if (e.Button == MouseButtons.Left)
            {
                ColorPicker.SelectedForeColor = colorIx;
                MapEditor.SetClipboardForeColor(colorIx);
            }
            else if (e.Button == MouseButtons.Right)
            {
                ColorPicker.SelectedBackColor = colorIx;
                MapEditor.SetClipboardBackColor(colorIx);
            }

            Refresh();
            UpdatePanelColors();
            UpdateStatus();
        }

        private void ColorPicker_MouseDown(object sender, MouseEventArgs e)
        {
            int colorIx = ColorPicker.GetBackColorIndexAtMousePos(e.Location);
            if (colorIx < 0 || colorIx >= ColorPicker.Graphics.Palette.Size)
                return;

            if (RearrangeMode)
            {
                if (e.Button == MouseButtons.Left)
                    ColorPicker.StartRearrange(colorIx);
            }
            else
            {
                ColorPicker_MouseClick(sender, e);
            }
        }

        private void ColorPicker_MouseMove(object sender, MouseEventArgs e)
        {
            int colorIx = ColorPicker.GetBackColorIndexAtMousePos(e.Location);
            if (colorIx >= 0 && colorIx < ColorPicker.Graphics.Palette.Size)
            {
                if (RearrangeMode)
                {
                    ColorPicker.UpdateRearrange(colorIx);
                }

                int color = ColorPicker.GetColor(colorIx);
                string rgb = color.ToString("X6").Substring(2);
                SetHoverStatus("H: " + colorIx + " RGB 0x" + rgb);
            }
            else
            {
                SetHoverStatus("");
            }
        }

        private void ColorPicker_MouseUp(object sender, MouseEventArgs e)
        {
            int colorIx = ColorPicker.GetBackColorIndexAtMousePos(e.Location);
            if (colorIx < 0 || colorIx >= ColorPicker.Graphics.Palette.Size)
                return;

            if (e.Button == MouseButtons.Left)
            {
                if (RearrangeMode)
                {
                    ColorPicker.EndRearrange(colorIx);
                }
            }
        }

        private void ColorPicker_MouseLeave(object sender, EventArgs e)
        {
            SetHoverStatus("");
        }

        public override void Refresh()
        {
            base.Refresh();
            UpdatePanelColors();
        }

        private void UpdateStatus()
        {
            LblStatus.Text = 
                "SIZE: " + ColorPicker.Graphics.Palette.Size + " | " +
                "F: " + ColorPicker.SelectedForeColor + " " +
                "B: " + ColorPicker.SelectedBackColor;
        }

        private void SetHoverStatus(string status)
        {
            LblHover.Text = status;
        }

        private void ColorPanel_Click(object sender, EventArgs e)
        {
            SwapColors();
        }

        private void UpdatePanelColors()
        {
            ForeColorPanel.BackColor = ColorPicker.GetForeColor();
            BackColorPanel.BackColor = ColorPicker.GetBackColor();
        }

        private void SwapColors()
        {
            int temp = ColorPicker.SelectedForeColor;
            ColorPicker.SelectedForeColor = ColorPicker.SelectedBackColor;
            ColorPicker.SelectedBackColor = temp;
            MapEditor.SetClipboardForeColor(ColorPicker.SelectedForeColor);
            MapEditor.SetClipboardBackColor(ColorPicker.SelectedBackColor);
            UpdatePanelColors();
            UpdateStatus();
            Refresh();
        }

        private void BtnNew_Click(object sender, EventArgs e)
        {
            if (Alert.Confirm("Clear palette?"))
            {
                ColorPicker.Clear();
                UpdatePanelColors();
                UpdateStatus();
                Refresh();
            }
        }

        private void BtnExportRawBytes_Click(object sender, EventArgs e)
        {
            Export(PaletteExportFormat.RawBytes);
        }

        private void BtnExportHexRgb_Click(object sender, EventArgs e)
        {
            Export(PaletteExportFormat.HexadecimalRgb);
        }

        private void BtnExportHexCsv_Click(object sender, EventArgs e)
        {
            Export(PaletteExportFormat.HexadecimalCsv);
        }

        private void Export(PaletteExportFormat format)
        {
            SaveFileDialog dialog = new SaveFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                PaletteFile.Export(format, ColorPicker.Graphics.Palette, dialog.FileName);
                Alert.Info("Palette exported successfully!");
            }
        }

        private void BtnImportRawBytes_Click(object sender, EventArgs e)
        {
            Import(PaletteExportFormat.RawBytes);
        }

        private void BtnImportHexRgb_Click(object sender, EventArgs e)
        {
            Import(PaletteExportFormat.HexadecimalRgb);
        }

        private void Import(PaletteExportFormat format)
        {
            OpenFileDialog dialog = new OpenFileDialog();

            if (dialog.ShowDialog() == DialogResult.OK)
            {
                ColorPicker.Graphics.Palette.SetEqual(PaletteFile.Import(format, dialog.FileName));
                ColorPicker.Refresh();
                UpdatePanelColors();
                UpdateStatus();

                Alert.Info("Palette imported successfully!");
            }
        }

        private void BtnRearrange_Click(object sender, EventArgs e)
        {
            BtnRearrange.Checked = !BtnRearrange.Checked;
        }
    }
}
