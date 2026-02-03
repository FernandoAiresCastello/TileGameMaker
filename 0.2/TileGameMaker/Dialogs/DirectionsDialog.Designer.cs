namespace TileGameMaker.Dialogs
{
	partial class DirectionsDialog
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
			TxtNorth = new TextBox();
			TxtWest = new TextBox();
			label2 = new Label();
			TxtSouth = new TextBox();
			label3 = new Label();
			TxtEast = new TextBox();
			label4 = new Label();
			BtnCancel = new Button();
			BtnOk = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(22, 23);
			label1.Name = "label1";
			label1.Size = new Size(38, 15);
			label1.TabIndex = 0;
			label1.Text = "North";
			// 
			// TxtNorth
			// 
			TxtNorth.Location = new Point(70, 20);
			TxtNorth.Name = "TxtNorth";
			TxtNorth.Size = new Size(335, 23);
			TxtNorth.TabIndex = 1;
			// 
			// TxtWest
			// 
			TxtWest.Location = new Point(70, 107);
			TxtWest.Name = "TxtWest";
			TxtWest.Size = new Size(335, 23);
			TxtWest.TabIndex = 3;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(24, 110);
			label2.Name = "label2";
			label2.Size = new Size(33, 15);
			label2.TabIndex = 2;
			label2.Text = "West";
			// 
			// TxtSouth
			// 
			TxtSouth.Location = new Point(70, 49);
			TxtSouth.Name = "TxtSouth";
			TxtSouth.Size = new Size(335, 23);
			TxtSouth.TabIndex = 5;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(22, 52);
			label3.Name = "label3";
			label3.Size = new Size(38, 15);
			label3.TabIndex = 4;
			label3.Text = "South";
			// 
			// TxtEast
			// 
			TxtEast.Location = new Point(70, 78);
			TxtEast.Name = "TxtEast";
			TxtEast.Size = new Size(335, 23);
			TxtEast.TabIndex = 7;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(29, 81);
			label4.Name = "label4";
			label4.Size = new Size(28, 15);
			label4.TabIndex = 6;
			label4.Text = "East";
			// 
			// BtnCancel
			// 
			BtnCancel.DialogResult = DialogResult.Cancel;
			BtnCancel.Location = new Point(249, 141);
			BtnCancel.Name = "BtnCancel";
			BtnCancel.Size = new Size(75, 39);
			BtnCancel.TabIndex = 8;
			BtnCancel.Text = "Cancel";
			BtnCancel.UseVisualStyleBackColor = true;
			// 
			// BtnOk
			// 
			BtnOk.DialogResult = DialogResult.OK;
			BtnOk.Location = new Point(330, 141);
			BtnOk.Name = "BtnOk";
			BtnOk.Size = new Size(75, 39);
			BtnOk.TabIndex = 9;
			BtnOk.Text = "OK";
			BtnOk.UseVisualStyleBackColor = true;
			// 
			// DirectionsDialog
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(426, 192);
			Controls.Add(BtnOk);
			Controls.Add(BtnCancel);
			Controls.Add(TxtEast);
			Controls.Add(label4);
			Controls.Add(TxtSouth);
			Controls.Add(label3);
			Controls.Add(TxtWest);
			Controls.Add(label2);
			Controls.Add(TxtNorth);
			Controls.Add(label1);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			MaximizeBox = false;
			Name = "DirectionsDialog";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Directions";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private TextBox TxtNorth;
		private TextBox TxtWest;
		private Label label2;
		private TextBox TxtSouth;
		private Label label3;
		private TextBox TxtEast;
		private Label label4;
		private Button BtnCancel;
		private Button BtnOk;
	}
}