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
    public partial class emanetkitaplistele : Form
    {
        public emanetkitaplistele()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=CANSU;Initial Catalog=canskutuphane;Integrated Security=True");
        DataSet daset = new DataSet();
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void emanetkitaplistele_Load(object sender, EventArgs e)
        {
            oduncverilenkitap();
            comboBox1.SelectedIndex = 0;
        }

        private void oduncverilenkitap()
        {
            baglanti.Open();
            SqlDataAdapter adtr = new SqlDataAdapter("select*from oduncverilenKitap", baglanti);
            adtr.Fill(daset, "oduncverilenkitap");
            dataGridView1.DataSource = daset.Tables["oduncverilenkitap"];
            baglanti.Close();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            daset.Tables["oduncverilenKitap"].Clear();
            if (comboBox1.SelectedIndex== 0)
                {
                oduncverilenkitap();
            }
            else if (comboBox1.SelectedIndex==1)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select*from oduncverilenKitap where '"+DateTime.Now.ToShortDateString()+"'>teslimalmatarihi", baglanti);
                adtr.Fill(daset, "oduncverilenkitap");
                dataGridView1.DataSource = daset.Tables["oduncverilenkitap"];
                baglanti.Close();
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                baglanti.Open();
                SqlDataAdapter adtr = new SqlDataAdapter("select*from oduncverilenKitap where '" + DateTime.Now.ToShortDateString() + "'<=teslimalmatarihi", baglanti);
                adtr.Fill(daset, "oduncverilenkitap");
                dataGridView1.DataSource = daset.Tables["oduncverilenkitap"];
                baglanti.Close();
            }
        }
    }
}