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
    public partial class kitapsilmeformu : Form
    {
        public kitapsilmeformu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=CANSU;Initial Catalog=canskutuphane;Integrated Security=True");


        SqlConnection c;
        SqlDataAdapter e;
        DataSet dase;


        private void kitaplistelemegrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void doldur1()
        {
            c = new SqlConnection("Server=localhost;Database=canskutuphane;Trusted_Connection=True; ");
            e = new SqlDataAdapter("Select * From Kitap", c);
            dase = new DataSet();
            c.Open();
            e.Fill(dase, "Kitap");
            kitaplistelemegrid.DataSource = dase.Tables["Kitap"];
            c.Close();
        }

        DataSet daset = new DataSet();

        private void arakitap_TextChanged(object sender, EventArgs e)
        {

            if (barkodaratxt.Text.Length == 5)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select * from Kitap where barkod_no like '%" + barkodaratxt.Text + "%'", baglanti);
                adtr.Fill(daset, "Kitap");
                kitaplistelemegrid.DataSource = daset.Tables["Kitap"];
                baglanti.Close();
                // daset.Tables["Kitap"].Clear();
            }


        }
        private void barkodara_Click(object sender, EventArgs e)
        {
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Kitap where barkod_no=@barkod_no", baglanti);
                komut.Parameters.AddWithValue("@barkod_no", kitaplistelemegrid.CurrentRow.Cells["barkod_no"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi..");

                doldur1();
            }
        }
        private void kitapsilmeformu_Load(object sender, EventArgs e)
        {
            doldur1();
        }

        private void iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void silmebutonu_Click(object sender, EventArgs e)
        {
            {
                baglanti.Open();
                SqlCommand komut = new SqlCommand("delete from Kitap where barkod_no=@barkod_no", baglanti);
                komut.Parameters.AddWithValue("@barkod_no", kitaplistelemegrid.CurrentRow.Cells["barkod_no"].Value.ToString());
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Kayıt Silindi..");

                doldur1();
            }
        }
    }
}
