namespace TileGameMaker.StandaloneTools
{
	partial class Mono8x8TilePainterWindow
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
			EditorPanel = new Panel();
			menuStrip1 = new MenuStrip();
			statusStrip1 = new StatusStrip();
			LbInfo = new ToolStripStatusLabel();
			statusStrip1.SuspendLayout();
			SuspendLayout();
			// 
			// EditorPanel
			// 
			EditorPanel.BorderStyle = BorderStyle.Fixed3D;
			EditorPanel.Location = new Point(6, 29);
			EditorPanel.MaximumSize = new Size(196, 196);
			EditorPanel.MinimumSize = new Size(196, 196);
			EditorPanel.Name = "EditorPanel";
			EditorPanel.Size = new Size(196, 196);
			EditorPanel.TabIndex = 0;
			// 
			// menuStrip1
			// 
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(326, 24);
			menuStrip1.TabIndex = 1;
			menuStrip1.Text = "menuStrip1";
			// 
			// statusStrip1
			// 
			statusStrip1.Items.AddRange(new ToolStripItem[] { LbInfo });
			statusStrip1.Location = new Point(0, 229);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(326, 22);
			statusStrip1.SizingGrip = false;
			statusStrip1.TabIndex = 2;
			statusStrip1.Text = "statusStrip1";
			// 
			// LbInfo
			// 
			LbInfo.Name = "LbInfo";
			LbInfo.Size = new Size(28, 17);
			LbInfo.Text = "Info";
			// 
			// Mono8x8TilePainterWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(326, 251);
			Controls.Add(statusStrip1);
			Controls.Add(EditorPanel);
			Controls.Add(menuStrip1);
			MainMenuStrip = menuStrip1;
			Name = "Mono8x8TilePainterWindow";
			Text = "Mono 8x8 Tile Painter";
			statusStrip1.ResumeLayout(false);
			statusStrip1.PerformLayout();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel EditorPanel;
		private MenuStrip menuStrip1;
		private StatusStrip statusStrip1;
		private ToolStripStatusLabel LbInfo;
	}
}