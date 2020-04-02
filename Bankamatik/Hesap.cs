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
    public partial class Hesap : Form
    {
        public Hesap()
        {
            InitializeComponent();
        }

        public string hesap;

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DbBankamatik;Integrated Security=True");
        private void Hesap_Load(object sender, EventArgs e)
        {
            lblHesapNo.Text = hesap;
            con.Open();
            SqlCommand cmd = new SqlCommand("select * from tblKisiler where HesapNo=" + hesap, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[1] + " " + dr[2];
                lblHesapNo.Text = dr[5].ToString();
                lblTcKimlik.Text = dr[3].ToString();
                lblTelefon.Text = dr[4].ToString();

            }
            con.Close();
            BakiyeyiCek();
        }

        private void BakiyeyiCek()
        {
            con.Open();
            SqlCommand cmd1 = new SqlCommand("select Bakiye from tblHesaplar where HesapNo=" + lblHesapNo.Text, con);
            SqlDataReader dr1 = cmd1.ExecuteReader();
            if (dr1.Read())
            {
                txtBakiye.Text = dr1[0].ToString();
            }

            con.Close();
        }
        bool gerceklestiMi = false;
        bool tetiklensinMi = false;
        private void btnGonder_Click(object sender, EventArgs e)
        {
            gerceklestiMi = false;
            tetiklensinMi = true;
            con.Open();
            SqlCommand cmd = new SqlCommand(
                "Begin tran; " +
                "begin try " +
                "update tblHesaplar set Bakiye=Bakiye-@p1 where HesapNo=@p2;" +
                "update tblHesaplar set Bakiye=Bakiye+@p1 where HesapNo=@p3;" +
                "Commit;" +
                "end try " +
                "begin catch " +
                "rollback;" +
                "end catch", con);
            cmd.Parameters.AddWithValue("@p1", txtTutar.Text);
            cmd.Parameters.AddWithValue("@p2", lblHesapNo.Text);
            cmd.Parameters.AddWithValue("@p3", mskHesapNo.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            BakiyeyiCek();
            if (!gerceklestiMi)
            {
                MessageBox.Show("Yetersiz bakiye,İşleminiz gerçekleştirilemedi");
            }
            else
            {
                con.Open();
                SqlCommand cmd1 = new SqlCommand("insert into tblHareketler (Gonderen,Alici,Tutar) values(@p1,@p2,@p3) ", con);
                cmd1.Parameters.AddWithValue("@p1", lblHesapNo.Text);
                cmd1.Parameters.AddWithValue("@p2", mskHesapNo.Text);
                cmd1.Parameters.AddWithValue("@p3", Convert.ToDecimal(txtTutar.Text));
                cmd1.ExecuteNonQuery();
                con.Close();

                txtTutar.Clear();
                mskHesapNo.Clear();
            }
        }

        private void txtBakiye_TextChanged_1(object sender, EventArgs e)
        {
            if (tetiklensinMi)
            {
                gerceklestiMi = true;
                MessageBox.Show("İşleminiz başarıyla gerçekleşmiştir.");
            }
        }

        private void btnYukle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("update tblHesaplar set Bakiye = bakiye+@p1 where HesapNo=" + lblHesapNo.Text, con);
            cmd.Parameters.AddWithValue("@p1", txtYukleTutar.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            BakiyeyiCek();
            MessageBox.Show("İşleminiz başarıyla gerçekleşmiştir.");
            txtYukleTutar.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            HesapHareketleri frm = new HesapHareketleri();
            frm.Show();
        }
    }
}
