namespace WindowsFormsApp6
{
    partial class OgrenciYonetim
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_ust = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.Yenile = new System.Windows.Forms.Button();
            this.FilterTb = new System.Windows.Forms.TextBox();
            this.label_baslik = new System.Windows.Forms.Label();
            this.YonetimDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_adSoyad = new System.Windows.Forms.Label();
            this.label_dogumTarihi = new System.Windows.Forms.Label();
            this.label_adres = new System.Windows.Forms.Label();
            this.label_telefon = new System.Windows.Forms.Label();
            this.label_cinsiyet = new System.Windows.Forms.Label();
            this.AdSoyadTb = new System.Windows.Forms.TextBox();
            this.TarihDtp = new System.Windows.Forms.DateTimePicker();
            this.AdresTb = new System.Windows.Forms.TextBox();
            this.TelefonTb = new System.Windows.Forms.TextBox();
            this.CinsiyetCb = new System.Windows.Forms.ComboBox();
            this.YonetimPb = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label_resim = new System.Windows.Forms.Label();
            this.ResimTb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.panel_ust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YonetimDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YonetimPb)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_ust
            // 
            this.panel_ust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel_ust.Controls.Add(this.label9);
            this.panel_ust.Controls.Add(this.Yenile);
            this.panel_ust.Controls.Add(this.button5);
            this.panel_ust.Controls.Add(this.FilterTb);
            this.panel_ust.Controls.Add(this.label_baslik);
            this.panel_ust.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ust.Location = new System.Drawing.Point(0, 0);
            this.panel_ust.Name = "panel_ust";
            this.panel_ust.Size = new System.Drawing.Size(720, 50);
            this.panel_ust.TabIndex = 0;
            //
            // label9
            //
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 13);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(31, 20);
            this.label9.TabIndex = 3;
            this.label9.Text = "<<<";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(580, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 25);
            this.button5.TabIndex = 2;
            this.button5.Text = "ARA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            //
            // Yenile
            //
            this.Yenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.Yenile.FlatAppearance.BorderSize = 0;
            this.Yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yenile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Yenile.ForeColor = System.Drawing.Color.White;
            this.Yenile.Location = new System.Drawing.Point(646, 13);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(64, 25);
            this.Yenile.TabIndex = 4;
            this.Yenile.Text = "Yenile";
            this.Yenile.UseVisualStyleBackColor = false;
            this.Yenile.Click += new System.EventHandler(this.Yenile_Click);
            //
            // FilterTb
            //
            this.FilterTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTb.Location = new System.Drawing.Point(454, 16);
            this.FilterTb.Name = "FilterTb";
            this.FilterTb.Size = new System.Drawing.Size(120, 20);
            this.FilterTb.TabIndex = 1;
            // 
            // label_baslik
            // 
            this.label_baslik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label_baslik.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label_baslik.ForeColor = System.Drawing.Color.White;
            this.label_baslik.Location = new System.Drawing.Point(0, 0);
            this.label_baslik.Name = "label_baslik";
            this.label_baslik.Size = new System.Drawing.Size(720, 50);
            this.label_baslik.TabIndex = 0;
            this.label_baslik.Text = "Öğrenci Yönetim";
            this.label_baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YonetimDgv
            // 
            this.YonetimDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.YonetimDgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.YonetimDgv.ColumnHeadersHeight = 15;
            this.YonetimDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.YonetimDgv.DefaultCellStyle = dataGridViewCellStyle4;
            this.YonetimDgv.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.YonetimDgv.Location = new System.Drawing.Point(8, 58);
            this.YonetimDgv.Name = "YonetimDgv";
            this.YonetimDgv.RowHeadersVisible = false;
            this.YonetimDgv.Size = new System.Drawing.Size(704, 175);
            this.YonetimDgv.TabIndex = 1;
            this.YonetimDgv.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YonetimDgv.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.YonetimDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.YonetimDgv_CellClick_1);
            // 
            // label_adSoyad
            // 
            this.label_adSoyad.AutoSize = true;
            this.label_adSoyad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_adSoyad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_adSoyad.Location = new System.Drawing.Point(61, 255);
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
            this.label_dogumTarihi.Location = new System.Drawing.Point(40, 283);
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
            this.label_adres.Location = new System.Drawing.Point(86, 313);
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
            this.label_telefon.Location = new System.Drawing.Point(310, 255);
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
            this.label_cinsiyet.Location = new System.Drawing.Point(306, 283);
            this.label_cinsiyet.Name = "label_cinsiyet";
            this.label_cinsiyet.Size = new System.Drawing.Size(61, 17);
            this.label_cinsiyet.TabIndex = 10;
            this.label_cinsiyet.Text = "Cinsiyet:";
            // 
            // AdSoyadTb
            // 
            this.AdSoyadTb.Location = new System.Drawing.Point(138, 254);
            this.AdSoyadTb.Name = "AdSoyadTb";
            this.AdSoyadTb.Size = new System.Drawing.Size(120, 20);
            this.AdSoyadTb.TabIndex = 3;
            // 
            // TarihDtp
            // 
            this.TarihDtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.TarihDtp.Location = new System.Drawing.Point(138, 282);
            this.TarihDtp.Name = "TarihDtp";
            this.TarihDtp.Size = new System.Drawing.Size(120, 20);
            this.TarihDtp.TabIndex = 5;
            // 
            // AdresTb
            // 
            this.AdresTb.Location = new System.Drawing.Point(138, 312);
            this.AdresTb.Multiline = true;
            this.AdresTb.Name = "AdresTb";
            this.AdresTb.Size = new System.Drawing.Size(120, 65);
            this.AdresTb.TabIndex = 7;
            // 
            // TelefonTb
            // 
            this.TelefonTb.Location = new System.Drawing.Point(374, 254);
            this.TelefonTb.Name = "TelefonTb";
            this.TelefonTb.Size = new System.Drawing.Size(120, 20);
            this.TelefonTb.TabIndex = 9;
            // 
            // CinsiyetCb
            // 
            this.CinsiyetCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CinsiyetCb.FormattingEnabled = true;
            this.CinsiyetCb.Items.AddRange(new object[] {
            "Kadin",
            "Erkek"});
            this.CinsiyetCb.Location = new System.Drawing.Point(374, 282);
            this.CinsiyetCb.Name = "CinsiyetCb";
            this.CinsiyetCb.Size = new System.Drawing.Size(120, 21);
            this.CinsiyetCb.TabIndex = 11;
            // 
            // YonetimPb
            // 
            this.YonetimPb.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.YonetimPb.Location = new System.Drawing.Point(554, 254);
            this.YonetimPb.Name = "YonetimPb";
            this.YonetimPb.Size = new System.Drawing.Size(110, 82);
            this.YonetimPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.YonetimPb.TabIndex = 12;
            this.YonetimPb.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(174)))), ((int)(((byte)(96)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(496, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(38, 22);
            this.button1.TabIndex = 19;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // openFileDialog1
            //
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // label_resim
            // 
            this.label_resim.AutoSize = true;
            this.label_resim.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_resim.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_resim.Location = new System.Drawing.Point(320, 313);
            this.label_resim.Name = "label_resim";
            this.label_resim.Size = new System.Drawing.Size(49, 17);
            this.label_resim.TabIndex = 17;
            this.label_resim.Text = "Resim:";
            // 
            // ResimTb
            // 
            this.ResimTb.Location = new System.Drawing.Point(374, 312);
            this.ResimTb.Name = "ResimTb";
            this.ResimTb.Size = new System.Drawing.Size(120, 20);
            this.ResimTb.TabIndex = 18;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(324, 378);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 25);
            this.button2.TabIndex = 14;
            this.button2.Text = "RESET";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(439, 378);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 25);
            this.button4.TabIndex = 15;
            this.button4.Text = "GÜNCELLE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(554, 378);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 25);
            this.button3.TabIndex = 16;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // OgrenciYonetim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 415);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ResimTb);
            this.Controls.Add(this.label_resim);
            this.Controls.Add(this.YonetimPb);
            this.Controls.Add(this.CinsiyetCb);
            this.Controls.Add(this.TelefonTb);
            this.Controls.Add(this.AdresTb);
            this.Controls.Add(this.TarihDtp);
            this.Controls.Add(this.AdSoyadTb);
            this.Controls.Add(this.label_cinsiyet);
            this.Controls.Add(this.label_telefon);
            this.Controls.Add(this.label_adres);
            this.Controls.Add(this.label_dogumTarihi);
            this.Controls.Add(this.label_adSoyad);
            this.Controls.Add(this.YonetimDgv);
            this.Controls.Add(this.panel_ust);
            this.Name = "OgrenciYonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OgrenciYonetim";
            this.Load += new System.EventHandler(this.OgrenciYonetim_Load);
            this.panel_ust.ResumeLayout(false);
            this.panel_ust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.YonetimDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YonetimPb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ust;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_baslik;
        private System.Windows.Forms.TextBox FilterTb;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Yenile;
        private Guna.UI2.WinForms.Guna2DataGridView YonetimDgv;
        private System.Windows.Forms.Label label_adSoyad;
        private System.Windows.Forms.Label label_dogumTarihi;
        private System.Windows.Forms.Label label_adres;
        private System.Windows.Forms.Label label_telefon;
        private System.Windows.Forms.Label label_cinsiyet;
        private System.Windows.Forms.TextBox AdSoyadTb;
        private System.Windows.Forms.DateTimePicker TarihDtp;
        private System.Windows.Forms.TextBox AdresTb;
        private System.Windows.Forms.TextBox TelefonTb;
        private System.Windows.Forms.ComboBox CinsiyetCb;
        private System.Windows.Forms.PictureBox YonetimPb;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label_resim;
        private System.Windows.Forms.TextBox ResimTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
