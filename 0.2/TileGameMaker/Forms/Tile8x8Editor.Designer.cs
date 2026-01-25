namespace TileGameMaker.Forms
{
	partial class Tile8x8Editor
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
			statusStrip1 = new StatusStrip();
			PnlDisplay = new Panel();
			SuspendLayout();
			// 
			// toolStrip1
			// 
			toolStrip1.Location = new Point(0, 0);
			toolStrip1.Name = "toolStrip1";
			toolStrip1.Size = new Size(297, 25);
			toolStrip1.TabIndex = 0;
			toolStrip1.Text = "toolStrip1";
			// 
			// statusStrip1
			// 
			statusStrip1.Location = new Point(0, 324);
			statusStrip1.Name = "statusStrip1";
			statusStrip1.Size = new Size(297, 22);
			statusStrip1.SizingGrip = false;
			statusStrip1.TabIndex = 1;
			statusStrip1.Text = "statusStrip1";
			// 
			// PnlDisplay
			// 
			PnlDisplay.BorderStyle = BorderStyle.Fixed3D;
			PnlDisplay.Dock = DockStyle.Fill;
			PnlDisplay.Location = new Point(0, 25);
			PnlDisplay.Name = "PnlDisplay";
			PnlDisplay.Size = new Size(297, 299);
			PnlDisplay.TabIndex = 2;
			// 
			// Tile8x8Editor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(297, 346);
			Controls.Add(PnlDisplay);
			Controls.Add(statusStrip1);
			Controls.Add(toolStrip1);
			Name = "Tile8x8Editor";
			StartPosition = FormStartPosition.CenterScreen;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip1;
		private StatusStrip statusStrip1;
		private Panel PnlDisplay;
	}
}