namespace TileGameMaker.StandaloneTools
{
	partial class ColorPaletteEditorWindow
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			PalettePanel = new Panel();
			menuStrip1 = new MenuStrip();
			fileToolStripMenuItem = new ToolStripMenuItem();
			BtnLoad = new ToolStripMenuItem();
			BtnSave = new ToolStripMenuItem();
			viewToolStripMenuItem = new ToolStripMenuItem();
			BtnGrid = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// PalettePanel
			// 
			PalettePanel.BorderStyle = BorderStyle.Fixed3D;
			PalettePanel.Location = new Point(12, 36);
			PalettePanel.MaximumSize = new Size(388, 388);
			PalettePanel.MinimumSize = new Size(388, 388);
			PalettePanel.Name = "PalettePanel";
			PalettePanel.Size = new Size(388, 388);
			PalettePanel.TabIndex = 0;
			// 
			// menuStrip1
			// 
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(621, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BtnLoad, BtnSave });
			fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			fileToolStripMenuItem.Size = new Size(37, 20);
			fileToolStripMenuItem.Text = "File";
			// 
			// BtnLoad
			// 
			BtnLoad.Name = "BtnLoad";
			BtnLoad.ShortcutKeys = Keys.Control | Keys.O;
			BtnLoad.Size = new Size(180, 22);
			BtnLoad.Text = "Load";
			BtnLoad.Click += BtnLoad_Click;
			// 
			// BtnSave
			// 
			BtnSave.Name = "BtnSave";
			BtnSave.ShortcutKeys = Keys.Control | Keys.S;
			BtnSave.Size = new Size(180, 22);
			BtnSave.Text = "Save";
			// 
			// viewToolStripMenuItem
			// 
			viewToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BtnGrid });
			viewToolStripMenuItem.Name = "viewToolStripMenuItem";
			viewToolStripMenuItem.Size = new Size(44, 20);
			viewToolStripMenuItem.Text = "View";
			// 
			// BtnGrid
			// 
			BtnGrid.Checked = true;
			BtnGrid.CheckOnClick = true;
			BtnGrid.CheckState = CheckState.Checked;
			BtnGrid.Name = "BtnGrid";
			BtnGrid.ShortcutKeys = Keys.Control | Keys.G;
			BtnGrid.Size = new Size(180, 22);
			BtnGrid.Text = "Grid";
			BtnGrid.Click += BtnGrid_Click;
			// 
			// ColorPaletteEditorWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(621, 435);
			Controls.Add(PalettePanel);
			Controls.Add(menuStrip1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MainMenuStrip = menuStrip1;
			MaximizeBox = false;
			Name = "ColorPaletteEditorWindow";
			Text = "Color Palette Editor";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel PalettePanel;
		private MenuStrip menuStrip1;
		private ToolStripMenuItem fileToolStripMenuItem;
		private ToolStripMenuItem BtnLoad;
		private ToolStripMenuItem BtnSave;
		private ToolStripMenuItem viewToolStripMenuItem;
		private ToolStripMenuItem BtnGrid;
	}
}