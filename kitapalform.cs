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
    public partial class kitapalform : Form
    {
        public kitapalform()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CANSU;Initial Catalog=canskutuphane;Integrated Security=True");
        DataSet daset = new DataSet();
           private void kitapalform_Load(object sender, EventArgs e)
        {
            sepetlistele();
        }
         private void kitapsayisi()
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select sum(kitapsayisi) from sepet ", baglanti);
            kitapsayisiyazdirlbl.Text = komut.ExecuteScalar().ToString();
            baglanti.Close();
        }
        
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e) 
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void sepetlistele()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select * from sepet",baglanti);
            adtr.Fill(daset,"sepet");
            dataGridView1.DataSource = daset.Tables["sepet"];
            baglanti.Close();

        }


        private void kitapekle_Click(object sender, EventArgs e)
        {
           
        }

        private void barkodtxt_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from Kitap where barkod_no like '" + barkodnotxt.Text + "'", baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                ktpadd.Text = read["kitap_ad"].ToString();
               
            }
            baglanti.Close();
            if(barkodnotxt.Text=="")
            {
                foreach (Control item in groupBox1.Controls)
                {
                    if (item is TextBox)
                    {
                        if (item != txtkitapsayisi)
                        {
                            item.Text = "";
                        }

                    }
                }
           

            }


        }

        private void txttc_TextChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select *from uyeler where uye_tc like '" + txttc.Text + "'",baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while(read.Read())
            {
                txtad.Text = read["uye_adi"].ToString();
                txtsoyad.Text = read["uye_soyadi"].ToString();
                txtodano.Text = read["oda_no"].ToString();
                telnotxt.Text = read["tel_no"].ToString();
            }
            baglanti.Close();


            baglanti.Open();
            SqlCommand komut2 = new SqlCommand("select sum(kitapsayisi) from oduncverilenKitap",baglanti);
            kitapsayisiyazdirlbl.Text = komut2.ExecuteScalar().ToString();
            baglanti.Close();

            if (txttc.Text == "")
            {
                foreach(Control item in groupBox1.Controls )
                    
                    {
                    if(item is TextBox)
                    {
                        item.Text = "";
                        kitapsayisiyazdirlbl.Text = "";
                    }



                }

                     
            }


        }

        private void lblktpsayisi_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
         
        }

        private void lblkayitliktp_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (kitapsayisiyazdirlbl.Text != "")
                {
                if(kayitlikitaplbl.Text=="" && int.Parse(kitapsayisiyazdirlbl.Text)<=3  || kayitlikitaplbl.Text!="" && int.Parse(kayitlikitaplbl.Text )+ int.Parse(kitapsayisiyazdirlbl.Text)<=3)

                {
                    if(txttc.Text!="" && txtad.Text!= "" && txtsoyad.Text!="" && txtodano.Text!="" && telnotxt.Text!="")
                 
                    {


                        for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                        {
                            baglanti.Open();
                            SqlCommand komut5 = new SqlCommand("insert into oduncverilenKitap (tc,ad,soyad,oda_no,tel_no,barkodno,kitabinadi,kitapsayisi,teslimvermetarihi,teslimalmatarihi) values(@tc,@ad,@soyad,@oda_no,@tel_no,@barkodno,@kitabinadi,@kitapsayisi,@teslimvermetarihi,@teslimalmatarihi)", baglanti);
                            komut5.Parameters.AddWithValue("tc",txttc.Text);
                            komut5.Parameters.AddWithValue("ad", txtad.Text);
                            komut5.Parameters.AddWithValue("soyad", txtsoyad.Text);
                            komut5.Parameters.AddWithValue("oda_no", txtodano.Text);
                            komut5.Parameters.AddWithValue("tel_no", telnotxt.Text);
                            komut5.Parameters.AddWithValue("barkodno", dataGridView1.Rows[i].Cells["barkodno"].Value.ToString());
                            komut5.Parameters.AddWithValue("kitabinadi", dataGridView1.Rows[i].Cells["kitabinadi"].Value.ToString());
                            komut5.Parameters.AddWithValue("kitapsayisi", int.Parse(dataGridView1.Rows[i].Cells["kitapsayisi"].Value.ToString()));
                            komut5.Parameters.AddWithValue("teslimvermetarihi", dataGridView1.Rows[i].Cells["teslimvermetarihi"].Value.ToString());
                            komut5.Parameters.AddWithValue("teslimalmatarihi", dataGridView1.Rows[i].Cells["teslimalmatarihi"].Value.ToString());
                            komut5.ExecuteNonQuery();
                            baglanti.Close();

                        }
                        baglanti.Open();

                        SqlCommand komut4 = new SqlCommand("delete from sepet", baglanti); komut4.ExecuteNonQuery();

                        baglanti.Close();
                        

                        MessageBox.Show("Kitap (lar) emanet edildi");
                        daset.Tables["sepet"].Clear();
                        sepetlistele();

                        txttc.Text = "";

                        kitapsayisiyazdirlbl.Text = "";

                        kitapsayisi();
                        kayitlikitaplbl.Text = "";

                        

                    }
                    else
                    {
                        MessageBox.Show("önce üye ismi seçmeniz gerekir");


                    }
                   
                    }
                else
                {
                    MessageBox.Show("Eemanet kitap sayısı 3'ten fazla olamaz..");

                }
                }
            
            else {
                MessageBox.Show("önce sepete kitap eklenmelidir.");
                  }
           
        }

        private void ekle_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into sepet(barkodno,kitabinadi,kitapsayisi,teslimvermetarihi,teslimalmatarihi) values(@barkodno,@kitabinadi,@kitapsayisi,@teslimvermetarihi,@teslimalmatarihi) ", baglanti);
            komut.Parameters.AddWithValue("@barkodno", barkodnotxt.Text);
            komut.Parameters.AddWithValue("@kitabinadi", ktpadd.Text);
            komut.Parameters.AddWithValue("@kitapsayisi", int.Parse(txtkitapsayisi.Text));
            komut.Parameters.AddWithValue("@teslimvermetarihi", dateTimePicker1.Text);
            komut.Parameters.AddWithValue("@teslimalmatarihi", dateTimePicker2.Text);
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Kitap Sepete Eklendi..","Ekleme İşlemi");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            kitapsayisiyazdirlbl.Text = "";
            kitapsayisi();



            foreach (Control item in groupBox2.Controls) 
            {

                if (item is TextBox)
                {
                    if (item!= txtkitapsayisi) 
                    
                    { 
                        item.Text = ""; 
                    }
                   
                }
            }
        }

        private void telnotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void sil_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from sepet where barkodno=@barkodno", baglanti);
            komut.Parameters.AddWithValue("@barkodno", dataGridView1.CurrentRow.Cells["barkodno"].Value.ToString());
            komut.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("SİLME İŞLEMİ YAPILDI");
            daset.Tables["sepet"].Clear();
            sepetlistele();
            kitapsayisiyazdirlbl.Text = "";
            kitapsayisi();
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
    }

