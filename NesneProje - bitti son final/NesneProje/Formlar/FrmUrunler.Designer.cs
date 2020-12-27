
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGVUrunler = new System.Windows.Forms.DataGridView();
            this.ColumnAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnGrup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStok = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnIndirimliFiyat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnTarih = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maskedTxtOran = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbUrunGrup = new System.Windows.Forms.ComboBox();
            this.btnIndirim = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUrunler)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGVUrunler);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.splitContainer1.Panel2.Controls.Add(this.maskedTxtOran);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.cmbUrunGrup);
            this.splitContainer1.Panel2.Controls.Add(this.btnIndirim);
            this.splitContainer1.Size = new System.Drawing.Size(757, 481);
            this.splitContainer1.SplitterDistance = 412;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGVUrunler
            // 
            this.dataGVUrunler.AllowUserToAddRows = false;
            this.dataGVUrunler.AllowUserToDeleteRows = false;
            this.dataGVUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVUrunler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVUrunler.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGVUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVUrunler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAd,
            this.ColumnGrup,
            this.ColumnStok,
            this.ColumnFiyat,
            this.ColumnIndirimliFiyat,
            this.ColumnTarih});
            this.dataGVUrunler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVUrunler.Location = new System.Drawing.Point(0, 0);
            this.dataGVUrunler.Name = "dataGVUrunler";
            this.dataGVUrunler.ReadOnly = true;
            this.dataGVUrunler.RowHeadersVisible = false;
            this.dataGVUrunler.RowHeadersWidth = 51;
            this.dataGVUrunler.RowTemplate.Height = 24;
            this.dataGVUrunler.Size = new System.Drawing.Size(757, 412);
            this.dataGVUrunler.TabIndex = 1;
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
            // ColumnTarih
            // 
            this.ColumnTarih.HeaderText = "Son İndirim Tarihi";
            this.ColumnTarih.MinimumWidth = 6;
            this.ColumnTarih.Name = "ColumnTarih";
            this.ColumnTarih.ReadOnly = true;
            // 
            // maskedTxtOran
            // 
            this.maskedTxtOran.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.maskedTxtOran.Location = new System.Drawing.Point(440, 22);
            this.maskedTxtOran.Name = "maskedTxtOran";
            this.maskedTxtOran.Size = new System.Drawing.Size(100, 22);
            this.maskedTxtOran.TabIndex = 12;
            this.maskedTxtOran.ValidatingType = typeof(int);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(316, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 17);
            this.label3.TabIndex = 11;
            this.label3.Text = "İndirim Oranı";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Ürün Grubu";
            // 
            // cmbUrunGrup
            // 
            this.cmbUrunGrup.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cmbUrunGrup.FormattingEnabled = true;
            this.cmbUrunGrup.Items.AddRange(new object[] {
            "Gıda",
            "Temizlik",
            "Haftalık Kampanya"});
            this.cmbUrunGrup.Location = new System.Drawing.Point(166, 20);
            this.cmbUrunGrup.Name = "cmbUrunGrup";
            this.cmbUrunGrup.Size = new System.Drawing.Size(121, 24);
            this.cmbUrunGrup.TabIndex = 9;
            // 
            // btnIndirim
            // 
            this.btnIndirim.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnIndirim.Location = new System.Drawing.Point(593, 14);
            this.btnIndirim.Name = "btnIndirim";
            this.btnIndirim.Size = new System.Drawing.Size(110, 36);
            this.btnIndirim.TabIndex = 8;
            this.btnIndirim.Text = "İndirim Yap";
            this.btnIndirim.UseVisualStyleBackColor = true;
            this.btnIndirim.Click += new System.EventHandler(this.btnIndirim_Click);
            // 
            // FrmUrunler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 481);
            this.Controls.Add(this.splitContainer1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUrunler";
            this.Text = "Ürünler";
            this.Load += new System.EventHandler(this.FrmUrunler_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUrunler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGVUrunler;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGrup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStok;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnFiyat;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnIndirimliFiyat;
        private System.Windows.Forms.MaskedTextBox maskedTxtOran;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbUrunGrup;
        private System.Windows.Forms.Button btnIndirim;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnTarih;
    }
}