using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace cansukutuphaneotomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection con;
        SqlDataAdapter da;
        DataSet ds;
        void griddoldur()
        {
            con = new SqlConnection("Server=localhost;Database=canskutuphane;Trusted_Connection=True; ");
            da = new SqlDataAdapter("Select * From Kitap", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kitap");
            kitaplik.DataSource = ds.Tables["Kitap"];
            con.Close();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            griddoldur();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            uyelisteleme uyeliste = new uyelisteleme();
            uyeliste.ShowDialog();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {
            kitapeklemeformu kitapekle = new kitapeklemeformu();
            kitapekle.ShowDialog();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            uyekaydi uye = new  uyekaydi();
            uye.ShowDialog();
           
        }

        private void kitapsil_Click(object sender, EventArgs e)
        {
            kitapsilmeformu kitapsil = new kitapsilmeformu();
            kitapsil.ShowDialog();
        }

        private void kitapal_Click(object sender, EventArgs e)
        {
            kitapalform emanetkitapal = new kitapalform();
            emanetkitapal.ShowDialog();

        }

        private void kitapiade_Click(object sender, EventArgs e)
        {
            kitapiade kitapiade = new kitapiade();
            kitapiade.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
             emanetkitaplistele kitaplist = new emanetkitaplistele();
            kitaplist.ShowDialog();
        }
    }
}
