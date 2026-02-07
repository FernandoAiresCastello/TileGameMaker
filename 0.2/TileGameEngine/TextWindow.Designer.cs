namespace TileGameEngine
{
	partial class TextWindow
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
			TxtText = new TextBox();
			BtnOk = new Button();
			SuspendLayout();
			// 
			// TxtText
			// 
			TxtText.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			TxtText.Location = new Point(12, 12);
			TxtText.Multiline = true;
			TxtText.Name = "TxtText";
			TxtText.ReadOnly = true;
			TxtText.ScrollBars = ScrollBars.Vertical;
			TxtText.Size = new Size(347, 359);
			TxtText.TabIndex = 0;
			TxtText.TabStop = false;
			TxtText.Text = "Text";
			// 
			// BtnOk
			// 
			BtnOk.DialogResult = DialogResult.OK;
			BtnOk.FlatStyle = FlatStyle.Flat;
			BtnOk.Location = new Point(148, 380);
			BtnOk.Name = "BtnOk";
			BtnOk.Size = new Size(75, 32);
			BtnOk.TabIndex = 1;
			BtnOk.Text = "OK";
			BtnOk.UseVisualStyleBackColor = true;
			// 
			// TextWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(371, 420);
			ControlBox = false;
			Controls.Add(BtnOk);
			Controls.Add(TxtText);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "TextWindow";
			StartPosition = FormStartPosition.CenterScreen;
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private TextBox TxtText;
		private Button BtnOk;
	}
}