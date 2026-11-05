namespace WindowsFormsApp6
{
    partial class YeniPuan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniPuan));
            this.panel_ust = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox_kullanici = new System.Windows.Forms.PictureBox();
            this.label_baslik = new System.Windows.Forms.Label();
            this.OgrenciDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.PuanDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_ogrenciId = new System.Windows.Forms.Label();
            this.label_kursSec = new System.Windows.Forms.Label();
            this.label_aciklama = new System.Windows.Forms.Label();
            this.label_puan = new System.Windows.Forms.Label();
            this.OgrenciIdTb = new System.Windows.Forms.TextBox();
            this.KursSecCb = new System.Windows.Forms.ComboBox();
            this.AciklamaTb = new System.Windows.Forms.TextBox();
            this.PuanTb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_ust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciDgv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuanDgv)).BeginInit();
            this.SuspendLayout();
            //
            // panel_ust
            //
            this.panel_ust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel_ust.Controls.Add(this.label9);
            this.panel_ust.Controls.Add(this.pictureBox_kullanici);
            this.panel_ust.Controls.Add(this.label_baslik);
            this.panel_ust.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ust.Location = new System.Drawing.Point(0, 0);
            this.panel_ust.Name = "panel_ust";
            this.panel_ust.Size = new System.Drawing.Size(740, 50);
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
            this.label9.TabIndex = 2;
            this.label9.Text = "<<<";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            //
            // pictureBox_kullanici
            //
            this.pictureBox_kullanici.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_kullanici.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox_kullanici.Image")));
            this.pictureBox_kullanici.Location = new System.Drawing.Point(685, 0);
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
            this.label_baslik.Size = new System.Drawing.Size(740, 50);
            this.label_baslik.TabIndex = 0;
            this.label_baslik.Text = "Yeni Puan";
            this.label_baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // OgrenciDgv
            //
            this.OgrenciDgv.Location = new System.Drawing.Point(246, 62);
            this.OgrenciDgv.Name = "OgrenciDgv";
            this.OgrenciDgv.Size = new System.Drawing.Size(486, 180);
            this.OgrenciDgv.TabIndex = 1;
            //
            // PuanDgv
            //
            this.PuanDgv.Location = new System.Drawing.Point(8, 62);
            this.PuanDgv.Name = "PuanDgv";
            this.PuanDgv.Size = new System.Drawing.Size(232, 180);
            this.PuanDgv.TabIndex = 12;
            //
            // label_ogrenciId
            //
            this.label_ogrenciId.AutoSize = true;
            this.label_ogrenciId.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_ogrenciId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_ogrenciId.Location = new System.Drawing.Point(30, 273);
            this.label_ogrenciId.Name = "label_ogrenciId";
            this.label_ogrenciId.Size = new System.Drawing.Size(80, 17);
            this.label_ogrenciId.TabIndex = 2;
            this.label_ogrenciId.Text = "Öğrenci Id:";
            //
            // label_kursSec
            //
            this.label_kursSec.AutoSize = true;
            this.label_kursSec.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_kursSec.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_kursSec.Location = new System.Drawing.Point(42, 305);
            this.label_kursSec.Name = "label_kursSec";
            this.label_kursSec.Size = new System.Drawing.Size(68, 17);
            this.label_kursSec.TabIndex = 4;
            this.label_kursSec.Text = "Kurs Seç:";
            //
            // label_aciklama
            //
            this.label_aciklama.AutoSize = true;
            this.label_aciklama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_aciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_aciklama.Location = new System.Drawing.Point(39, 336);
            this.label_aciklama.Name = "label_aciklama";
            this.label_aciklama.Size = new System.Drawing.Size(71, 17);
            this.label_aciklama.TabIndex = 6;
            this.label_aciklama.Text = "Açıklama:";
            //
            // label_puan
            //
            this.label_puan.AutoSize = true;
            this.label_puan.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_puan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_puan.Location = new System.Drawing.Point(330, 273);
            this.label_puan.Name = "label_puan";
            this.label_puan.Size = new System.Drawing.Size(42, 17);
            this.label_puan.TabIndex = 8;
            this.label_puan.Text = "Puan:";
            //
            // OgrenciIdTb
            //
            this.OgrenciIdTb.Location = new System.Drawing.Point(116, 272);
            this.OgrenciIdTb.Name = "OgrenciIdTb";
            this.OgrenciIdTb.Size = new System.Drawing.Size(133, 20);
            this.OgrenciIdTb.TabIndex = 3;
            //
            // KursSecCb
            //
            this.KursSecCb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.KursSecCb.FormattingEnabled = true;
            this.KursSecCb.Items.AddRange(new object[] {
            "Yds Hazırlık",
            "YksDil Hazırlık",
            "Yokdil Hazırlık",
            "Genel İngilizce"});
            this.KursSecCb.Location = new System.Drawing.Point(116, 304);
            this.KursSecCb.Name = "KursSecCb";
            this.KursSecCb.Size = new System.Drawing.Size(133, 21);
            this.KursSecCb.TabIndex = 5;
            //
            // AciklamaTb
            //
            this.AciklamaTb.Location = new System.Drawing.Point(116, 335);
            this.AciklamaTb.Multiline = true;
            this.AciklamaTb.Name = "AciklamaTb";
            this.AciklamaTb.Size = new System.Drawing.Size(133, 74);
            this.AciklamaTb.TabIndex = 7;
            //
            // PuanTb
            //
            this.PuanTb.Location = new System.Drawing.Point(378, 272);
            this.PuanTb.Name = "PuanTb";
            this.PuanTb.Size = new System.Drawing.Size(133, 20);
            this.PuanTb.TabIndex = 9;
            //
            // button2
            //
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(481, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 25);
            this.button2.TabIndex = 10;
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
            this.button3.Location = new System.Drawing.Point(602, 384);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 25);
            this.button3.TabIndex = 11;
            this.button3.Text = "EKLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // YeniPuan
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 415);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.PuanTb);
            this.Controls.Add(this.AciklamaTb);
            this.Controls.Add(this.KursSecCb);
            this.Controls.Add(this.OgrenciIdTb);
            this.Controls.Add(this.label_puan);
            this.Controls.Add(this.label_aciklama);
            this.Controls.Add(this.label_kursSec);
            this.Controls.Add(this.label_ogrenciId);
            this.Controls.Add(this.PuanDgv);
            this.Controls.Add(this.OgrenciDgv);
            this.Controls.Add(this.panel_ust);
            this.Name = "YeniPuan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniPuan";
            this.Load += new System.EventHandler(this.YeniPuan_Load);
            this.panel_ust.ResumeLayout(false);
            this.panel_ust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OgrenciDgv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PuanDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ust;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label_baslik;
        private System.Windows.Forms.PictureBox pictureBox_kullanici;
        private Guna.UI2.WinForms.Guna2DataGridView OgrenciDgv;
        private Guna.UI2.WinForms.Guna2DataGridView PuanDgv;
        private System.Windows.Forms.Label label_ogrenciId;
        private System.Windows.Forms.Label label_kursSec;
        private System.Windows.Forms.Label label_aciklama;
        private System.Windows.Forms.Label label_puan;
        private System.Windows.Forms.TextBox OgrenciIdTb;
        private System.Windows.Forms.ComboBox KursSecCb;
        private System.Windows.Forms.TextBox AciklamaTb;
        private System.Windows.Forms.TextBox PuanTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
