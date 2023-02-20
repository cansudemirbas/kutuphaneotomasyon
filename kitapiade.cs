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
    public partial class kitapiade : Form
    {
        public kitapiade()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CANSU;Initial Catalog=canskutuphane;Integrated Security=True");
        DataSet daset = new DataSet();
        private void oduncverilenkitap()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from oduncverilenKitap", baglanti);
            adtr.Fill(daset, "oduncverilenkitap");
            dataGridView2.DataSource = daset.Tables["oduncverilenkitap"];
            baglanti.Close();
        }
            private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kitapiade_Load(object sender, EventArgs e)
        {
            oduncverilenkitap();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["oduncverilenKitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from oduncverilenKitap where barkodno like '%" + txtbarkodara .Text + "%'", baglanti);
            adtr.Fill(daset, "oduncverilenKitap");
            baglanti.Close();
            if (txtbarkodara.Text == "")
            {
                daset.Tables["oduncverilenKitap"].Clear();
                oduncverilenkitap();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtTcara_TextChanged(object sender, EventArgs e)
        {
            daset.Tables["oduncverilenKitap"].Clear();
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select *from oduncverilenKitap where tc like '%" + txtTcara.Text + "%'", baglanti);
            adtr.Fill(daset,"oduncverilenKitap");
            baglanti.Close();
            if (txtTcara.Text=="")
            {
                daset.Tables["oduncverilenKitap"].Clear();
                oduncverilenkitap();

            }



        }

        private void ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from oduncverilenKitap where tc=@tc and barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@tc",dataGridView2.CurrentRow.Cells["tc"].Value.ToString());
            komut.Parameters.AddWithValue("@barkodno", dataGridView2.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
           
            MessageBox.Show("Kitap İade Edildi");
            baglanti.Close();
            daset.Tables["oduncverilenKitap"].Clear();
            oduncverilenkitap();

        }
    }
}
