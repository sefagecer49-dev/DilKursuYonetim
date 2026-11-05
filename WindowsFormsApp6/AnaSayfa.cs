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
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
            PanelDesign();
        }

        private void PanelDesign()
        {
            panel_ogrenciMenu.Visible = false;
            panel_kursMenu.Visible = false;
            panel_puanMenü.Visible = false;
        }
        private void HideMenu()
        {
            if (panel_ogrenciMenu.Visible == true)
                panel_ogrenciMenu.Visible = false;
            if (panel_kursMenu.Visible == true)
                panel_kursMenu.Visible = false;
            if (panel_puanMenü.Visible == true)
                panel_puanMenü.Visible = false;
        }
        private void ShowMenu(Panel menu)
        {
            if(menu.Visible==false)
            {
                HideMenu();
                menu.Visible = true;
            }
            else
            {
                menu.Visible = false;
            }
        }

        private void button_ogrenci_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_ogrenciMenu);
        }

        private void button_ogrencikayıt_Click(object sender, EventArgs e)
        {
            HideMenu();
            Kayit kyt = new Kayit();
            kyt.Show();
            this.Hide();
        }

        private void button_ogrenciYönetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            OgrenciYonetim ogry = new OgrenciYonetim();
            ogry.Show();
            this.Hide();

        }

        private void button_ogrenciYazdır_Click(object sender, EventArgs e)
        {
            HideMenu();
            OgrenciYazdir ogrz = new OgrenciYazdir();
            ogrz.Show();
            this.Hide();
        }

        private void button_Kurs_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_kursMenu);
        }

        private void button_KursKayit_Click(object sender, EventArgs e)
        {
            HideMenu();
            YeniKurs yk = new YeniKurs();
            yk.Show();
            this.Hide();
        }

        private void button_KursYönetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            KayitYonetim ky = new KayitYonetim();
            ky.Show();
            this.Hide();
        }


        private void button_KursYazdır_Click(object sender, EventArgs e)
        {
            HideMenu();
            KursYazdir kyz = new KursYazdir();
            kyz.Show();
            this.Hide();
        }

        private void button_puanlama_Click(object sender, EventArgs e)
        {
            ShowMenu(panel_puanMenü);
        }

        private void button_yenipuan_Click(object sender, EventArgs e)
        {
            HideMenu();
            YeniPuan yp = new YeniPuan();
            yp.Show();
            this.Hide();
        }

        private void button_puanYonetim_Click(object sender, EventArgs e)
        {
            HideMenu();
            PuanYonetim py = new PuanYonetim();
            py.Show();
            this.Hide();
        }

        private void button_puanYazdir_Click(object sender, EventArgs e)
        {
            HideMenu();
            PuanYazdir pyz = new PuanYazdir();
            pyz.Show();
            this.Hide();
        }

        private void button_cikis_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Hide();
        }

    }
}
