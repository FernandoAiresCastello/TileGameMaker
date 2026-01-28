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
			PnlCharset = new Panel();
			SuspendLayout();
			// 
			// PnlCharset
			// 
			PnlCharset.Dock = DockStyle.Fill;
			PnlCharset.Location = new Point(0, 0);
			PnlCharset.Name = "PnlCharset";
			PnlCharset.Size = new Size(474, 450);
			PnlCharset.TabIndex = 1;
			// 
			// CharsetWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(474, 450);
			Controls.Add(PnlCharset);
			Name = "CharsetWindow";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Charset";
			ResumeLayout(false);
		}

		#endregion
		private Panel PnlCharset;
	}
}