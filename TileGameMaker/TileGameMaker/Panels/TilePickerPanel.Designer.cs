﻿namespace TileGameMaker.Panels
{
    partial class TilePickerPanel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.ToolStrip = new System.Windows.Forms.ToolStrip();
			this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
			this.importFromFileAs = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnImportRawBytes = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnImportBinaryStrings = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
			this.exportToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnExportRawBytes = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnExportBinaryStrings = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnExportHex = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnExportToImage = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnCode = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.BtnCopy = new System.Windows.Forms.ToolStripButton();
			this.BtnPaste = new System.Windows.Forms.ToolStripButton();
			this.BtnRearrange = new System.Windows.Forms.ToolStripButton();
			this.BtnMoreActions = new System.Windows.Forms.ToolStripDropDownButton();
			this.BtnAdd8Tiles = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnUse16x16TileEditor = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnPopOutWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.clearTilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnClearAll = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnClearRange = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnRestoreDefault = new System.Windows.Forms.ToolStripMenuItem();
			this.BtnTruncate = new System.Windows.Forms.ToolStripMenuItem();
			this.PnlTilePicker = new System.Windows.Forms.Panel();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.StatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.HoverLabel = new System.Windows.Forms.ToolStripStatusLabel();
			this.BtnImportImage = new System.Windows.Forms.ToolStripMenuItem();
			this.tableLayoutPanel1.SuspendLayout();
			this.ToolStrip.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.ToolStrip, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.PnlTilePicker, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.statusStrip1, 0, 2);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel1.Size = new System.Drawing.Size(209, 380);
			this.tableLayoutPanel1.TabIndex = 5;
			// 
			// ToolStrip
			// 
			this.ToolStrip.CanOverflow = false;
			this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton2,
            this.toolStripDropDownButton1,
            this.BtnCode,
            this.toolStripSeparator1,
            this.BtnCopy,
            this.BtnPaste,
            this.BtnRearrange,
            this.BtnMoreActions});
			this.ToolStrip.Location = new System.Drawing.Point(0, 0);
			this.ToolStrip.Name = "ToolStrip";
			this.ToolStrip.Padding = new System.Windows.Forms.Padding(8, 5, 1, 2);
			this.ToolStrip.Size = new System.Drawing.Size(209, 30);
			this.ToolStrip.TabIndex = 2;
			this.ToolStrip.Text = "toolStrip1";
			// 
			// toolStripDropDownButton2
			// 
			this.toolStripDropDownButton2.AutoToolTip = false;
			this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importFromFileAs,
            this.toolStripSeparator3,
            this.BtnImportRawBytes,
            this.BtnImportBinaryStrings,
            this.BtnImportImage});
			this.toolStripDropDownButton2.Image = global::TileGameMaker.Properties.Resources.folder;
			this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
			this.toolStripDropDownButton2.Size = new System.Drawing.Size(29, 20);
			this.toolStripDropDownButton2.Text = "toolStripDropDownButton2";
			// 
			// importFromFileAs
			// 
			this.importFromFileAs.Enabled = false;
			this.importFromFileAs.Name = "importFromFileAs";
			this.importFromFileAs.Size = new System.Drawing.Size(180, 22);
			this.importFromFileAs.Text = "Import from file as:";
			this.importFromFileAs.Click += new System.EventHandler(this.BtnImportRawBytes_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
			// 
			// BtnImportRawBytes
			// 
			this.BtnImportRawBytes.Name = "BtnImportRawBytes";
			this.BtnImportRawBytes.Size = new System.Drawing.Size(180, 22);
			this.BtnImportRawBytes.Text = "Bytes";
			this.BtnImportRawBytes.Click += new System.EventHandler(this.BtnImportRawBytes_Click);
			// 
			// BtnImportBinaryStrings
			// 
			this.BtnImportBinaryStrings.Name = "BtnImportBinaryStrings";
			this.BtnImportBinaryStrings.Size = new System.Drawing.Size(180, 22);
			this.BtnImportBinaryStrings.Text = "Binary Strings";
			this.BtnImportBinaryStrings.Click += new System.EventHandler(this.BtnImportBinaryStrings_Click_1);
			// 
			// toolStripDropDownButton1
			// 
			this.toolStripDropDownButton1.AutoToolTip = false;
			this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToFileToolStripMenuItem,
            this.toolStripSeparator2,
            this.BtnExportRawBytes,
            this.BtnExportBinaryStrings,
            this.BtnExportHex,
            this.BtnExportToImage});
			this.toolStripDropDownButton1.Image = global::TileGameMaker.Properties.Resources.diskette;
			this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
			this.toolStripDropDownButton1.Size = new System.Drawing.Size(29, 20);
			this.toolStripDropDownButton1.Text = "Export tileset";
			// 
			// exportToFileToolStripMenuItem
			// 
			this.exportToFileToolStripMenuItem.Enabled = false;
			this.exportToFileToolStripMenuItem.Name = "exportToFileToolStripMenuItem";
			this.exportToFileToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exportToFileToolStripMenuItem.Text = "Export to file as:";
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(177, 6);
			// 
			// BtnExportRawBytes
			// 
			this.BtnExportRawBytes.Name = "BtnExportRawBytes";
			this.BtnExportRawBytes.Size = new System.Drawing.Size(180, 22);
			this.BtnExportRawBytes.Text = "Bytes";
			this.BtnExportRawBytes.Click += new System.EventHandler(this.BtnExportRawBytes_Click);
			// 
			// BtnExportBinaryStrings
			// 
			this.BtnExportBinaryStrings.Name = "BtnExportBinaryStrings";
			this.BtnExportBinaryStrings.Size = new System.Drawing.Size(180, 22);
			this.BtnExportBinaryStrings.Text = "Binary strings";
			this.BtnExportBinaryStrings.Click += new System.EventHandler(this.BtnExportBinaryStrings_Click);
			// 
			// BtnExportHex
			// 
			this.BtnExportHex.Name = "BtnExportHex";
			this.BtnExportHex.Size = new System.Drawing.Size(180, 22);
			this.BtnExportHex.Text = "Hexadecimal CSV";
			this.BtnExportHex.Click += new System.EventHandler(this.BtnExportHex_Click);
			// 
			// BtnExportToImage
			// 
			this.BtnExportToImage.Name = "BtnExportToImage";
			this.BtnExportToImage.Size = new System.Drawing.Size(180, 22);
			this.BtnExportToImage.Text = "Image";
			this.BtnExportToImage.Click += new System.EventHandler(this.BtnExportToImage_Click);
			// 
			// BtnCode
			// 
			this.BtnCode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnCode.Image = global::TileGameMaker.Properties.Resources.script_code;
			this.BtnCode.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnCode.Name = "BtnCode";
			this.BtnCode.Size = new System.Drawing.Size(23, 20);
			this.BtnCode.Text = "toolStripButton1";
			this.BtnCode.ToolTipText = "View / edit as code";
			this.BtnCode.Click += new System.EventHandler(this.BtnCode_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 23);
			// 
			// BtnCopy
			// 
			this.BtnCopy.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnCopy.Image = global::TileGameMaker.Properties.Resources.page_white_copy;
			this.BtnCopy.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnCopy.Name = "BtnCopy";
			this.BtnCopy.Size = new System.Drawing.Size(23, 20);
			this.BtnCopy.Text = "toolStripButton1";
			this.BtnCopy.ToolTipText = "Copy selected tile";
			this.BtnCopy.Click += new System.EventHandler(this.BtnCopy_Click);
			// 
			// BtnPaste
			// 
			this.BtnPaste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnPaste.Image = global::TileGameMaker.Properties.Resources.page_white_paste;
			this.BtnPaste.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnPaste.Name = "BtnPaste";
			this.BtnPaste.Size = new System.Drawing.Size(23, 20);
			this.BtnPaste.Text = "toolStripButton1";
			this.BtnPaste.ToolTipText = "Paste tile";
			this.BtnPaste.Click += new System.EventHandler(this.BtnPaste_Click);
			// 
			// BtnRearrange
			// 
			this.BtnRearrange.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
			this.BtnRearrange.Image = global::TileGameMaker.Properties.Resources.layer_stack_arrange;
			this.BtnRearrange.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnRearrange.Name = "BtnRearrange";
			this.BtnRearrange.Size = new System.Drawing.Size(23, 20);
			this.BtnRearrange.Text = "Rearrange tiles";
			this.BtnRearrange.Click += new System.EventHandler(this.BtnRearrange_Click);
			// 
			// BtnMoreActions
			// 
			this.BtnMoreActions.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnAdd8Tiles,
            this.BtnUse16x16TileEditor,
            this.BtnPopOutWindow,
            this.clearTilesToolStripMenuItem,
            this.BtnRestoreDefault,
            this.BtnTruncate});
			this.BtnMoreActions.Image = global::TileGameMaker.Properties.Resources.menu;
			this.BtnMoreActions.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.BtnMoreActions.Name = "BtnMoreActions";
			this.BtnMoreActions.Size = new System.Drawing.Size(29, 20);
			// 
			// BtnAdd8Tiles
			// 
			this.BtnAdd8Tiles.Image = global::TileGameMaker.Properties.Resources.add;
			this.BtnAdd8Tiles.Name = "BtnAdd8Tiles";
			this.BtnAdd8Tiles.Size = new System.Drawing.Size(167, 22);
			this.BtnAdd8Tiles.Text = "Add 8 tiles";
			this.BtnAdd8Tiles.Click += new System.EventHandler(this.BtnAdd8Tiles_Click);
			// 
			// BtnUse16x16TileEditor
			// 
			this.BtnUse16x16TileEditor.CheckOnClick = true;
			this.BtnUse16x16TileEditor.Image = global::TileGameMaker.Properties.Resources.layouts_four_grid;
			this.BtnUse16x16TileEditor.Name = "BtnUse16x16TileEditor";
			this.BtnUse16x16TileEditor.Size = new System.Drawing.Size(167, 22);
			this.BtnUse16x16TileEditor.Text = "Use 16x16 editor";
			// 
			// BtnPopOutWindow
			// 
			this.BtnPopOutWindow.Image = global::TileGameMaker.Properties.Resources.color_picker_default;
			this.BtnPopOutWindow.Name = "BtnPopOutWindow";
			this.BtnPopOutWindow.Size = new System.Drawing.Size(167, 22);
			this.BtnPopOutWindow.Text = "Pop-out window";
			this.BtnPopOutWindow.Click += new System.EventHandler(this.BtnPopOutWindow_Click);
			// 
			// clearTilesToolStripMenuItem
			// 
			this.clearTilesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BtnClearAll,
            this.BtnClearRange});
			this.clearTilesToolStripMenuItem.Image = global::TileGameMaker.Properties.Resources.broom;
			this.clearTilesToolStripMenuItem.Name = "clearTilesToolStripMenuItem";
			this.clearTilesToolStripMenuItem.Size = new System.Drawing.Size(167, 22);
			this.clearTilesToolStripMenuItem.Text = "Clear tiles";
			// 
			// BtnClearAll
			// 
			this.BtnClearAll.Name = "BtnClearAll";
			this.BtnClearAll.Size = new System.Drawing.Size(147, 22);
			this.BtnClearAll.Text = "All";
			this.BtnClearAll.Click += new System.EventHandler(this.BtnClearAll_Click);
			// 
			// BtnClearRange
			// 
			this.BtnClearRange.Name = "BtnClearRange";
			this.BtnClearRange.Size = new System.Drawing.Size(147, 22);
			this.BtnClearRange.Text = "Select range...";
			this.BtnClearRange.Click += new System.EventHandler(this.BtnClearRange_Click);
			// 
			// BtnRestoreDefault
			// 
			this.BtnRestoreDefault.Image = global::TileGameMaker.Properties.Resources.site_backup_and_restore;
			this.BtnRestoreDefault.Name = "BtnRestoreDefault";
			this.BtnRestoreDefault.Size = new System.Drawing.Size(167, 22);
			this.BtnRestoreDefault.Text = "Restore to default";
			// 
			// BtnTruncate
			// 
			this.BtnTruncate.Name = "BtnTruncate";
			this.BtnTruncate.Size = new System.Drawing.Size(167, 22);
			this.BtnTruncate.Text = "Truncate to size";
			this.BtnTruncate.Click += new System.EventHandler(this.BtnTruncate_Click);
			// 
			// PnlTilePicker
			// 
			this.PnlTilePicker.AutoScroll = true;
			this.PnlTilePicker.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.PnlTilePicker.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.PnlTilePicker.Dock = System.Windows.Forms.DockStyle.Fill;
			this.PnlTilePicker.Location = new System.Drawing.Point(3, 33);
			this.PnlTilePicker.Name = "PnlTilePicker";
			this.PnlTilePicker.Size = new System.Drawing.Size(203, 320);
			this.PnlTilePicker.TabIndex = 1;
			this.PnlTilePicker.MouseLeave += new System.EventHandler(this.TilePicker_MouseLeave);
			// 
			// statusStrip1
			// 
			this.statusStrip1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatusLabel,
            this.HoverLabel});
			this.statusStrip1.Location = new System.Drawing.Point(0, 356);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(209, 24);
			this.statusStrip1.SizingGrip = false;
			this.statusStrip1.TabIndex = 3;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// StatusLabel
			// 
			this.StatusLabel.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
			this.StatusLabel.Name = "StatusLabel";
			this.StatusLabel.Size = new System.Drawing.Size(71, 19);
			this.StatusLabel.Text = "StatusLabel";
			// 
			// HoverLabel
			// 
			this.HoverLabel.Name = "HoverLabel";
			this.HoverLabel.Size = new System.Drawing.Size(67, 19);
			this.HoverLabel.Text = "HoverLabel";
			// 
			// BtnImportImage
			// 
			this.BtnImportImage.Name = "BtnImportImage";
			this.BtnImportImage.Size = new System.Drawing.Size(180, 22);
			this.BtnImportImage.Text = "Image";
			this.BtnImportImage.Click += new System.EventHandler(this.BtnImportImage_Click);
			// 
			// TilePickerPanel
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "TilePickerPanel";
			this.Size = new System.Drawing.Size(209, 380);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ToolStrip.ResumeLayout(false);
			this.ToolStrip.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStrip ToolStrip;
        private System.Windows.Forms.Panel PnlTilePicker;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel StatusLabel;
        private System.Windows.Forms.ToolStripStatusLabel HoverLabel;
        private System.Windows.Forms.ToolStripButton BtnCopy;
        private System.Windows.Forms.ToolStripButton BtnPaste;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem BtnExportRawBytes;
        private System.Windows.Forms.ToolStripMenuItem BtnExportBinaryStrings;
        private System.Windows.Forms.ToolStripMenuItem BtnExportHex;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem importFromFileAs;
        private System.Windows.Forms.ToolStripMenuItem BtnExportToImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripDropDownButton BtnMoreActions;
        private System.Windows.Forms.ToolStripButton BtnRearrange;
        private System.Windows.Forms.ToolStripMenuItem BtnAdd8Tiles;
        private System.Windows.Forms.ToolStripMenuItem BtnUse16x16TileEditor;
        private System.Windows.Forms.ToolStripMenuItem clearTilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BtnClearAll;
        private System.Windows.Forms.ToolStripMenuItem BtnClearRange;
        private System.Windows.Forms.ToolStripMenuItem BtnPopOutWindow;
        private System.Windows.Forms.ToolStripMenuItem exportToFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem BtnImportRawBytes;
        private System.Windows.Forms.ToolStripMenuItem BtnRestoreDefault;
        private System.Windows.Forms.ToolStripButton BtnCode;
        private System.Windows.Forms.ToolStripMenuItem BtnTruncate;
        private System.Windows.Forms.ToolStripMenuItem BtnImportBinaryStrings;
		private System.Windows.Forms.ToolStripMenuItem BtnImportImage;
	}
}
