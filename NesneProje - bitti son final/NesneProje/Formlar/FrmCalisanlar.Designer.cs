
namespace NesneProje.Formlar
{
    partial class FrmCalisanlar
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
            this.dataGVCalisanlar = new System.Windows.Forms.DataGridView();
            this.ColumnAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnAdres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnSure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMarket = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnPozisyon = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.ColumnMaas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnH_izinGunu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnYillikIzin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnKaydet = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCalisanlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVCalisanlar
            // 
            this.dataGVCalisanlar.AllowUserToAddRows = false;
            this.dataGVCalisanlar.AllowUserToDeleteRows = false;
            this.dataGVCalisanlar.AllowUserToResizeColumns = false;
            this.dataGVCalisanlar.AllowUserToResizeRows = false;
            this.dataGVCalisanlar.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGVCalisanlar.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGVCalisanlar.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGVCalisanlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCalisanlar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnAd,
            this.ColumnAdres,
            this.ColumnSure,
            this.ColumnMarket,
            this.ColumnPozisyon,
            this.ColumnMaas,
            this.ColumnH_izinGunu,
            this.ColumnYillikIzin,
            this.ColumnKID,
            this.ColumnMID,
            this.ColumnKaydet});
            this.dataGVCalisanlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGVCalisanlar.Location = new System.Drawing.Point(0, 0);
            this.dataGVCalisanlar.Name = "dataGVCalisanlar";
            this.dataGVCalisanlar.RowHeadersVisible = false;
            this.dataGVCalisanlar.RowHeadersWidth = 51;
            this.dataGVCalisanlar.RowTemplate.Height = 24;
            this.dataGVCalisanlar.Size = new System.Drawing.Size(951, 451);
            this.dataGVCalisanlar.TabIndex = 18;
            this.dataGVCalisanlar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVCalisanlar_CellContentClick);
            // 
            // ColumnAd
            // 
            this.ColumnAd.HeaderText = "Ad";
            this.ColumnAd.MinimumWidth = 6;
            this.ColumnAd.Name = "ColumnAd";
            this.ColumnAd.ReadOnly = true;
            // 
            // ColumnAdres
            // 
            this.ColumnAdres.HeaderText = "Adres";
            this.ColumnAdres.MinimumWidth = 6;
            this.ColumnAdres.Name = "ColumnAdres";
            this.ColumnAdres.ReadOnly = true;
            // 
            // ColumnSure
            // 
            this.ColumnSure.HeaderText = "Çalıştığı Süre";
            this.ColumnSure.MinimumWidth = 6;
            this.ColumnSure.Name = "ColumnSure";
            this.ColumnSure.ReadOnly = true;
            // 
            // ColumnMarket
            // 
            this.ColumnMarket.HeaderText = "Market";
            this.ColumnMarket.MinimumWidth = 6;
            this.ColumnMarket.Name = "ColumnMarket";
            // 
            // ColumnPozisyon
            // 
            this.ColumnPozisyon.HeaderText = "Pozisyon";
            this.ColumnPozisyon.MinimumWidth = 6;
            this.ColumnPozisyon.Name = "ColumnPozisyon";
            // 
            // ColumnMaas
            // 
            this.ColumnMaas.HeaderText = "Maaş";
            this.ColumnMaas.MinimumWidth = 6;
            this.ColumnMaas.Name = "ColumnMaas";
            this.ColumnMaas.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnMaas.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnH_izinGunu
            // 
            this.ColumnH_izinGunu.HeaderText = "Haftalık İzin Günü";
            this.ColumnH_izinGunu.MinimumWidth = 6;
            this.ColumnH_izinGunu.Name = "ColumnH_izinGunu";
            this.ColumnH_izinGunu.ReadOnly = true;
            this.ColumnH_izinGunu.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnH_izinGunu.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnYillikIzin
            // 
            this.ColumnYillikIzin.HeaderText = "Yıllık Kalan İzin";
            this.ColumnYillikIzin.MinimumWidth = 6;
            this.ColumnYillikIzin.Name = "ColumnYillikIzin";
            this.ColumnYillikIzin.ReadOnly = true;
            this.ColumnYillikIzin.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ColumnYillikIzin.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ColumnKID
            // 
            this.ColumnKID.HeaderText = "KullaniciID";
            this.ColumnKID.MinimumWidth = 6;
            this.ColumnKID.Name = "ColumnKID";
            this.ColumnKID.ReadOnly = true;
            this.ColumnKID.Visible = false;
            // 
            // ColumnMID
            // 
            this.ColumnMID.HeaderText = "MarketID";
            this.ColumnMID.MinimumWidth = 6;
            this.ColumnMID.Name = "ColumnMID";
            this.ColumnMID.ReadOnly = true;
            this.ColumnMID.Visible = false;
            // 
            // ColumnKaydet
            // 
            this.ColumnKaydet.HeaderText = "";
            this.ColumnKaydet.MinimumWidth = 6;
            this.ColumnKaydet.Name = "ColumnKaydet";
            // 
            // FrmCalisanlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 451);
            this.Controls.Add(this.dataGVCalisanlar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCalisanlar";
            this.Text = "Calisanlar";
            this.Load += new System.EventHandler(this.FrmCalisanlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCalisanlar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGVCalisanlar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnAdres;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnSure;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnMarket;
        private System.Windows.Forms.DataGridViewComboBoxColumn ColumnPozisyon;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaas;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnH_izinGunu;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnYillikIzin;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnKID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMID;
        private System.Windows.Forms.DataGridViewButtonColumn ColumnKaydet;
    }
}