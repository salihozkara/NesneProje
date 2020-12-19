
namespace NesneProje
{
    partial class FrmMarketler
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
            this.DataGVMarket = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewButtonColumn();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataGVMarket)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGVMarket
            // 
            this.DataGVMarket.AllowUserToAddRows = false;
            this.DataGVMarket.AllowUserToDeleteRows = false;
            this.DataGVMarket.AllowUserToResizeColumns = false;
            this.DataGVMarket.AllowUserToResizeRows = false;
            this.DataGVMarket.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGVMarket.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DataGVMarket.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DataGVMarket.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGVMarket.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.ColumnID});
            this.DataGVMarket.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGVMarket.Location = new System.Drawing.Point(0, 0);
            this.DataGVMarket.Name = "DataGVMarket";
            this.DataGVMarket.ReadOnly = true;
            this.DataGVMarket.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGVMarket.RowHeadersVisible = false;
            this.DataGVMarket.RowHeadersWidth = 51;
            this.DataGVMarket.RowTemplate.Height = 24;
            this.DataGVMarket.Size = new System.Drawing.Size(721, 467);
            this.DataGVMarket.TabIndex = 1;
            this.DataGVMarket.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGVMarket_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ad";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "adres";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "MarketID";
            this.ColumnID.MinimumWidth = 6;
            this.ColumnID.Name = "ColumnID";
            this.ColumnID.ReadOnly = true;
            this.ColumnID.Visible = false;
            // 
            // FrmMarketler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 467);
            this.Controls.Add(this.DataGVMarket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMarketler";
            this.Text = "FrmMarketler";
            this.Load += new System.EventHandler(this.FrmMarketler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGVMarket)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGVMarket;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewButtonColumn Column3;
        private System.Windows.Forms.DataGridViewButtonColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
    }
}