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
    public partial class HesapHareketleri : Form
    {
        public HesapHareketleri()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=.;Initial Catalog=DbBankamatik;Integrated Security=True");

        private void HesapHareketleri_Load(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("select k1.Ad+' '+k1.Soyad as Gönderen ,k.Ad+' '+k.Soyad as Alici,Tutar from tblHareketler h inner join tblKisiler k on h.Alici=k.HesapNo join tblKisiler k1 on k1.HesapNo=h.Gonderen ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dgvHareketler.DataSource = dt;

        }
    }
}
