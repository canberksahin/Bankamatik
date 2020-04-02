namespace Bankamatik
{
    partial class KayitOl
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
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.mskTCKimlik = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.mskTelefon = new System.Windows.Forms.MaskedTextBox();
            this.mskHesap = new System.Windows.Forms.MaskedTextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnNokta = new System.Windows.Forms.Button();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "TC Kimlik:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hesap No:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Ad:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Şifre:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(100, 17);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(133, 26);
            this.txtAd.TabIndex = 0;
            // 
            // mskTCKimlik
            // 
            this.mskTCKimlik.Location = new System.Drawing.Point(100, 145);
            this.mskTCKimlik.Mask = "00000000000";
            this.mskTCKimlik.Name = "mskTCKimlik";
            this.mskTCKimlik.Size = new System.Drawing.Size(133, 26);
            this.mskTCKimlik.TabIndex = 4;
            this.mskTCKimlik.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(100, 178);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(133, 26);
            this.txtSifre.TabIndex = 5;
            // 
            // mskTelefon
            // 
            this.mskTelefon.Location = new System.Drawing.Point(100, 112);
            this.mskTelefon.Mask = "(999) 000-0000";
            this.mskTelefon.Name = "mskTelefon";
            this.mskTelefon.Size = new System.Drawing.Size(133, 26);
            this.mskTelefon.TabIndex = 3;
            // 
            // mskHesap
            // 
            this.mskHesap.Location = new System.Drawing.Point(100, 80);
            this.mskHesap.Mask = "000000";
            this.mskHesap.Name = "mskHesap";
            this.mskHesap.Size = new System.Drawing.Size(133, 26);
            this.mskHesap.TabIndex = 2;
            this.mskHesap.ValidatingType = typeof(int);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(100, 215);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(133, 26);
            this.btnKaydet.TabIndex = 6;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnNokta
            // 
            this.btnNokta.Location = new System.Drawing.Point(239, 80);
            this.btnNokta.Name = "btnNokta";
            this.btnNokta.Size = new System.Drawing.Size(37, 26);
            this.btnNokta.TabIndex = 17;
            this.btnNokta.Text = "...";
            this.btnNokta.UseVisualStyleBackColor = true;
            this.btnNokta.Click += new System.EventHandler(this.btnNokta_Click);
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(100, 48);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(133, 26);
            this.txtSoyad.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 20);
            this.label6.TabIndex = 18;
            this.label6.Text = "Soyad:";
            // 
            // KayitOl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 268);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnNokta);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.mskHesap);
            this.Controls.Add(this.mskTelefon);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.mskTCKimlik);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "KayitOl";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayit Ol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.MaskedTextBox mskTCKimlik;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.MaskedTextBox mskTelefon;
        private System.Windows.Forms.MaskedTextBox mskHesap;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnNokta;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label label6;
    }
}