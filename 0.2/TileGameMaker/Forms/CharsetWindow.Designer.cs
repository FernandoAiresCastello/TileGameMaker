namespace TileGameMaker.Forms
{
	partial class CharsetWindow
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
			toolStrip1 = new ToolStrip();
			BtnLoad = new ToolStripButton();
			PnlCharset = new Panel();
			BtnSave = new ToolStripButton();
			toolStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.Items.AddRange(new ToolStripItem[] { BtnLoad, BtnSave });
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(474, 25);
			toolStrip1.TabIndex = 2;
			toolStrip1.Text = "toolStrip1";
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
			// PnlCharset
			// 
			PnlCharset.Dock = DockStyle.Fill;
			PnlCharset.Location = new Point(0, 25);
			PnlCharset.Name = "PnlCharset";
			PnlCharset.Size = new Size(474, 425);
			PnlCharset.TabIndex = 3;
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
			// CharsetWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(474, 450);
			ControlBox = false;
			Controls.Add(PnlCharset);
			Controls.Add(toolStrip1);
			MaximizeBox = false;
			Name = "CharsetWindow";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Charset";
			toolStrip1.ResumeLayout(false);
			toolStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip1;
		private Panel PnlCharset;
		private ToolStripButton BtnLoad;
		private ToolStripButton BtnSave;
	}
}