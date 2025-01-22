namespace TileGameMaker.StandaloneTools
{
	partial class TilePainterWindow
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
			menuStrip1 = new MenuStrip();
			statusStrip1 = new StatusStrip();
			SuspendLayout();
			// 
			// menuStrip1
			// 
			menuStrip1.Location = new Point(0, 0);
			menuStrip1.Name = "menuStrip1";
			menuStrip1.Size = new Size(551, 24);
			menuStrip1.TabIndex = 0;
			menuStrip1.Text = "menuStrip1";
			// 
			// statusStrip1
			// 
			statusStrip1.Location = new Point(0, 428);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(551, 22);
			statusStrip1.SizingGrip = false;
			statusStrip1.TabIndex = 1;
			statusStrip1.Text = "statusStrip1";
			// 
			// TilePainterWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(551, 450);
			Controls.Add(statusStrip1);
			Controls.Add(menuStrip1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MainMenuStrip = menuStrip1;
			MaximizeBox = false;
			Name = "TilePainterWindow";
			Text = "Tile Painter";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private MenuStrip menuStrip1;
		private StatusStrip statusStrip1;
	}
}