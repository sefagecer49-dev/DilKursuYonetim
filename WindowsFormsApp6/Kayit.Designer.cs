namespace WindowsFormsApp6
{
    partial class Kayit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kayit));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_ust = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox_kullanici = new System.Windows.Forms.PictureBox();
            this.label_baslik = new System.Windows.Forms.Label();
            this.OgrenciDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_adSoyad = new System.Windows.Forms.Label();
            this.label_dogumTarihi = new System.Windows.Forms.Label();
            this.label_adres = new System.Windows.Forms.Label();
            this.label_telefon = new System.Windows.Forms.Label();
            this.label_cinsiyet = new System.Windows.Forms.Label();
            this.OgrenciAdTb = new System.Windows.Forms.TextBox();
            this.Tarih = new System.Windows.Forms.DateTimePicker();
            this.OgrenciAdresTb = new System.Windows.Forms.TextBox();
            this.OgrenciTelefonTb = new System.Windows.Forms.TextBox();
            this.OgrenciCinsCb = new System.Windows.Forms.ComboBox();
            this.label_resim = new System.Windows.Forms.Label();
            this.OgrenciResimTb = new System.Windows.Forms.TextBox();
            this.OgrenciPb = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_ust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciPb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ust
            // 
            this.panel_ust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel_ust.Controls.Add(this.label8);
            this.panel_ust.Controls.Add(this.pictureBox_kullanici);
            this.panel_ust.Controls.Add(this.label_baslik);
            this.panel_ust.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ust.Location = new System.Drawing.Point(0, 0);
            this.panel_ust.Name = "panel_ust";
            this.panel_ust.Size = new System.Drawing.Size(700, 50);
            this.panel_ust.TabIndex = 0;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 20);
            this.label8.TabIndex = 2;
            this.label8.Text = "<<<";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // pictureBox_kullanici
            // 
            this.pictureBox_kullanici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_kullanici.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_kullanici.Image")));
            this.pictureBox_kullanici.Location = new System.Drawing.Point(645, 0);
            this.pictureBox_kullanici.Name = "pictureBox_kullanici";
            this.pictureBox_kullanici.Size = new System.Drawing.Size(50, 50);
            this.pictureBox_kullanici.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_kullanici.TabIndex = 1;
            this.pictureBox_kullanici.TabStop = false;
            // 
            // label_baslik
            // 
            this.label_baslik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_baslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_baslik.ForeColor = System.Drawing.Color.White;
            this.label_baslik.Location = new System.Drawing.Point(0, 0);
            this.label_baslik.Name = "label_baslik";
            this.label_baslik.Size = new System.Drawing.Size(700, 50);
            this.label_baslik.TabIndex = 0;
            this.label_baslik.Text = "Öğrenci Kayıt";
            this.label_baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // OgrenciDgv
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.OgrenciDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.OgrenciDgv.ColumnHeadersHeight = 15;
            this.OgrenciDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.OgrenciDgv.DefaultCellStyle = dataGridViewCellStyle2;
            this.OgrenciDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.OgrenciDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.OgrenciDgv.Location = new System.Drawing.Point(0, 50);
            this.OgrenciDgv.Name = "OgrenciDgv";
            this.OgrenciDgv.RowHeadersVisible = false;
            this.OgrenciDgv.Size = new System.Drawing.Size(700, 175);
            this.OgrenciDgv.TabIndex = 1;
            this.OgrenciDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.OgrenciDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            // 
            // label_adSoyad
            // 
            this.label_adSoyad.AutoSize = true;
            this.label_adSoyad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_adSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_adSoyad.Location = new System.Drawing.Point(53, 255);
            this.label_adSoyad.Name = "label_adSoyad";
            this.label_adSoyad.Size = new System.Drawing.Size(70, 17);
            this.label_adSoyad.TabIndex = 2;
            this.label_adSoyad.Text = "Ad Soyad:";
            // 
            // label_dogumTarihi
            // 
            this.label_dogumTarihi.AutoSize = true;
            this.label_dogumTarihi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_dogumTarihi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_dogumTarihi.Location = new System.Drawing.Point(32, 283);
            this.label_dogumTarihi.Name = "label_dogumTarihi";
            this.label_dogumTarihi.Size = new System.Drawing.Size(97, 17);
            this.label_dogumTarihi.TabIndex = 4;
            this.label_dogumTarihi.Text = "Doğum Tarihi:";
            // 
            // label_adres
            // 
            this.label_adres.AutoSize = true;
            this.label_adres.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_adres.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_adres.Location = new System.Drawing.Point(78, 313);
            this.label_adres.Name = "label_adres";
            this.label_adres.Size = new System.Drawing.Size(47, 17);
            this.label_adres.TabIndex = 6;
            this.label_adres.Text = "Adres:";
            // 
            // label_telefon
            // 
            this.label_telefon.AutoSize = true;
            this.label_telefon.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_telefon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_telefon.Location = new System.Drawing.Point(302, 255);
            this.label_telefon.Name = "label_telefon";
            this.label_telefon.Size = new System.Drawing.Size(58, 17);
            this.label_telefon.TabIndex = 8;
            this.label_telefon.Text = "Telefon:";
            // 
            // label_cinsiyet
            // 
            this.label_cinsiyet.AutoSize = true;
            this.label_cinsiyet.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_cinsiyet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_cinsiyet.Location = new System.Drawing.Point(298, 283);
            this.label_cinsiyet.Name = "label_cinsiyet";
            this.label_cinsiyet.Size = new System.Drawing.Size(61, 17);
            this.label_cinsiyet.TabIndex = 10;
            this.label_cinsiyet.Text = "Cinsiyet:";
            // 
            // OgrenciAdTb
            // 
            this.OgrenciAdTb.Location = new System.Drawing.Point(130, 254);
            this.OgrenciAdTb.Name = "OgrenciAdTb";
            this.OgrenciAdTb.Size = new System.Drawing.Size(120, 20);
            this.OgrenciAdTb.TabIndex = 3;
            // 
            // Tarih
            // 
            this.Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Tarih.Location = new System.Drawing.Point(130, 282);
            this.Tarih.Name = "Tarih";
            this.Tarih.Size = new System.Drawing.Size(120, 20);
            this.Tarih.TabIndex = 5;
            // 
            // OgrenciAdresTb
            // 
            this.OgrenciAdresTb.Location = new System.Drawing.Point(130, 312);
            this.OgrenciAdresTb.Multiline = true;
            this.OgrenciAdresTb.Name = "OgrenciAdresTb";
            this.OgrenciAdresTb.Size = new System.Drawing.Size(120, 65);
            this.OgrenciAdresTb.TabIndex = 7;
            // 
            // OgrenciTelefonTb
            // 
            this.OgrenciTelefonTb.Location = new System.Drawing.Point(366, 254);
            this.OgrenciTelefonTb.Name = "OgrenciTelefonTb";
            this.OgrenciTelefonTb.Size = new System.Drawing.Size(120, 20);
            this.OgrenciTelefonTb.TabIndex = 9;
            // 
            // OgrenciCinsCb
            // 
            this.OgrenciCinsCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.OgrenciCinsCb.FormattingEnabled = true;
            this.OgrenciCinsCb.Items.AddRange(new object[] {
            "Kadin",
            "Erkek"});
            this.OgrenciCinsCb.Location = new System.Drawing.Point(366, 282);
            this.OgrenciCinsCb.Name = "OgrenciCinsCb";
            this.OgrenciCinsCb.Size = new System.Drawing.Size(120, 21);
            this.OgrenciCinsCb.TabIndex = 11;
            // 
            // label_resim
            // 
            this.label_resim.AutoSize = true;
            this.label_resim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_resim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_resim.Location = new System.Drawing.Point(312, 313);
            this.label_resim.Name = "label_resim";
            this.label_resim.Size = new System.Drawing.Size(49, 17);
            this.label_resim.TabIndex = 16;
            this.label_resim.Text = "Resim:";
            // 
            // OgrenciResimTb
            // 
            this.OgrenciResimTb.Location = new System.Drawing.Point(366, 312);
            this.OgrenciResimTb.Name = "OgrenciResimTb";
            this.OgrenciResimTb.Size = new System.Drawing.Size(120, 20);
            this.OgrenciResimTb.TabIndex = 17;
            // 
            // OgrenciPb
            // 
            this.OgrenciPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.OgrenciPb.Location = new System.Drawing.Point(546, 254);
            this.OgrenciPb.Name = "OgrenciPb";
            this.OgrenciPb.Size = new System.Drawing.Size(110, 82);
            this.OgrenciPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.OgrenciPb.TabIndex = 12;
            this.OgrenciPb.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(488, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 22);
            this.button1.TabIndex = 18;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(426, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(546, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 25);
            this.button3.TabIndex = 15;
            this.button3.Text = "EKLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Kayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(700, 415);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.OgrenciResimTb);
            this.Controls.Add(this.label_resim);
            this.Controls.Add(this.OgrenciPb);
            this.Controls.Add(this.OgrenciCinsCb);
            this.Controls.Add(this.OgrenciTelefonTb);
            this.Controls.Add(this.OgrenciAdresTb);
            this.Controls.Add(this.Tarih);
            this.Controls.Add(this.OgrenciAdTb);
            this.Controls.Add(this.label_cinsiyet);
            this.Controls.Add(this.label_telefon);
            this.Controls.Add(this.label_adres);
            this.Controls.Add(this.label_dogumTarihi);
            this.Controls.Add(this.label_adSoyad);
            this.Controls.Add(this.OgrenciDgv);
            this.Controls.Add(this.panel_ust);
            this.Name = "Kayit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kayit";
            this.Load += new System.EventHandler(this.Kayit_Load);
            this.panel_ust.ResumeLayout(false);
            this.panel_ust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ust;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label_baslik;
        private System.Windows.Forms.PictureBox pictureBox_kullanici;
        private Guna.UI2.WinForms.Guna2DataGridView OgrenciDgv;
        private System.Windows.Forms.Label label_adSoyad;
        private System.Windows.Forms.Label label_dogumTarihi;
        private System.Windows.Forms.Label label_adres;
        private System.Windows.Forms.Label label_telefon;
        private System.Windows.Forms.Label label_cinsiyet;
        private System.Windows.Forms.TextBox OgrenciAdTb;
        private System.Windows.Forms.DateTimePicker Tarih;
        private System.Windows.Forms.TextBox OgrenciAdresTb;
        private System.Windows.Forms.TextBox OgrenciTelefonTb;
        private System.Windows.Forms.ComboBox OgrenciCinsCb;
        private System.Windows.Forms.Label label_resim;
        private System.Windows.Forms.TextBox OgrenciResimTb;
        private System.Windows.Forms.PictureBox OgrenciPb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
