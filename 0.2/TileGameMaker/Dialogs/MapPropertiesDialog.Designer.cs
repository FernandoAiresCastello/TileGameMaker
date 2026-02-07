namespace TileGameMaker.Dialogs
{
	partial class MapPropertiesDialog
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
			label1 = new Label();
			TxtTitle = new TextBox();
			label2 = new Label();
			BtnAccentBack = new Button();
			BtnAccentFore = new Button();
			LbAccentSample = new Label();
			BtnOk = new Button();
			BtnCancel = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(18, 18);
			label1.Name = "label1";
			label1.Size = new Size(29, 15);
			label1.TabIndex = 0;
			label1.Text = "Title";
			// 
			// TxtTitle
			// 
			TxtTitle.Location = new Point(60, 15);
			TxtTitle.Name = "TxtTitle";
			TxtTitle.Size = new Size(472, 23);
			TxtTitle.TabIndex = 1;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(70, 65);
			label2.Name = "label2";
			label2.Size = new Size(79, 15);
			label2.TabIndex = 2;
			label2.Text = "Accent colors";
			// 
			// BtnAccentBack
			// 
			BtnAccentBack.Location = new Point(18, 88);
			BtnAccentBack.Name = "BtnAccentBack";
			BtnAccentBack.Size = new Size(88, 40);
			BtnAccentBack.TabIndex = 3;
			BtnAccentBack.Text = "Background";
			BtnAccentBack.UseVisualStyleBackColor = true;
			BtnAccentBack.Click += BtnAccentBack_Click;
			// 
			// BtnAccentFore
			// 
			BtnAccentFore.Location = new Point(112, 88);
			BtnAccentFore.Name = "BtnAccentFore";
			BtnAccentFore.Size = new Size(88, 40);
			BtnAccentFore.TabIndex = 4;
			BtnAccentFore.Text = "Text";
			BtnAccentFore.UseVisualStyleBackColor = true;
			BtnAccentFore.Click += BtnAccentFore_Click;
			// 
			// LbAccentSample
			// 
			LbAccentSample.BorderStyle = BorderStyle.Fixed3D;
			LbAccentSample.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
			LbAccentSample.Location = new Point(208, 89);
			LbAccentSample.Name = "LbAccentSample";
			LbAccentSample.Size = new Size(324, 39);
			LbAccentSample.TabIndex = 5;
			LbAccentSample.Text = "Sample";
			LbAccentSample.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// BtnOk
			// 
			BtnOk.DialogResult = DialogResult.OK;
			BtnOk.Location = new Point(444, 228);
			BtnOk.Name = "BtnOk";
			BtnOk.Size = new Size(88, 40);
			BtnOk.TabIndex = 6;
			BtnOk.Text = "OK";
			BtnOk.UseVisualStyleBackColor = true;
			// 
			// BtnCancel
			// 
			BtnCancel.DialogResult = DialogResult.Cancel;
			BtnCancel.Location = new Point(350, 228);
			BtnCancel.Name = "BtnCancel";
			BtnCancel.Size = new Size(88, 40);
			BtnCancel.TabIndex = 7;
			BtnCancel.Text = "Cancel";
			BtnCancel.UseVisualStyleBackColor = true;
			// 
			// MapPropertiesDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(553, 280);
			Controls.Add(BtnCancel);
			Controls.Add(BtnOk);
			Controls.Add(LbAccentSample);
			Controls.Add(BtnAccentFore);
			Controls.Add(BtnAccentBack);
			Controls.Add(label2);
			Controls.Add(TxtTitle);
			Controls.Add(label1);
			MaximizeBox = false;
			Name = "MapPropertiesDialog";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Map properties";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox TxtTitle;
		private Label label2;
		private Button BtnAccentBack;
		private Button BtnAccentFore;
		private Label LbAccentSample;
		private Button BtnOk;
		private Button BtnCancel;
	}
}