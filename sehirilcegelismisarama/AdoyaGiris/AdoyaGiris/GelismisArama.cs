using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdoyaGiris
{
    public partial class GelismisArama : Form
    {
        public GelismisArama()
        {
            InitializeComponent();
        }

        void Sorgu()
        {
            string sorgu3;
            int languageID =(int)comboBox1.SelectedValue;
            string filmAdı = textBox1.Text;
            int maxSure = (int)numericUpDown1.Value;
            sorgu3 = "select * from tblFilm where FilmName like '" + filmAdı+ "%'and FilmRunTimeMinutes<" + maxSure +" and FilmLanguageID=" + languageID;
            dataGridView1.DataSource = Sehirİlce.Sorgu(sorgu3, cs);
        }

        string cs =@"Data Source=DESKTOP-QO5MM8V\SQLEXPRESS;Initial Catalog=Movies;Integrated Security=True";
        private void GelismisArama_Load(object sender, EventArgs e)
        {
            string sorgu1 = "select * from tblLanguage";
            comboBox1.DisplayMember = "Language";
            comboBox1.ValueMember = "LanguageID";
            comboBox1.DataSource = Sehirİlce.Sorgu(sorgu1, cs);
            if (textBox1.Text == "" || numericUpDown1.Value == 0)
            {
                string sorgu2 = "select * from tblFilm";
                dataGridView1.DataSource = Sehirİlce.Sorgu(sorgu2, cs);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            Sorgu();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            Sorgu();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Sorgu();
        }
    }
}
