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
    public partial class Sehirİlce : Form
    {
        public Sehirİlce()
        {
            InitializeComponent();
        }

        private static string cs =@"Data Source=DESKTOP-QO5MM8V\SQLEXPRESS;Initial Catalog=turkiye;Integrated Security=True";
        private void Sehirİlce_Load(object sender, EventArgs e)
        {
            string sorgu = "select * from dbo.tbl_il";
            comboBox1.DisplayMember = "il_ad";
            comboBox1.ValueMember = "il_id";
            comboBox1.DropDownHeight = 150;
            comboBox1.DataSource = Sorgu(sorgu, cs);
        }

        public static DataTable Sorgu(string sorgu, string cs)
        {
            SqlDataAdapter sda=new SqlDataAdapter(sorgu,cs);
            DataTable dt=new DataTable();
            sda.Fill(dt);
            return dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            short secilenSehirID = (short)comboBox1.SelectedValue;
            string sorgu = "select ilce_ad from dbo.tbl_ilce where il_id=" + secilenSehirID.ToString();
            comboBox2.DisplayMember = "ilce_ad";
            comboBox2.DropDownHeight = 150;
           comboBox2.DataSource = Sorgu(sorgu, cs);
        }
    }
}
