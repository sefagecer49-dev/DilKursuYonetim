namespace WindowsFormsApp6
{
    partial class YeniKurs
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YeniKurs));
            this.panel_ust = new System.Windows.Forms.Panel();
            this.label_geri = new System.Windows.Forms.Label();
            this.pictureBox_kullanici = new System.Windows.Forms.PictureBox();
            this.label_baslik = new System.Windows.Forms.Label();
            this.KursDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_kursAdi = new System.Windows.Forms.Label();
            this.label_kursSaati = new System.Windows.Forms.Label();
            this.label_aciklama = new System.Windows.Forms.Label();
            this.AdTb = new System.Windows.Forms.TextBox();
            this.SaatTb = new System.Windows.Forms.TextBox();
            this.AciklamaTb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_ust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kullanici)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.KursDgv)).BeginInit();
            this.SuspendLayout();
            //
            // panel_ust
            //
            this.panel_ust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel_ust.Controls.Add(this.label_geri);
            this.panel_ust.Controls.Add(this.pictureBox_kullanici);
            this.panel_ust.Controls.Add(this.label_baslik);
            this.panel_ust.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_ust.Location = new System.Drawing.Point(0, 0);
            this.panel_ust.Name = "panel_ust";
            this.panel_ust.Size = new System.Drawing.Size(740, 50);
            this.panel_ust.TabIndex = 0;
            // 
            // label_geri
            // 
            this.label_geri.AutoSize = true;
            this.label_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label_geri.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.label_geri.ForeColor = System.Drawing.Color.White;
            this.label_geri.Location = new System.Drawing.Point(10, 13);
            this.label_geri.Name = "label_geri";
            this.label_geri.Size = new System.Drawing.Size(31, 20);
            this.label_geri.TabIndex = 2;
            this.label_geri.Text = "<<<";
            this.label_geri.Click += new System.EventHandler(this.label_geri_Click);
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
            this.label_baslik.Text = "Yeni Kurs";
            this.label_baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // KursDgv
            //
            this.KursDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.KursDgv.Location = new System.Drawing.Point(0, 50);
            this.KursDgv.Name = "KursDgv";
            this.KursDgv.Size = new System.Drawing.Size(740, 195);
            this.KursDgv.TabIndex = 1;
            //
            // label_kursAdi
            //
            this.label_kursAdi.AutoSize = true;
            this.label_kursAdi.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_kursAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_kursAdi.Location = new System.Drawing.Point(44, 269);
            this.label_kursAdi.Name = "label_kursAdi";
            this.label_kursAdi.Size = new System.Drawing.Size(66, 17);
            this.label_kursAdi.TabIndex = 2;
            this.label_kursAdi.Text = "Kurs Adı:";
            //
            // label_kursSaati
            //
            this.label_kursSaati.AutoSize = true;
            this.label_kursSaati.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_kursSaati.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_kursSaati.Location = new System.Drawing.Point(37, 301);
            this.label_kursSaati.Name = "label_kursSaati";
            this.label_kursSaati.Size = new System.Drawing.Size(73, 17);
            this.label_kursSaati.TabIndex = 4;
            this.label_kursSaati.Text = "Kurs Saati:";
            //
            // label_aciklama
            //
            this.label_aciklama.AutoSize = true;
            this.label_aciklama.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_aciklama.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.label_aciklama.Location = new System.Drawing.Point(39, 332);
            this.label_aciklama.Name = "label_aciklama";
            this.label_aciklama.Size = new System.Drawing.Size(71, 17);
            this.label_aciklama.TabIndex = 6;
            this.label_aciklama.Text = "Açıklama:";
            //
            // AdTb
            //
            this.AdTb.Location = new System.Drawing.Point(116, 268);
            this.AdTb.Name = "AdTb";
            this.AdTb.Size = new System.Drawing.Size(133, 20);
            this.AdTb.TabIndex = 3;
            //
            // SaatTb
            //
            this.SaatTb.Location = new System.Drawing.Point(116, 300);
            this.SaatTb.Name = "SaatTb";
            this.SaatTb.Size = new System.Drawing.Size(133, 20);
            this.SaatTb.TabIndex = 5;
            //
            // AciklamaTb
            //
            this.AciklamaTb.Location = new System.Drawing.Point(116, 331);
            this.AciklamaTb.Multiline = true;
            this.AciklamaTb.Name = "AciklamaTb";
            this.AciklamaTb.Size = new System.Drawing.Size(133, 74);
            this.AciklamaTb.TabIndex = 7;
            //
            // button2
            //
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(476, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 25);
            this.button2.TabIndex = 8;
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
            this.button3.Location = new System.Drawing.Point(597, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 25);
            this.button3.TabIndex = 9;
            this.button3.Text = "EKLE";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // YeniKurs
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 415);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AciklamaTb);
            this.Controls.Add(this.SaatTb);
            this.Controls.Add(this.AdTb);
            this.Controls.Add(this.label_aciklama);
            this.Controls.Add(this.label_kursSaati);
            this.Controls.Add(this.label_kursAdi);
            this.Controls.Add(this.KursDgv);
            this.Controls.Add(this.panel_ust);
            this.Name = "YeniKurs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "YeniKurs";
            this.Load += new System.EventHandler(this.YeniKurs_Load);
            this.panel_ust.ResumeLayout(false);
            this.panel_ust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_kullanici)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.KursDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ust;
        private System.Windows.Forms.Label label_geri;
        private System.Windows.Forms.Label label_baslik;
        private System.Windows.Forms.PictureBox pictureBox_kullanici;
        private Guna.UI2.WinForms.Guna2DataGridView KursDgv;
        private System.Windows.Forms.Label label_kursAdi;
        private System.Windows.Forms.Label label_kursSaati;
        private System.Windows.Forms.Label label_aciklama;
        private System.Windows.Forms.TextBox AdTb;
        private System.Windows.Forms.TextBox SaatTb;
        private System.Windows.Forms.TextBox AciklamaTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}
