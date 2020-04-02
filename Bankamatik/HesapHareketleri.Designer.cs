namespace Bankamatik
{
    partial class HesapHareketleri
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
            this.dgvHareketler = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvHareketler
            // 
            this.dgvHareketler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvHareketler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvHareketler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvHareketler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvHareketler.Location = new System.Drawing.Point(0, 0);
            this.dgvHareketler.Name = "dgvHareketler";
            this.dgvHareketler.Size = new System.Drawing.Size(467, 249);
            this.dgvHareketler.TabIndex = 0;
            // 
            // HesapHareketleri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 249);
            this.Controls.Add(this.dgvHareketler);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "HesapHareketleri";
            this.Text = "HesapHareketleri";
            this.Load += new System.EventHandler(this.HesapHareketleri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvHareketler)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvHareketler;
    }
}