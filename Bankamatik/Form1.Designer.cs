﻿namespace Bankamatik
{
    partial class Form1
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
            this.mskHesapNo = new System.Windows.Forms.MaskedTextBox();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.btnGiris = new System.Windows.Forms.Button();
            this.lnkKayitOl = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hesap No:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Şifre:";
            // 
            // mskHesapNo
            // 
            this.mskHesapNo.Location = new System.Drawing.Point(130, 39);
            this.mskHesapNo.Mask = "000000";
            this.mskHesapNo.Name = "mskHesapNo";
            this.mskHesapNo.Size = new System.Drawing.Size(100, 26);
            this.mskHesapNo.TabIndex = 2;
            this.mskHesapNo.ValidatingType = typeof(int);
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(130, 76);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.Size = new System.Drawing.Size(100, 26);
            this.txtSifre.TabIndex = 3;
            // 
            // btnGiris
            // 
            this.btnGiris.Location = new System.Drawing.Point(55, 120);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(100, 29);
            this.btnGiris.TabIndex = 4;
            this.btnGiris.Text = "GİRİŞ YAP";
            this.btnGiris.UseVisualStyleBackColor = true;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // lnkKayitOl
            // 
            this.lnkKayitOl.AutoSize = true;
            this.lnkKayitOl.Location = new System.Drawing.Point(168, 124);
            this.lnkKayitOl.Name = "lnkKayitOl";
            this.lnkKayitOl.Size = new System.Drawing.Size(62, 20);
            this.lnkKayitOl.TabIndex = 5;
            this.lnkKayitOl.TabStop = true;
            this.lnkKayitOl.Text = "Kayıt Ol";
            this.lnkKayitOl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKayitOl_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(290, 176);
            this.Controls.Add(this.lnkKayitOl);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.mskHesapNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox mskHesapNo;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.LinkLabel lnkKayitOl;
    }
}

