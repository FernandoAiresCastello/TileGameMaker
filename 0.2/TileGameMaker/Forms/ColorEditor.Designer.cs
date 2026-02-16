namespace TileGameMaker.Forms
{
	partial class ColorEditor
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
			PnlColor = new Panel();
			TxtHex = new TextBox();
			label4 = new Label();
			button1 = new Button();
			SuspendLayout();
			// 
			// PnlColor
			// 
			PnlColor.BorderStyle = BorderStyle.Fixed3D;
			PnlColor.Location = new Point(13, 47);
			PnlColor.Name = "PnlColor";
			PnlColor.Size = new Size(334, 70);
			PnlColor.TabIndex = 0;
			// 
			// TxtHex
			// 
			TxtHex.CharacterCasing = CharacterCasing.Upper;
			TxtHex.Location = new Point(151, 12);
			TxtHex.MaxLength = 6;
			TxtHex.Name = "TxtHex";
			TxtHex.Size = new Size(100, 23);
			TxtHex.TabIndex = 8;
			TxtHex.TextAlign = HorizontalAlignment.Center;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(117, 15);
			label4.Name = "label4";
			label4.Size = new Size(29, 15);
			label4.TabIndex = 9;
			label4.Text = "RGB";
			// 
			// button1
			// 
			button1.DialogResult = DialogResult.OK;
			button1.Location = new Point(272, 123);
			button1.Name = "button1";
			button1.Size = new Size(75, 34);
			button1.TabIndex = 10;
			button1.Text = "OK";
			button1.UseVisualStyleBackColor = true;
			// 
			// ColorEditor
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(359, 166);
			Controls.Add(button1);
			Controls.Add(label4);
			Controls.Add(TxtHex);
			Controls.Add(PnlColor);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "ColorEditor";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Color editor";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Panel PnlColor;
		private TextBox TxtHex;
		private Label label4;
		private Button button1;
	}
}