
namespace NesneProje
{
    partial class FrmAdminPanel
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnTedarikciler = new System.Windows.Forms.Button();
            this.btnMarketler = new System.Windows.Forms.Button();
            this.btnCalisanEkle = new System.Windows.Forms.Button();
            this.lblKayit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(48, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(324, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hangisini görüntülemek istiyorsunuz?";
            // 
            // btnTedarikciler
            // 
            this.btnTedarikciler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnTedarikciler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTedarikciler.Location = new System.Drawing.Point(225, 140);
            this.btnTedarikciler.Name = "btnTedarikciler";
            this.btnTedarikciler.Size = new System.Drawing.Size(102, 53);
            this.btnTedarikciler.TabIndex = 3;
            this.btnTedarikciler.Text = "Tedarikçiler";
            this.btnTedarikciler.UseVisualStyleBackColor = true;
            this.btnTedarikciler.Click += new System.EventHandler(this.btnTedarikcilerlar_Click);
            // 
            // btnMarketler
            // 
            this.btnMarketler.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMarketler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMarketler.Location = new System.Drawing.Point(103, 140);
            this.btnMarketler.Name = "btnMarketler";
            this.btnMarketler.Size = new System.Drawing.Size(102, 53);
            this.btnMarketler.TabIndex = 4;
            this.btnMarketler.Text = "Marketler";
            this.btnMarketler.UseVisualStyleBackColor = true;
            this.btnMarketler.Click += new System.EventHandler(this.btnMarketler_Click);
            // 
            // btnCalisanEkle
            // 
            this.btnCalisanEkle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnCalisanEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalisanEkle.Location = new System.Drawing.Point(165, 199);
            this.btnCalisanEkle.Name = "btnCalisanEkle";
            this.btnCalisanEkle.Size = new System.Drawing.Size(102, 53);
            this.btnCalisanEkle.TabIndex = 5;
            this.btnCalisanEkle.Text = "Calisan ekle";
            this.btnCalisanEkle.UseVisualStyleBackColor = true;
            this.btnCalisanEkle.Click += new System.EventHandler(this.btnCalisanEkle_Click);
            // 
            // lblKayit
            // 
            this.lblKayit.AutoSize = true;
            this.lblKayit.Location = new System.Drawing.Point(12, 9);
            this.lblKayit.Name = "lblKayit";
            this.lblKayit.Size = new System.Drawing.Size(97, 17);
            this.lblKayit.TabIndex = 6;
            this.lblKayit.Text = "Yeni Kayit Var";
            this.lblKayit.Click += new System.EventHandler(this.lblKayit_Click);
            // 
            // FrmAdminPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NesneProje.Properties.Resources.unnamed;
            this.ClientSize = new System.Drawing.Size(426, 288);
            this.Controls.Add(this.lblKayit);
            this.Controls.Add(this.btnCalisanEkle);
            this.Controls.Add(this.btnMarketler);
            this.Controls.Add(this.btnTedarikciler);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAdminPanel";
            this.Text = "Yönetici";
            this.Load += new System.EventHandler(this.FrmAdminPanel_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTedarikciler;
        private System.Windows.Forms.Button btnMarketler;
        private System.Windows.Forms.Button btnCalisanEkle;
        private System.Windows.Forms.Label lblKayit;
    }
}