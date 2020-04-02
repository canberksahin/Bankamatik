using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankamatik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DbBankamatik;Integrated Security=True");
        private void lnkKayitOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            KayitOl frm = new KayitOl();
            frm.Show();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblKisiler where HesapNo=@p1 and Sifre=@p2",con);
            cmd.Parameters.AddWithValue("@p1",mskHesapNo.Text);
            cmd.Parameters.AddWithValue("@p2",txtSifre.Text);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                Hesap hsp = new Hesap();
                hsp.hesap = mskHesapNo.Text;
                hsp.Show();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            con.Close();
        }
    }
}
