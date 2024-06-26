﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TileGameLib.Components;
using TileGameLib.File;
using TileGameLib.Graphics;
using TileGameLib.Util;
using TileGameMaker.MapEditorElements;
using TileGameMaker.Util;

namespace TileGameMaker.Windows
{
    public partial class MainWindow : Form
    {
        private MapEditor MapEditor;
        private DataExtractorWindow DataExtractor;
        private TemplateObjectWindow TemplateWindow;

        private static readonly int BestWidth = Config.ReadInt("MapEditorWindowBestWidth");
        private static readonly int BestHeight = Config.ReadInt("MapEditorWindowBestHeight");

        public MainWindow(MapEditor editor)
        {
            InitializeComponent();
            MapEditor = editor;

            Icon = Global.WindowIcon;
            Text = Global.ProgramTitle + " - " + MapEditor.Project.Path;
            KeyPreview = true;
            Shown += MainWindow_Shown;
            FormClosing += MainWindow_FormClosing;
            KeyDown += MainWindow_KeyDown;

            Rectangle screenArea = Screen.PrimaryScreen.Bounds;
            Size = new Size(BestWidth, BestHeight);
            MinimumSize = Size;

            if (screenArea.Width > BestWidth && screenArea.Height > BestHeight)
                WindowState = FormWindowState.Normal;
            else
                WindowState = FormWindowState.Maximized;

            AddControl(MapEditor.CommandLinePanel, CommandLinePanel);
            AddControl(MapEditor.MapEditorControl, MapEditorPanel);
            AddControl(MapEditor.TilePickerControl, TopLeftPanel);
            AddControl(MapEditor.ColorPickerControl, BottomLeftPanel);
            AddControl(MapEditor.GameObjectPanel, BottomRightPanel);
            AddControl(MapEditor.ProjectPanel, ProjectPanel);
            AddControl(MapEditor.MapPropertyGridControl, MapPropertiesPanel);
        }

        private void MainWindow_KeyDown(object sender, KeyEventArgs e)
        {
            MapEditor.MapEditorControl.HandleKeyEvent(sender, e);
        }

        private void MainWindow_Shown(object sender, EventArgs e)
        {
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason != CloseReason.ApplicationExitCall)
                ExitProgram(e);
        }

        private void AddControl(Control control, Control panel)
        {
            control.Parent = panel;
            control.Dock = DockStyle.Fill;
        }

        private void MiExit_Click(object sender, EventArgs e)
        {
            ExitProgram();
        }

        private void ExitProgram(FormClosingEventArgs e = null, bool promptToSave = true)
        {
            if (promptToSave)
            {
                bool confirmed = Alert.Confirm("Exit application?");

                if (!confirmed)
                {
                    if (e != null)
                        e.Cancel = true;

                    return;
                }
            }

            MapEditor.MapBookmarks.Save(MapBookmarks.Filename);
            Application.Exit();
        }

        private void BtnToggleCommandLine_Click(object sender, EventArgs e)
        {
            ToggleCommandLine();
        }

        public void ToggleCommandLine()
        {
            bool visible = MapAndCommandLineSplitContainer.Panel2Collapsed;
            MapAndCommandLineSplitContainer.Panel2Collapsed = !visible;

            if (visible)
                MapEditor.CommandLinePanel.Focus();
        }

        public void ShowCommandLine(bool show)
        {
            MapAndCommandLineSplitContainer.Panel2Collapsed = !show;
        }

        private void BtnDataExtractor_Click(object sender, EventArgs e)
        {
            ShowDataExtractor();
        }

        private void ShowDataExtractor()
        {
            if (DataExtractor == null)
            {
                DataExtractor = new DataExtractorWindow(MapEditor);
                DataExtractor.ShowDialog(this);
            }
            else
            {
                if (DataExtractor.Visible)
                {
                    DataExtractor.BringToFront();
                    if (DataExtractor.WindowState == FormWindowState.Minimized)
                        DataExtractor.WindowState = FormWindowState.Normal;
                }
                else
                {
                    if (DataExtractor.IsDisposed)
                        DataExtractor = new DataExtractorWindow(MapEditor);

                    DataExtractor.ShowDialog(this);
                }
            }
        }

        private void BtnSaveProject_Click(object sender, EventArgs e)
        {
            SaveProject();
        }

        private void BtnCloseProject_Click(object sender, EventArgs e)
        {
            bool confirmed = Alert.Confirm("Close project?");
            if (!confirmed)
                return;

            if (MapEditor.StartWindow != null)
            {
                MapEditor.StartWindow.Show();
                Hide();
            }
            else
            {
                ExitProgram(null, false);
            }
        }

        private void SaveProject(bool showSuccessMessage = true)
        {
            try
            {
                MapEditor.Project.Save();
                if (showSuccessMessage)
                    Alert.Info("Project saved successfully!");
            }
            catch (Exception ex)
            {
                Alert.Error("There was an error while saving the project:\n\n" + ex.StackTrace);
            }
        }

        private void BtnTemplateObjects_Click(object sender, EventArgs e)
        {
            if (TemplateWindow == null || TemplateWindow.IsDisposed)
                TemplateWindow = new TemplateObjectWindow(this, MapEditor);
            else if (TemplateWindow.WindowState == FormWindowState.Minimized)
                TemplateWindow.WindowState = FormWindowState.Normal;

            if (TemplateWindow.Visible)
                TemplateWindow.Activate();
            else
                TemplateWindow.Show(this);
        }

        private void BtnCommandLine_Click(object sender, EventArgs e)
        {
            ToggleCommandLine();
        }

        private void BtnSaveAndExportProject_Click(object sender, EventArgs e)
        {
            SaveProject(false);

            string projFile = Path.GetFileName(MapEditor.Project.Path);
            string chrFile = MapEditor.Project.Name + ".chr.dat";
            string palFile = MapEditor.Project.Name + ".pal.dat";
            string folder = MapEditor.Project.Folder;

            TilesetFile.Export(TilesetExportFormat.RawBytes, MapEditor.Tileset, Path.Combine(folder, chrFile));
            PaletteFile.Export(PaletteExportFormat.RawBytes, MapEditor.Palette, Path.Combine(folder, palFile));

            Alert.Info(
                $"Project saved to: {projFile}\n" +
                $"Charset exported to: {chrFile}\n" +
                $"Palette exported to: {palFile}");
        }
    }
}
