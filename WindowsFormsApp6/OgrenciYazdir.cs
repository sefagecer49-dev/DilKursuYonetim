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
    public partial class OgrenciYazdir : Form
    {
        public OgrenciYazdir()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\KursDb.mdf;Integrated Security=True;Connect Timeout=30");
        private void OgrenciYazdir_Load(object sender, EventArgs e)
        {
            uyeler();
        }
        private void uyeler()
        {
            baglanti.Open();
            string query = "select * from OgrenciTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            yazdırDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from OgrenciTbl where AdSoyad like '%" + FilterTb.Text + "%'", baglanti);
            SqlDataAdapter sda = new SqlDataAdapter(komut);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            yazdırDgv.DataSource = ds.Tables[0];
            baglanti.Close();
        }

        private void Yenile_Click(object sender, EventArgs e)
        {
            uyeler();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.yazdırDgv.Width, this.yazdırDgv.Height);
            yazdırDgv.DrawToBitmap(objBmp, new Rectangle(0, 0, this.yazdırDgv.Width, this.yazdırDgv.Height));
            e.Graphics.DrawImage(objBmp, 20, 150);
            e.Graphics.DrawString(label1.Text, new Font("Verdana", 20, FontStyle.Bold), Brushes.Black, new Point(300, 30));
            this.yazdırDgv.Columns["OgrenciId"].Visible=false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();

        }

        private void label_geri_Click(object sender, EventArgs e)
        {
            AnaSayfa ana = new AnaSayfa();
            ana.Show();
            this.Hide();
        }
    }
}
