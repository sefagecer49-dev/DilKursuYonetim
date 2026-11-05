using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(KullaniciTb.Text==""||SifreTb.Text=="")
            {
                MessageBox.Show("Eksik Bilgi");
            }
            else if(KullaniciTb.Text=="Admin"&& SifreTb.Text=="1234")
            {
                AnaSayfa ana = new AnaSayfa();
                ana.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Kullanıcı yada Şifre");
            }
        }
    }
}
