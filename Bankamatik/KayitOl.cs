using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Bankamatik
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DbBankamatik;Integrated Security=True");

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into tblKisiler (Ad,Soyad,TcKimlik,Telefon,HesapNo,Sifre) values(@p1,@p2,@p3,@p4,@p5,@p6)", con);
            cmd.Parameters.AddWithValue("@p1", txtAd.Text);
            cmd.Parameters.AddWithValue("@p2", txtSoyad.Text);
            cmd.Parameters.AddWithValue("@p3", mskTCKimlik.Text);
            cmd.Parameters.AddWithValue("@p4", mskTelefon.Text);
            cmd.Parameters.AddWithValue("@p5", mskHesap.Text);
            cmd.Parameters.AddWithValue("@p6", txtSifre.Text);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Müşteri Bilgileri Sisteme Kaydedildi.");
            txtAd.Clear();
            txtSifre.Clear();
            txtSoyad.Clear();
            mskHesap.Clear();
            mskTCKimlik.Clear();
            mskTelefon.Clear();

        }

        private void btnNokta_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int hesapNo = rand.Next(100000, 1000000);
            List<int> hesaplar = new List<int>();
            con.Open();
            SqlCommand cmd = new SqlCommand("select HesapNo from tblKisiler", con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                hesaplar.Add(Convert.ToInt32(dr[0]));
            }
            con.Close();
            if (!hesaplar.Contains(hesapNo))
                mskHesap.Text = hesapNo.ToString();
            else
                hesapNo= rand.Next(100000, 1000000);


        }
    }
}
