
namespace NesneProje.Formlar
{
    partial class FrmUrunler
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
            this.dataGVUrunler = new System.Windows.Forms.DataGridView();
            this.ColumnAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIndirimliFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnIndirim = new System.Windows.Forms.Button();
            this.cmbUrunGrup = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.maskedTxtOran = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVUrunler
            // 
            this.dataGVUrunler.AllowUserToAddRows = false;
            this.dataGVUrunler.AllowUserToDeleteRows = false;
            this.dataGVUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVUrunler.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGVUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAd,
            this.ColumnGrup,
            this.ColumnStok,
            this.ColumnFiyat,
            this.ColumnIndirimliFiyat});
            this.dataGVUrunler.Location = new System.Drawing.Point(2, 33);
            this.dataGVUrunler.Name = "dataGVUrunler";
            this.dataGVUrunler.ReadOnly = true;
            this.dataGVUrunler.RowHeadersVisible = false;
            this.dataGVUrunler.RowHeadersWidth = 51;
            this.dataGVUrunler.RowTemplate.Height = 24;
            this.dataGVUrunler.Size = new System.Drawing.Size(747, 383);
            this.dataGVUrunler.TabIndex = 0;
            // 
            // ColumnAd
            // 
            this.ColumnAd.HeaderText = "Ad";
            this.ColumnAd.MinimumWidth = 6;
            this.ColumnAd.Name = "ColumnAd";
            this.ColumnAd.ReadOnly = true;
            // 
            // ColumnGrup
            // 
            this.ColumnGrup.HeaderText = "Grup";
            this.ColumnGrup.MinimumWidth = 6;
            this.ColumnGrup.Name = "ColumnGrup";
            this.ColumnGrup.ReadOnly = true;
            // 
            // ColumnStok
            // 
            this.ColumnStok.HeaderText = "Stok";
            this.ColumnStok.MinimumWidth = 6;
            this.ColumnStok.Name = "ColumnStok";
            this.ColumnStok.ReadOnly = true;
            // 
            // ColumnFiyat
            // 
            this.ColumnFiyat.HeaderText = "Fiyat";
            this.ColumnFiyat.MinimumWidth = 6;
            this.ColumnFiyat.Name = "ColumnFiyat";
            this.ColumnFiyat.ReadOnly = true;
            // 
            // ColumnIndirimliFiyat
            // 
            this.ColumnIndirimliFiyat.HeaderText = "İndirimli fiyat";
            this.ColumnIndirimliFiyat.MinimumWidth = 6;
            this.ColumnIndirimliFiyat.Name = "ColumnIndirimliFiyat";
            this.ColumnIndirimliFiyat.ReadOnly = true;
            // 
            // btnIndirim
            // 
            this.btnIndirim.Location = new System.Drawing.Point(579, 428);
            this.btnIndirim.Name = "btnIndirim";
            this.btnIndirim.Size = new System.Drawing.Size(110, 36);
            this.btnIndirim.TabIndex = 1;
            this.btnIndirim.Text = "İndirim Yap";
            this.btnIndirim.UseVisualStyleBackColor = true;
            // 
            // cmbUrunGrup
            // 
            this.cmbUrunGrup.FormattingEnabled = true;
            this.cmbUrunGrup.Items.AddRange(new object[] {
            "Gıda",
            "Temizlik",
            "Haftalık Kampanya"});
            this.cmbUrunGrup.Location = new System.Drawing.Point(152, 434);
            this.cmbUrunGrup.Name = "cmbUrunGrup";
            this.cmbUrunGrup.Size = new System.Drawing.Size(121, 24);
            this.cmbUrunGrup.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ürünler";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 439);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ürün Grubu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(302, 438);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "İndirim Oranı";
            // 
            // maskedTxtOran
            // 
            this.maskedTxtOran.Location = new System.Drawing.Point(426, 436);
            this.maskedTxtOran.Mask = "%00";
            this.maskedTxtOran.Name = "maskedTxtOran";
            this.maskedTxtOran.Size = new System.Drawing.Size(100, 22);
            this.maskedTxtOran.TabIndex = 7;
            this.maskedTxtOran.ValidatingType = typeof(int);
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 481);
            this.Controls.Add(this.maskedTxtOran);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbUrunGrup);
            this.Controls.Add(this.btnIndirim);
            this.Controls.Add(this.dataGVUrunler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUrunler";
            this.Text = "FrmUrunler";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVUrunler;
        private System.Windows.Forms.Button btnIndirim;
        private System.Windows.Forms.ComboBox cmbUrunGrup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox maskedTxtOran;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndirimliFiyat;
    }
}