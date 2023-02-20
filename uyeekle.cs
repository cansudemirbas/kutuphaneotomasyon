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

namespace cansukutuphaneotomasyonu
{
    public partial class uyekaydi : Form
    {
        public uyekaydi()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=CANSU;Initial Catalog=canskutuphane;Integrated Security=True");
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
           
            SqlCommand komut3 = new SqlCommand("insert into uyeler(uye_tc, uye_adi, uye_soyadi, oda_no, tel_no, e_mail) values(@uye_tc, @uye_adi, @uye_soyadi, @oda_no, @tel_no, @e_mail)", baglanti);
            baglanti.Open();
            if(txttc.Text.Length==11)
            {
            komut3.Parameters.AddWithValue("@uye_tc", txttc.Text);
            komut3.Parameters.AddWithValue("@uye_adi", txtad.Text);
            komut3.Parameters.AddWithValue("@uye_soyadi", txtsoyad.Text);
            komut3.Parameters.AddWithValue("@oda_no", txtodano.Text);
            komut3.Parameters.AddWithValue("@tel_no", txttel.Text);
            komut3.Parameters.AddWithValue("@e_mail", txtmail.Text);
           
            komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Üye kayıt edildi..");
            }
            else
            {
                MessageBox.Show("Tc 11 Hane Olmak Zorunda");
            }
          
        

            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                  
                    item.Text = " ";
                }
            }
        }

        private void uyekaydi_Load(object sender, EventArgs e)
        {

        }

        private void txtodano_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
