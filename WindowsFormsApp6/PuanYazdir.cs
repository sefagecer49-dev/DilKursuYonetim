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

namespace WindowsFormsApp6
{
    public partial class PuanYazdir : Form
    {
        public PuanYazdir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\KursDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void PuanYazdir_Load(object sender, EventArgs e)
        {
            puanlar();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }

        private void puanlar()
        {
            baglanti.Open();
            string query = "select * from PuanTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            PuanDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from PuanTbl where Kurs like '%" + FilterTb.Text + "%'", baglanti);
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            PuanDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            puanlar();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bmp = new Bitmap(this.PuanDgv.Width, this.PuanDgv.Height);
            PuanDgv.DrawToBitmap(bmp, new Rectangle(0, 0, this.PuanDgv.Width, this.PuanDgv.Height));
            e.Graphics.DrawImage(bmp, 20, 150);
            e.Graphics.DrawString(label1.Text, new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            this.PuanDgv.Columns["PuanId"].Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }
    }
}
