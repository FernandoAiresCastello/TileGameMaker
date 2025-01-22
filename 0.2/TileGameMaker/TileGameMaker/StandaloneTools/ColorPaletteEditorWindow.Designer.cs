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
			editToolStripMenuItem = new ToolStripMenuItem();
			BtnCopy = new ToolStripMenuItem();
			BtnCut = new ToolStripMenuItem();
			BtnPaste = new ToolStripMenuItem();
			BtnSetBlank = new ToolStripMenuItem();
			TxtRgb = new TextBox();
			label1 = new Label();
			label2 = new Label();
			TxtIndex = new TextBox();
			statusStrip1 = new StatusStrip();
			LbInfo = new ToolStripStatusLabel();
			BtnNew = new ToolStripMenuItem();
			menuStrip1.SuspendLayout();
			statusStrip1.SuspendLayout();
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
			menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, viewToolStripMenuItem, editToolStripMenuItem });
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(561, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// fileToolStripMenuItem
			// 
			fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BtnNew, BtnLoad, BtnSave });
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
			BtnSave.Click += BtnSave_Click;
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
			BtnGrid.Size = new Size(138, 22);
			BtnGrid.Text = "Grid";
			BtnGrid.Click += BtnGrid_Click;
			// 
			// editToolStripMenuItem
			// 
			editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { BtnCopy, BtnCut, BtnPaste, BtnSetBlank });
			editToolStripMenuItem.Name = "editToolStripMenuItem";
			editToolStripMenuItem.Size = new Size(39, 20);
			editToolStripMenuItem.Text = "Edit";
			// 
			// BtnCopy
			// 
			BtnCopy.Name = "BtnCopy";
			BtnCopy.ShortcutKeys = Keys.Control | Keys.C;
			BtnCopy.Size = new Size(144, 22);
			BtnCopy.Text = "Copy";
			BtnCopy.Click += BtnCopy_Click;
			// 
			// BtnCut
			// 
			BtnCut.Name = "BtnCut";
			BtnCut.ShortcutKeys = Keys.Control | Keys.X;
			BtnCut.Size = new Size(144, 22);
			BtnCut.Text = "Cut";
			BtnCut.Click += BtnCut_Click;
			// 
			// BtnPaste
			// 
			BtnPaste.Name = "BtnPaste";
			BtnPaste.ShortcutKeys = Keys.Control | Keys.V;
			BtnPaste.Size = new Size(144, 22);
			BtnPaste.Text = "Paste";
			BtnPaste.Click += BtnPaste_Click;
			// 
			// BtnSetBlank
			// 
			BtnSetBlank.Name = "BtnSetBlank";
			BtnSetBlank.ShortcutKeys = Keys.Delete;
			BtnSetBlank.Size = new Size(144, 22);
			BtnSetBlank.Text = "Delete";
			BtnSetBlank.Click += BtnSetBlank_Click;
			// 
			// TxtRgb
			// 
			TxtRgb.CharacterCasing = CharacterCasing.Upper;
			TxtRgb.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			TxtRgb.Location = new Point(467, 54);
			TxtRgb.MaxLength = 6;
			TxtRgb.Name = "TxtRgb";
			TxtRgb.Size = new Size(83, 25);
			TxtRgb.TabIndex = 2;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(464, 34);
			label1.Name = "label1";
			label1.Size = new Size(29, 15);
			label1.TabIndex = 3;
			label1.Text = "RGB";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(412, 34);
			label2.Name = "label2";
			label2.Size = new Size(36, 15);
			label2.TabIndex = 5;
			label2.Text = "Index";
			// 
			// TxtIndex
			// 
			TxtIndex.CharacterCasing = CharacterCasing.Upper;
			TxtIndex.Font = new Font("Consolas", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
			TxtIndex.Location = new Point(415, 54);
			TxtIndex.MaxLength = 6;
			TxtIndex.Name = "TxtIndex";
			TxtIndex.ReadOnly = true;
			TxtIndex.Size = new Size(46, 25);
			TxtIndex.TabIndex = 4;
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { LbInfo });
			statusStrip1.Location = new Point(0, 435);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(561, 22);
			statusStrip1.SizingGrip = false;
			statusStrip1.TabIndex = 6;
			statusStrip1.Text = "statusStrip1";
			// 
			// LbInfo
			// 
			LbInfo.ForeColor = Color.DimGray;
			LbInfo.Name = "LbInfo";
			LbInfo.Size = new Size(28, 17);
			LbInfo.Text = "Info";
			// 
			// BtnNew
			// 
			BtnNew.Name = "BtnNew";
			BtnNew.ShortcutKeys = Keys.Control | Keys.N;
			BtnNew.Size = new Size(180, 22);
			BtnNew.Text = "New";
			BtnNew.Click += BtnNew_Click;
			// 
			// ColorPaletteEditorWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(561, 457);
			Controls.Add(statusStrip1);
			Controls.Add(label2);
			Controls.Add(TxtIndex);
			Controls.Add(label1);
			Controls.Add(TxtRgb);
			Controls.Add(PalettePanel);
			Controls.Add(menuStrip1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MainMenuStrip = menuStrip1;
			MaximizeBox = false;
			Name = "ColorPaletteEditorWindow";
			Text = "Color Palette";
			menuStrip1.ResumeLayout(false);
			menuStrip1.PerformLayout();
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
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
		private TextBox TxtRgb;
		private Label label1;
		private Label label2;
		private TextBox TxtIndex;
		private ToolStripMenuItem editToolStripMenuItem;
		private ToolStripMenuItem BtnCopy;
		private ToolStripMenuItem BtnPaste;
		private ToolStripMenuItem BtnSetBlank;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel LbInfo;
		private ToolStripMenuItem BtnCut;
		private ToolStripMenuItem BtnNew;
	}
}