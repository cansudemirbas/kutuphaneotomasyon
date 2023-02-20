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
    public partial class kitapeklemeformu : Form
    {
        public kitapeklemeformu()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=CANSU;Initial Catalog=canskutuphane;Integrated Security=True");
        private void kitapeklemeformu_Load(object sender, EventArgs e)
        {

        }

        private void iptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kitapekle_Click(object sender, EventArgs e)
        {
           
                SqlCommand komut1 = new SqlCommand("insert into Kitap(barkod_no,kitap_ad, kitap_yazari, basim_yili, yayimevi, sayfa_sayisi, kitap_turu,stoksayisi) values(@barkod_no,@kitap_ad, @kitap_yazari, @basim_yili, @yayimevi, @sayfa_sayisi, @kitap_turu,@stoksayisi)", baglanti);
                baglanti.Open();
              if (barkodtxt.Text.Length == 5)
            { 
                komut1.Parameters.AddWithValue("@barkod_no", barkodtxt.Text);
                komut1.Parameters.AddWithValue("@kitap_ad", ktpad.Text);
                komut1.Parameters.AddWithValue("@kitap_yazari", ktpyazar.Text);
                komut1.Parameters.AddWithValue("@basim_yili", bsmyili.Text);
                komut1.Parameters.AddWithValue("@yayimevi", yayimevi.Text);
                komut1.Parameters.AddWithValue("@sayfa_sayisi", sayfasayisi.Text);
                komut1.Parameters.AddWithValue("@kitap_turu", ktptur.Text);
                komut1.Parameters.AddWithValue("@stoksayisi", stoksayisitxt.Text);
                komut1.ExecuteNonQuery();
               
                baglanti.Close();
            MessageBox.Show("Kitap kayıt edildi..");
            }

            else
            {
                MessageBox.Show("Barkod 5 Haneli Olmak Zorunda");
            }

            foreach (Control item in Controls)
                {
                    if (item is TextBox)
                    {

                        item.Text = " ";
                    }
                }

        
          
        }

        private void barkodtxt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
   


