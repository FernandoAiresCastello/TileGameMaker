namespace TileGameMaker.Forms
{
    partial class BoardWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			toolStrip1 = new ToolStrip();
			BtnGridToggle = new ToolStripButton();
			PnlBoard = new Panel();
			BtnLoad = new ToolStripButton();
			BtnSave = new ToolStripButton();
			toolStripSeparator1 = new ToolStripSeparator();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.Items.AddRange(new ToolStripItem[] { BtnLoad, BtnSave, toolStripSeparator1, BtnGridToggle });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(732, 25);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// BtnGridToggle
			// 
			BtnGridToggle.Checked = true;
			BtnGridToggle.CheckOnClick = true;
			BtnGridToggle.CheckState = CheckState.Checked;
			BtnGridToggle.DisplayStyle = ToolStripItemDisplayStyle.Image;
			BtnGridToggle.Image = Properties.Resources.layouts_four_grid;
			BtnGridToggle.ImageTransparentColor = Color.Magenta;
			BtnGridToggle.Name = "BtnGridToggle";
			BtnGridToggle.Size = new Size(23, 22);
			BtnGridToggle.Text = "Toggle grid";
			BtnGridToggle.Click += BtnGridToggle_Click;
			// 
			// PnlBoard
			// 
			PnlBoard.Dock = DockStyle.Fill;
			PnlBoard.Location = new Point(0, 25);
			PnlBoard.Name = "PnlBoard";
			PnlBoard.Size = new Size(732, 606);
			PnlBoard.TabIndex = 1;
			// 
			// BtnLoad
			// 
			BtnLoad.DisplayStyle = ToolStripItemDisplayStyle.Image;
			BtnLoad.Image = Properties.Resources.folder;
			BtnLoad.ImageTransparentColor = Color.Magenta;
			BtnLoad.Name = "BtnLoad";
			BtnLoad.Size = new Size(23, 22);
			BtnLoad.Text = "Load";
			BtnLoad.Click += BtnLoad_Click;
			// 
			// BtnSave
			// 
			BtnSave.DisplayStyle = ToolStripItemDisplayStyle.Image;
			BtnSave.Image = Properties.Resources.diskette;
			BtnSave.ImageTransparentColor = Color.Magenta;
			BtnSave.Name = "BtnSave";
			BtnSave.Size = new Size(23, 22);
			BtnSave.Text = "Save";
			BtnSave.Click += BtnSave_Click;
			// 
			// toolStripSeparator1
			// 
			toolStripSeparator1.Name = "toolStripSeparator1";
			toolStripSeparator1.Size = new Size(6, 25);
			// 
			// BoardWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(732, 631);
			ControlBox = false;
			Controls.Add(PnlBoard);
			Controls.Add(toolStrip1);
			MaximizeBox = false;
			Name = "BoardWindow";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Board";
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip1;
		private Panel PnlBoard;
		private ToolStripButton BtnGridToggle;
		private ToolStripButton BtnLoad;
		private ToolStripButton BtnSave;
		private ToolStripSeparator toolStripSeparator1;
	}
}
