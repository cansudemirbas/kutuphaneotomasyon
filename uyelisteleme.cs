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

namespace cansukutuphaneotomasyonu
{
    public partial class uyelisteleme : Form
    {
        public uyelisteleme()
        {
            InitializeComponent();
        }
       
        SqlConnection baglanti = new SqlConnection("Data Source=CANSU;Initial Catalog=canskutuphane;Integrated Security=True");


        SqlConnection a;
        SqlDataAdapter b;
        DataSet das;
        private void uyelistelemegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }
       
        public void doldur()
        {
            a = new SqlConnection("Server=localhost;Database=canskutuphane;Trusted_Connection=True; ");
            b = new SqlDataAdapter("Select * From uyeler", a);
            das = new DataSet();
            a.Open();
            b.Fill(das, "uyeler");
            uyelistelemegrid.DataSource = das.Tables["uyeler"];
            a.Close();
        }
      
        DataSet daset = new DataSet();

        private void arama_TextChanged(object sender, EventArgs e)
        {

            if(aramatc.TextLength==11)
            {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from uyeler where uye_tc like '%" + aramatc.Text + "%'", baglanti);
            adtr.Fill(daset, "uyeler");
            uyelistelemegrid.DataSource = daset.Tables["uyeler"];
            baglanti.Close();
        
            }
          

        }

        private void iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void silmebutonu_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from uyeler where uye_tc=@uye_tc", baglanti);
            komut.Parameters.AddWithValue("@uye_tc", uyelistelemegrid.CurrentRow.Cells["uye_tc"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kayıt Silindi..");

            doldur();
        }

      
        private void uyelisteleme_Load(object sender, EventArgs e)
        {
            doldur();
        }
    }
}
