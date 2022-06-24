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

namespace AdoyaGiris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection baglanti=new SqlConnection();
        private void btn_SQLEkle_Click(object sender, EventArgs e)
        {
            string adres = @"Data Source=DESKTOP-QO5MM8V\SQLEXPRESS;Initial Catalog=Movies;Integrated Security=True";
            if (baglanti.State==ConnectionState.Open)
            {
                MessageBox.Show("Bağlantı zaten açık");
            }
            else if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.ConnectionString = adres;
                baglanti.Open();
            }
            else
            {
                MessageBox.Show(baglanti.State.ToString());
            }

        }

        private void btn_TbloGetir_Click(object sender, EventArgs e)
        {
            SqlDataAdapter sda=new SqlDataAdapter("Select * From tblFilm",baglanti);
            DataTable dt=new DataTable();
            sda.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void btn_BaglantiKapat_Click(object sender, EventArgs e)
        {
            baglanti.Close();
        }
    }
}
