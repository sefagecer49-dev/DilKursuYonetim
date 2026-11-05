namespace WindowsFormsApp6
{
    partial class AnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaSayfa));
            this.panel_solMenu = new System.Windows.Forms.Panel();
            this.button_cikis = new System.Windows.Forms.Button();
            this.panel_puanMenü = new System.Windows.Forms.Panel();
            this.button_puanYazdir = new System.Windows.Forms.Button();
            this.button_puanYonetim = new System.Windows.Forms.Button();
            this.button_yenipuan = new System.Windows.Forms.Button();
            this.button_puanlama = new System.Windows.Forms.Button();
            this.panel_kursMenu = new System.Windows.Forms.Panel();
            this.button_KursYazdır = new System.Windows.Forms.Button();
            this.button_KursYönetim = new System.Windows.Forms.Button();
            this.button_KursKayit = new System.Windows.Forms.Button();
            this.button_Kurs = new System.Windows.Forms.Button();
            this.panel_ogrenciMenu = new System.Windows.Forms.Panel();
            this.button_ogrenciYazdır = new System.Windows.Forms.Button();
            this.button_ogrenciYönetim = new System.Windows.Forms.Button();
            this.button_ogrencikayıt = new System.Windows.Forms.Button();
            this.button_ogrenci = new System.Windows.Forms.Button();
            this.panel_logo = new System.Windows.Forms.Panel();
            this.label_hosgeldiniz = new System.Windows.Forms.Label();
            this.label_logo = new System.Windows.Forms.Label();
            this.panel_icerik = new System.Windows.Forms.Panel();
            this.pictureBox_anaResim = new System.Windows.Forms.PictureBox();
            this.panel_ust2 = new System.Windows.Forms.Panel();
            this.pictureBox_kullanici = new System.Windows.Forms.PictureBox();
            this.label_kullanici = new System.Windows.Forms.Label();
            this.panel_ust1 = new System.Windows.Forms.Panel();
            this.label_kursAdi = new System.Windows.Forms.Label();
            this.panel_solMenu.SuspendLayout();
            this.panel_puanMenü.SuspendLayout();
            this.panel_kursMenu.SuspendLayout();
            this.panel_ogrenciMenu.SuspendLayout();
            this.panel_logo.SuspendLayout();
            this.panel_icerik.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anaResim)).BeginInit();
            this.panel_ust2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kullanici)).BeginInit();
            this.panel_ust1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_solMenu
            // 
            this.panel_solMenu.AutoScroll = true;
            this.panel_solMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel_solMenu.Controls.Add(this.button_cikis);
            this.panel_solMenu.Controls.Add(this.panel_puanMenü);
            this.panel_solMenu.Controls.Add(this.button_puanlama);
            this.panel_solMenu.Controls.Add(this.panel_kursMenu);
            this.panel_solMenu.Controls.Add(this.button_Kurs);
            this.panel_solMenu.Controls.Add(this.panel_ogrenciMenu);
            this.panel_solMenu.Controls.Add(this.button_ogrenci);
            this.panel_solMenu.Controls.Add(this.panel_logo);
            this.panel_solMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_solMenu.Location = new System.Drawing.Point(0, 0);
            this.panel_solMenu.Name = "panel_solMenu";
            this.panel_solMenu.Size = new System.Drawing.Size(140, 561);
            this.panel_solMenu.TabIndex = 0;
            // 
            // button_cikis
            // 
            this.button_cikis.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_cikis.FlatAppearance.BorderSize = 0;
            this.button_cikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_cikis.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_cikis.ForeColor = System.Drawing.Color.White;
            this.button_cikis.Location = new System.Drawing.Point(0, 450);
            this.button_cikis.Name = "button_cikis";
            this.button_cikis.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_cikis.Size = new System.Drawing.Size(140, 25);
            this.button_cikis.TabIndex = 7;
            this.button_cikis.Text = "Çıkış";
            this.button_cikis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_cikis.UseVisualStyleBackColor = true;
            this.button_cikis.Click += new System.EventHandler(this.button_cikis_Click);
            // 
            // panel_puanMenü
            // 
            this.panel_puanMenü.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel_puanMenü.Controls.Add(this.button_puanYazdir);
            this.panel_puanMenü.Controls.Add(this.button_puanYonetim);
            this.panel_puanMenü.Controls.Add(this.button_yenipuan);
            this.panel_puanMenü.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_puanMenü.Location = new System.Drawing.Point(0, 375);
            this.panel_puanMenü.Name = "panel_puanMenü";
            this.panel_puanMenü.Size = new System.Drawing.Size(140, 75);
            this.panel_puanMenü.TabIndex = 6;
            // 
            // button_puanYazdir
            // 
            this.button_puanYazdir.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_puanYazdir.FlatAppearance.BorderSize = 0;
            this.button_puanYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_puanYazdir.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.button_puanYazdir.ForeColor = System.Drawing.Color.White;
            this.button_puanYazdir.Location = new System.Drawing.Point(0, 50);
            this.button_puanYazdir.Name = "button_puanYazdir";
            this.button_puanYazdir.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_puanYazdir.Size = new System.Drawing.Size(140, 25);
            this.button_puanYazdir.TabIndex = 2;
            this.button_puanYazdir.Text = "Yazdır";
            this.button_puanYazdir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_puanYazdir.UseVisualStyleBackColor = true;
            this.button_puanYazdir.Click += new System.EventHandler(this.button_puanYazdir_Click);
            // 
            // button_puanYonetim
            // 
            this.button_puanYonetim.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_puanYonetim.FlatAppearance.BorderSize = 0;
            this.button_puanYonetim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_puanYonetim.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.button_puanYonetim.ForeColor = System.Drawing.Color.White;
            this.button_puanYonetim.Location = new System.Drawing.Point(0, 25);
            this.button_puanYonetim.Name = "button_puanYonetim";
            this.button_puanYonetim.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_puanYonetim.Size = new System.Drawing.Size(140, 25);
            this.button_puanYonetim.TabIndex = 1;
            this.button_puanYonetim.Text = "Puan Yönetim";
            this.button_puanYonetim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_puanYonetim.UseVisualStyleBackColor = true;
            this.button_puanYonetim.Click += new System.EventHandler(this.button_puanYonetim_Click);
            // 
            // button_yenipuan
            // 
            this.button_yenipuan.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_yenipuan.FlatAppearance.BorderSize = 0;
            this.button_yenipuan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_yenipuan.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.button_yenipuan.ForeColor = System.Drawing.Color.White;
            this.button_yenipuan.Location = new System.Drawing.Point(0, 0);
            this.button_yenipuan.Name = "button_yenipuan";
            this.button_yenipuan.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_yenipuan.Size = new System.Drawing.Size(140, 25);
            this.button_yenipuan.TabIndex = 0;
            this.button_yenipuan.Text = "Yeni Puan";
            this.button_yenipuan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_yenipuan.UseVisualStyleBackColor = true;
            this.button_yenipuan.Click += new System.EventHandler(this.button_yenipuan_Click);
            // 
            // button_puanlama
            // 
            this.button_puanlama.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_puanlama.FlatAppearance.BorderSize = 0;
            this.button_puanlama.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_puanlama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_puanlama.ForeColor = System.Drawing.Color.White;
            this.button_puanlama.Location = new System.Drawing.Point(0, 350);
            this.button_puanlama.Name = "button_puanlama";
            this.button_puanlama.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_puanlama.Size = new System.Drawing.Size(140, 25);
            this.button_puanlama.TabIndex = 5;
            this.button_puanlama.Text = "Puanlar";
            this.button_puanlama.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_puanlama.UseVisualStyleBackColor = true;
            this.button_puanlama.Click += new System.EventHandler(this.button_puanlama_Click);
            // 
            // panel_kursMenu
            // 
            this.panel_kursMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel_kursMenu.Controls.Add(this.button_KursYazdır);
            this.panel_kursMenu.Controls.Add(this.button_KursYönetim);
            this.panel_kursMenu.Controls.Add(this.button_KursKayit);
            this.panel_kursMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_kursMenu.Location = new System.Drawing.Point(0, 275);
            this.panel_kursMenu.Name = "panel_kursMenu";
            this.panel_kursMenu.Size = new System.Drawing.Size(140, 75);
            this.panel_kursMenu.TabIndex = 4;
            // 
            // button_KursYazdır
            // 
            this.button_KursYazdır.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_KursYazdır.FlatAppearance.BorderSize = 0;
            this.button_KursYazdır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KursYazdır.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.button_KursYazdır.ForeColor = System.Drawing.Color.White;
            this.button_KursYazdır.Location = new System.Drawing.Point(0, 50);
            this.button_KursYazdır.Name = "button_KursYazdır";
            this.button_KursYazdır.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_KursYazdır.Size = new System.Drawing.Size(140, 25);
            this.button_KursYazdır.TabIndex = 2;
            this.button_KursYazdır.Text = "Yazdır";
            this.button_KursYazdır.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_KursYazdır.UseVisualStyleBackColor = true;
            this.button_KursYazdır.Click += new System.EventHandler(this.button_KursYazdır_Click);
            // 
            // button_KursYönetim
            // 
            this.button_KursYönetim.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_KursYönetim.FlatAppearance.BorderSize = 0;
            this.button_KursYönetim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KursYönetim.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.button_KursYönetim.ForeColor = System.Drawing.Color.White;
            this.button_KursYönetim.Location = new System.Drawing.Point(0, 25);
            this.button_KursYönetim.Name = "button_KursYönetim";
            this.button_KursYönetim.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_KursYönetim.Size = new System.Drawing.Size(140, 25);
            this.button_KursYönetim.TabIndex = 1;
            this.button_KursYönetim.Text = "Kayıt Yönetim";
            this.button_KursYönetim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_KursYönetim.UseVisualStyleBackColor = true;
            this.button_KursYönetim.Click += new System.EventHandler(this.button_KursYönetim_Click);
            // 
            // button_KursKayit
            // 
            this.button_KursKayit.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_KursKayit.FlatAppearance.BorderSize = 0;
            this.button_KursKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_KursKayit.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.button_KursKayit.ForeColor = System.Drawing.Color.White;
            this.button_KursKayit.Location = new System.Drawing.Point(0, 0);
            this.button_KursKayit.Name = "button_KursKayit";
            this.button_KursKayit.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_KursKayit.Size = new System.Drawing.Size(140, 25);
            this.button_KursKayit.TabIndex = 0;
            this.button_KursKayit.Text = "Yeni Kayıt";
            this.button_KursKayit.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_KursKayit.UseVisualStyleBackColor = true;
            this.button_KursKayit.Click += new System.EventHandler(this.button_KursKayit_Click);
            // 
            // button_Kurs
            // 
            this.button_Kurs.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_Kurs.FlatAppearance.BorderSize = 0;
            this.button_Kurs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_Kurs.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_Kurs.ForeColor = System.Drawing.Color.White;
            this.button_Kurs.Location = new System.Drawing.Point(0, 250);
            this.button_Kurs.Name = "button_Kurs";
            this.button_Kurs.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_Kurs.Size = new System.Drawing.Size(140, 25);
            this.button_Kurs.TabIndex = 3;
            this.button_Kurs.Text = "Kurs";
            this.button_Kurs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_Kurs.UseVisualStyleBackColor = true;
            this.button_Kurs.Click += new System.EventHandler(this.button_Kurs_Click);
            // 
            // panel_ogrenciMenu
            // 
            this.panel_ogrenciMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel_ogrenciMenu.Controls.Add(this.button_ogrenciYazdır);
            this.panel_ogrenciMenu.Controls.Add(this.button_ogrenciYönetim);
            this.panel_ogrenciMenu.Controls.Add(this.button_ogrencikayıt);
            this.panel_ogrenciMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ogrenciMenu.Location = new System.Drawing.Point(0, 150);
            this.panel_ogrenciMenu.Name = "panel_ogrenciMenu";
            this.panel_ogrenciMenu.Size = new System.Drawing.Size(140, 75);
            this.panel_ogrenciMenu.TabIndex = 2;
            // 
            // button_ogrenciYazdır
            // 
            this.button_ogrenciYazdır.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ogrenciYazdır.FlatAppearance.BorderSize = 0;
            this.button_ogrenciYazdır.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ogrenciYazdır.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.button_ogrenciYazdır.ForeColor = System.Drawing.Color.White;
            this.button_ogrenciYazdır.Location = new System.Drawing.Point(0, 50);
            this.button_ogrenciYazdır.Name = "button_ogrenciYazdır";
            this.button_ogrenciYazdır.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_ogrenciYazdır.Size = new System.Drawing.Size(140, 25);
            this.button_ogrenciYazdır.TabIndex = 2;
            this.button_ogrenciYazdır.Text = "Yazdır";
            this.button_ogrenciYazdır.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ogrenciYazdır.UseVisualStyleBackColor = true;
            this.button_ogrenciYazdır.Click += new System.EventHandler(this.button_ogrenciYazdır_Click);
            // 
            // button_ogrenciYönetim
            // 
            this.button_ogrenciYönetim.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ogrenciYönetim.FlatAppearance.BorderSize = 0;
            this.button_ogrenciYönetim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ogrenciYönetim.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.button_ogrenciYönetim.ForeColor = System.Drawing.Color.White;
            this.button_ogrenciYönetim.Location = new System.Drawing.Point(0, 25);
            this.button_ogrenciYönetim.Name = "button_ogrenciYönetim";
            this.button_ogrenciYönetim.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_ogrenciYönetim.Size = new System.Drawing.Size(140, 25);
            this.button_ogrenciYönetim.TabIndex = 1;
            this.button_ogrenciYönetim.Text = "Öğrenci";
            this.button_ogrenciYönetim.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ogrenciYönetim.UseVisualStyleBackColor = true;
            this.button_ogrenciYönetim.Click += new System.EventHandler(this.button_ogrenciYönetim_Click);
            // 
            // button_ogrencikayıt
            // 
            this.button_ogrencikayıt.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ogrencikayıt.FlatAppearance.BorderSize = 0;
            this.button_ogrencikayıt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ogrencikayıt.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.button_ogrencikayıt.ForeColor = System.Drawing.Color.White;
            this.button_ogrencikayıt.Location = new System.Drawing.Point(0, 0);
            this.button_ogrencikayıt.Name = "button_ogrencikayıt";
            this.button_ogrencikayıt.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.button_ogrencikayıt.Size = new System.Drawing.Size(140, 25);
            this.button_ogrencikayıt.TabIndex = 0;
            this.button_ogrencikayıt.Text = "Kayıt";
            this.button_ogrencikayıt.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ogrencikayıt.UseVisualStyleBackColor = true;
            this.button_ogrencikayıt.Click += new System.EventHandler(this.button_ogrencikayıt_Click);
            // 
            // button_ogrenci
            // 
            this.button_ogrenci.Dock = System.Windows.Forms.DockStyle.Top;
            this.button_ogrenci.FlatAppearance.BorderSize = 0;
            this.button_ogrenci.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_ogrenci.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.button_ogrenci.ForeColor = System.Drawing.Color.White;
            this.button_ogrenci.Location = new System.Drawing.Point(0, 125);
            this.button_ogrenci.Name = "button_ogrenci";
            this.button_ogrenci.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.button_ogrenci.Size = new System.Drawing.Size(140, 25);
            this.button_ogrenci.TabIndex = 1;
            this.button_ogrenci.Text = "Öğrenci";
            this.button_ogrenci.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ogrenci.UseVisualStyleBackColor = true;
            this.button_ogrenci.Click += new System.EventHandler(this.button_ogrenci_Click);
            // 
            // panel_logo
            // 
            this.panel_logo.Controls.Add(this.label_hosgeldiniz);
            this.panel_logo.Controls.Add(this.label_logo);
            this.panel_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_logo.Location = new System.Drawing.Point(0, 0);
            this.panel_logo.Name = "panel_logo";
            this.panel_logo.Size = new System.Drawing.Size(140, 125);
            this.panel_logo.TabIndex = 0;
            // 
            // label_hosgeldiniz
            // 
            this.label_hosgeldiniz.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_hosgeldiniz.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.label_hosgeldiniz.ForeColor = System.Drawing.Color.White;
            this.label_hosgeldiniz.Location = new System.Drawing.Point(0, 80);
            this.label_hosgeldiniz.Name = "label_hosgeldiniz";
            this.label_hosgeldiniz.Size = new System.Drawing.Size(140, 45);
            this.label_hosgeldiniz.TabIndex = 1;
            this.label_hosgeldiniz.Text = "Hoşgeldiniz";
            this.label_hosgeldiniz.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label_logo
            // 
            this.label_logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_logo.Font = new System.Drawing.Font("Times New Roman", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_logo.ForeColor = System.Drawing.Color.White;
            this.label_logo.Location = new System.Drawing.Point(0, 0);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(140, 80);
            this.label_logo.TabIndex = 0;
            this.label_logo.Text = "G";
            this.label_logo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // panel_icerik
            // 
            this.panel_icerik.Controls.Add(this.pictureBox_anaResim);
            this.panel_icerik.Controls.Add(this.panel_ust2);
            this.panel_icerik.Controls.Add(this.panel_ust1);
            this.panel_icerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_icerik.Location = new System.Drawing.Point(140, 0);
            this.panel_icerik.Name = "panel_icerik";
            this.panel_icerik.Size = new System.Drawing.Size(744, 561);
            this.panel_icerik.TabIndex = 1;
            // 
            // pictureBox_anaResim
            // 
            this.pictureBox_anaResim.BackColor = System.Drawing.Color.White;
            this.pictureBox_anaResim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox_anaResim.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_anaResim.Image")));
            this.pictureBox_anaResim.Location = new System.Drawing.Point(0, 95);
            this.pictureBox_anaResim.Name = "pictureBox_anaResim";
            this.pictureBox_anaResim.Size = new System.Drawing.Size(744, 406);
            this.pictureBox_anaResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_anaResim.TabIndex = 3;
            this.pictureBox_anaResim.TabStop = false;
            // 
            // panel_ust2
            // 
            this.panel_ust2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel_ust2.Controls.Add(this.pictureBox_kullanici);
            this.panel_ust2.Controls.Add(this.label_kullanici);
            this.panel_ust2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ust2.Location = new System.Drawing.Point(0, 40);
            this.panel_ust2.Name = "panel_ust2";
            this.panel_ust2.Size = new System.Drawing.Size(744, 55);
            this.panel_ust2.TabIndex = 1;
            // 
            // pictureBox_kullanici
            // 
            this.pictureBox_kullanici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_kullanici.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_kullanici.Image")));
            this.pictureBox_kullanici.Location = new System.Drawing.Point(689, 3);
            this.pictureBox_kullanici.Name = "pictureBox_kullanici";
            this.pictureBox_kullanici.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_kullanici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_kullanici.TabIndex = 1;
            this.pictureBox_kullanici.TabStop = false;
            // 
            // label_kullanici
            // 
            this.label_kullanici.AutoSize = true;
            this.label_kullanici.Font = new System.Drawing.Font("Segoe UI", 8F);
            this.label_kullanici.ForeColor = System.Drawing.Color.White;
            this.label_kullanici.Location = new System.Drawing.Point(8, 21);
            this.label_kullanici.Name = "label_kullanici";
            this.label_kullanici.Size = new System.Drawing.Size(89, 13);
            this.label_kullanici.TabIndex = 0;
            this.label_kullanici.Text = "Kullanıcı: Admin";
            // 
            // panel_ust1
            // 
            this.panel_ust1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(236)))), ((int)(((byte)(240)))), ((int)(((byte)(241)))));
            this.panel_ust1.Controls.Add(this.label_kursAdi);
            this.panel_ust1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ust1.Location = new System.Drawing.Point(0, 0);
            this.panel_ust1.Name = "panel_ust1";
            this.panel_ust1.Size = new System.Drawing.Size(744, 40);
            this.panel_ust1.TabIndex = 0;
            // 
            // label_kursAdi
            // 
            this.label_kursAdi.AutoSize = true;
            this.label_kursAdi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label_kursAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_kursAdi.Location = new System.Drawing.Point(6, 9);
            this.label_kursAdi.Name = "label_kursAdi";
            this.label_kursAdi.Size = new System.Drawing.Size(164, 21);
            this.label_kursAdi.TabIndex = 0;
            this.label_kursAdi.Text = "Geçer Dil Kursu-Muş";
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.panel_icerik);
            this.Controls.Add(this.panel_solMenu);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AnaSayfa";
            this.panel_solMenu.ResumeLayout(false);
            this.panel_puanMenü.ResumeLayout(false);
            this.panel_kursMenu.ResumeLayout(false);
            this.panel_ogrenciMenu.ResumeLayout(false);
            this.panel_logo.ResumeLayout(false);
            this.panel_icerik.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_anaResim)).EndInit();
            this.panel_ust2.ResumeLayout(false);
            this.panel_ust2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kullanici)).EndInit();
            this.panel_ust1.ResumeLayout(false);
            this.panel_ust1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_solMenu;
        private System.Windows.Forms.Panel panel_logo;
        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.Label label_hosgeldiniz;
        private System.Windows.Forms.Button button_ogrenci;
        private System.Windows.Forms.Panel panel_ogrenciMenu;
        private System.Windows.Forms.Button button_ogrencikayıt;
        private System.Windows.Forms.Button button_ogrenciYönetim;
        private System.Windows.Forms.Button button_ogrenciYazdır;
        private System.Windows.Forms.Button button_Kurs;
        private System.Windows.Forms.Panel panel_kursMenu;
        private System.Windows.Forms.Button button_KursKayit;
        private System.Windows.Forms.Button button_KursYönetim;
        private System.Windows.Forms.Button button_KursYazdır;
        private System.Windows.Forms.Button button_puanlama;
        private System.Windows.Forms.Panel panel_puanMenü;
        private System.Windows.Forms.Button button_yenipuan;
        private System.Windows.Forms.Button button_puanYonetim;
        private System.Windows.Forms.Button button_puanYazdir;
        private System.Windows.Forms.Button button_cikis;
        private System.Windows.Forms.Panel panel_icerik;
        private System.Windows.Forms.Panel panel_ust1;
        private System.Windows.Forms.Label label_kursAdi;
        private System.Windows.Forms.Panel panel_ust2;
        private System.Windows.Forms.Label label_kullanici;
        private System.Windows.Forms.PictureBox pictureBox_kullanici;
        private System.Windows.Forms.PictureBox pictureBox_anaResim;
    }
}

