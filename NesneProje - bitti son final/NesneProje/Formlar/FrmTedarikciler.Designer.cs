
namespace NesneProje.Formlar
{
    partial class FrmTedarikciler
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
            this.listViewTedarikcs = new System.Windows.Forms.ListView();
            this.columnHeaderGrup = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeaderAdres = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewTedarikcs
            // 
            this.listViewTedarikcs.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.listViewTedarikcs.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeaderGrup,
            this.columnHeaderAdres});
            this.listViewTedarikcs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTedarikcs.HideSelection = false;
            this.listViewTedarikcs.Location = new System.Drawing.Point(0, 0);
            this.listViewTedarikcs.Name = "listViewTedarikcs";
            this.listViewTedarikcs.Size = new System.Drawing.Size(592, 472);
            this.listViewTedarikcs.TabIndex = 0;
            this.listViewTedarikcs.UseCompatibleStateImageBehavior = false;
            this.listViewTedarikcs.View = System.Windows.Forms.View.Details;
            // 
            // columnHeaderGrup
            // 
            this.columnHeaderGrup.Text = "Grup";
            this.columnHeaderGrup.Width = 156;
            // 
            // columnHeaderAdres
            // 
            this.columnHeaderAdres.Text = "Adres";
            this.columnHeaderAdres.Width = 422;
            // 
            // FrmTedarikciler
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(592, 472);
            this.Controls.Add(this.listViewTedarikcs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmTedarikciler";
            this.Text = "Tedarikciler";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewTedarikcs;
        private System.Windows.Forms.ColumnHeader columnHeaderGrup;
        private System.Windows.Forms.ColumnHeader columnHeaderAdres;
    }
}