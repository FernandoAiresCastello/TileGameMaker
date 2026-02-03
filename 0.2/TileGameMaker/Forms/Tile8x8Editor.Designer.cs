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
			// PnlDisplay
			// 
			PnlDisplay.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			PnlDisplay.BorderStyle = BorderStyle.FixedSingle;
			PnlDisplay.Location = new Point(23, 49);
			PnlDisplay.Name = "PnlDisplay";
			PnlDisplay.Size = new Size(252, 272);
			PnlDisplay.TabIndex = 2;
			// 
			// Tile8x8Editor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(297, 346);
			Controls.Add(PnlDisplay);
			Controls.Add(toolStrip1);
			MaximizeBox = false;
			Name = "Tile8x8Editor";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Tile Editor";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private ToolStrip toolStrip1;
		private Panel PnlDisplay;
	}
}