namespace Bankamatik
{
    partial class Hesap
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblHesapNo = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTcKimlik = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.mskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.btnGonder = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBakiye = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnYukle = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtYukleTutar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hesap No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Telefon:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "TC Kimlik:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(106, 18);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(35, 20);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = "Null";
            // 
            // lblHesapNo
            // 
            this.lblHesapNo.AutoSize = true;
            this.lblHesapNo.Location = new System.Drawing.Point(106, 51);
            this.lblHesapNo.Name = "lblHesapNo";
            this.lblHesapNo.Size = new System.Drawing.Size(35, 20);
            this.lblHesapNo.TabIndex = 5;
            this.lblHesapNo.Text = "Null";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(106, 83);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(35, 20);
            this.lblTelefon.TabIndex = 6;
            this.lblTelefon.Text = "Null";
            // 
            // lblTcKimlik
            // 
            this.lblTcKimlik.AutoSize = true;
            this.lblTcKimlik.Location = new System.Drawing.Point(106, 119);
            this.lblTcKimlik.Name = "lblTcKimlik";
            this.lblTcKimlik.Size = new System.Drawing.Size(35, 20);
            this.lblTcKimlik.TabIndex = 7;
            this.lblTcKimlik.Text = "Null";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnGonder);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.txtTutar);
            this.groupBox1.Controls.Add(this.mskHesapNo);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 187);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(218, 183);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Havale";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(4, 43);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 20);
            this.label9.TabIndex = 9;
            this.label9.Text = "Hesap No:";
            // 
            // mskHesapNo
            // 
            this.mskHesapNo.Location = new System.Drawing.Point(94, 37);
            this.mskHesapNo.Mask = "000000";
            this.mskHesapNo.Name = "mskHesapNo";
            this.mskHesapNo.Size = new System.Drawing.Size(100, 26);
            this.mskHesapNo.TabIndex = 10;
            this.mskHesapNo.ValidatingType = typeof(int);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(94, 78);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(100, 26);
            this.txtTutar.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 81);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 20);
            this.label10.TabIndex = 12;
            this.label10.Text = "Tutar:";
            // 
            // btnGonder
            // 
            this.btnGonder.Location = new System.Drawing.Point(94, 110);
            this.btnGonder.Name = "btnGonder";
            this.btnGonder.Size = new System.Drawing.Size(100, 29);
            this.btnGonder.TabIndex = 13;
            this.btnGonder.Text = "GÖNDER";
            this.btnGonder.UseVisualStyleBackColor = true;
            this.btnGonder.Click += new System.EventHandler(this.btnGonder_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(258, 138);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Bakiye:";
            // 
            // txtBakiye
            // 
            this.txtBakiye.ForeColor = System.Drawing.Color.Red;
            this.txtBakiye.Location = new System.Drawing.Point(324, 135);
            this.txtBakiye.Name = "txtBakiye";
            this.txtBakiye.ReadOnly = true;
            this.txtBakiye.Size = new System.Drawing.Size(90, 26);
            this.txtBakiye.TabIndex = 14;
            this.txtBakiye.TextChanged += new System.EventHandler(this.txtBakiye_TextChanged_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnYukle);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txtYukleTutar);
            this.groupBox2.Location = new System.Drawing.Point(236, 187);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(218, 183);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Para Yükle";
            // 
            // btnYukle
            // 
            this.btnYukle.Location = new System.Drawing.Point(78, 75);
            this.btnYukle.Name = "btnYukle";
            this.btnYukle.Size = new System.Drawing.Size(100, 29);
            this.btnYukle.TabIndex = 13;
            this.btnYukle.Text = "YÜKLE";
            this.btnYukle.UseVisualStyleBackColor = true;
            this.btnYukle.Click += new System.EventHandler(this.btnYukle_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tutar:";
            // 
            // txtYukleTutar
            // 
            this.txtYukleTutar.Location = new System.Drawing.Point(78, 43);
            this.txtYukleTutar.Name = "txtYukleTutar";
            this.txtYukleTutar.Size = new System.Drawing.Size(100, 26);
            this.txtYukleTutar.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 46);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 57);
            this.button1.TabIndex = 16;
            this.button1.Text = "Hesap Hareketleri";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Hesap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 373);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtBakiye);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTcKimlik);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblHesapNo);
            this.Controls.Add(this.lblAdSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Hesap";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hesap";
            this.Load += new System.EventHandler(this.Hesap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblHesapNo;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblTcKimlik;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox mskHesapNo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Button btnGonder;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBakiye;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnYukle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtYukleTutar;
        private System.Windows.Forms.Button button1;
    }
}