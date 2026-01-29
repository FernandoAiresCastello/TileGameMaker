namespace TileGameMaker.Forms
{
	partial class CurrentTileWindow
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
			PnlTile = new Panel();
			DataGrid = new DataGridView();
			Data = new DataGridViewTextBoxColumn();
			Value = new DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)DataGrid).BeginInit();
			SuspendLayout();
			// 
			// PnlTile
			// 
			PnlTile.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
			PnlTile.BorderStyle = BorderStyle.FixedSingle;
			PnlTile.Location = new Point(86, 13);
			PnlTile.Name = "PnlTile";
			PnlTile.Size = new Size(100, 100);
			PnlTile.TabIndex = 0;
			// 
			// DataGrid
			// 
			DataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
			DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGrid.Columns.AddRange(new DataGridViewColumn[] { Data, Value });
			DataGrid.Location = new Point(12, 128);
			DataGrid.MultiSelect = false;
			DataGrid.Name = "DataGrid";
			DataGrid.RowHeadersVisible = false;
			DataGrid.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			DataGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
			DataGrid.Size = new Size(253, 263);
			DataGrid.TabIndex = 1;
			// 
			// Data
			// 
			Data.HeaderText = "Data";
			Data.Name = "Data";
			// 
			// Value
			// 
			Value.HeaderText = "Value";
			Value.Name = "Value";
			// 
			// CurrentTileWindow
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(277, 403);
			Controls.Add(DataGrid);
			Controls.Add(PnlTile);
			Name = "CurrentTileWindow";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Current Tile";
			((System.ComponentModel.ISupportInitialize)DataGrid).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private Panel PnlTile;
		private DataGridView DataGrid;
		private DataGridViewTextBoxColumn Data;
		private DataGridViewTextBoxColumn Value;
	}
}