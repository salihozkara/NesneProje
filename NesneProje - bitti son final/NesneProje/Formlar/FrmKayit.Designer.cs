
namespace NesneProje
{
    partial class FrmKayit
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
            this.label3 = new System.Windows.Forms.Label();
            this.textAd = new System.Windows.Forms.TextBox();
            this.textAdres = new System.Windows.Forms.TextBox();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.cmbPozisyon = new System.Windows.Forms.ComboBox();
            this.textMaas = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbMarket = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblmesaj = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(72, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 15;
            this.label1.Text = "Ad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(72, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 14;
            this.label3.Text = "Adres";
            // 
            // textAd
            // 
            this.textAd.Location = new System.Drawing.Point(161, 35);
            this.textAd.Name = "textAd";
            this.textAd.Size = new System.Drawing.Size(100, 22);
            this.textAd.TabIndex = 1;
            // 
            // textAdres
            // 
            this.textAdres.Location = new System.Drawing.Point(161, 84);
            this.textAdres.Name = "textAdres";
            this.textAdres.Size = new System.Drawing.Size(100, 22);
            this.textAdres.TabIndex = 2;
            // 
            // btnKayıt
            // 
            this.btnKayıt.Location = new System.Drawing.Point(171, 287);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(75, 29);
            this.btnKayıt.TabIndex = 6;
            this.btnKayıt.Text = "Kayıt Et";
            this.btnKayıt.UseVisualStyleBackColor = true;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // cmbPozisyon
            // 
            this.cmbPozisyon.FormattingEnabled = true;
            this.cmbPozisyon.Items.AddRange(new object[] {
            "Kasiyer",
            "Müdür Yardımcısı",
            "Müdür"});
            this.cmbPozisyon.Location = new System.Drawing.Point(161, 143);
            this.cmbPozisyon.Name = "cmbPozisyon";
            this.cmbPozisyon.Size = new System.Drawing.Size(100, 24);
            this.cmbPozisyon.TabIndex = 3;
            // 
            // textMaas
            // 
            this.textMaas.Location = new System.Drawing.Point(161, 201);
            this.textMaas.Name = "textMaas";
            this.textMaas.Size = new System.Drawing.Size(100, 22);
            this.textMaas.TabIndex = 4;
            this.textMaas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textMaas_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Location = new System.Drawing.Point(72, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Pozisyon";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Location = new System.Drawing.Point(72, 206);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Maaş";
            // 
            // cmbMarket
            // 
            this.cmbMarket.FormattingEnabled = true;
            this.cmbMarket.Location = new System.Drawing.Point(161, 244);
            this.cmbMarket.Name = "cmbMarket";
            this.cmbMarket.Size = new System.Drawing.Size(100, 24);
            this.cmbMarket.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Location = new System.Drawing.Point(72, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 12;
            this.label6.Text = "Market";
            // 
            // lblmesaj
            // 
            this.lblmesaj.AutoSize = true;
            this.lblmesaj.Location = new System.Drawing.Point(126, 329);
            this.lblmesaj.Name = "lblmesaj";
            this.lblmesaj.Size = new System.Drawing.Size(155, 17);
            this.lblmesaj.TabIndex = 13;
            this.lblmesaj.Text = "Reddetmek için kapatın";
            this.lblmesaj.Visible = false;
            // 
            // FrmKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NesneProje.Properties.Resources.unnamed;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(384, 364);
            this.Controls.Add(this.lblmesaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cmbMarket);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textMaas);
            this.Controls.Add(this.cmbPozisyon);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.textAdres);
            this.Controls.Add(this.textAd);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "FrmKayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayıt";
            this.Load += new System.EventHandler(this.FrmKayit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textAd;
        private System.Windows.Forms.TextBox textAdres;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.ComboBox cmbPozisyon;
        private System.Windows.Forms.TextBox textMaas;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbMarket;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblmesaj;
    }
}