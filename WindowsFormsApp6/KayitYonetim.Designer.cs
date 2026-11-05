namespace WindowsFormsApp6
{
    partial class KayitYonetim
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
            this.panel_ust = new System.Windows.Forms.Panel();
            this.label_geri = new System.Windows.Forms.Label();
            this.Yenile = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.FilterTb = new System.Windows.Forms.TextBox();
            this.label_baslik = new System.Windows.Forms.Label();
            this.KYonetimDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label_kursAdi = new System.Windows.Forms.Label();
            this.label_kursSaati = new System.Windows.Forms.Label();
            this.label_aciklama = new System.Windows.Forms.Label();
            this.AdTb = new System.Windows.Forms.TextBox();
            this.SaatTb = new System.Windows.Forms.TextBox();
            this.AciklamaTb = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel_ust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KYonetimDgv)).BeginInit();
            this.SuspendLayout();
            //
            // panel_ust
            //
            this.panel_ust.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.panel_ust.Controls.Add(this.label_geri);
            this.panel_ust.Controls.Add(this.Yenile);
            this.panel_ust.Controls.Add(this.button5);
            this.panel_ust.Controls.Add(this.FilterTb);
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
            // Yenile
            //
            this.Yenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Yenile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.Yenile.FlatAppearance.BorderSize = 0;
            this.Yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Yenile.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.Yenile.ForeColor = System.Drawing.Color.White;
            this.Yenile.Location = new System.Drawing.Point(666, 13);
            this.Yenile.Name = "Yenile";
            this.Yenile.Size = new System.Drawing.Size(64, 25);
            this.Yenile.TabIndex = 5;
            this.Yenile.Text = "Yenile";
            this.Yenile.UseVisualStyleBackColor = false;
            this.Yenile.Click += new System.EventHandler(this.Yenile_Click);
            //
            // button5
            //
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(600, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 25);
            this.button5.TabIndex = 4;
            this.button5.Text = "ARA";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            //
            // FilterTb
            //
            this.FilterTb.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FilterTb.Location = new System.Drawing.Point(474, 16);
            this.FilterTb.Name = "FilterTb";
            this.FilterTb.Size = new System.Drawing.Size(120, 20);
            this.FilterTb.TabIndex = 3;
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
            // KYonetimDgv
            //
            this.KYonetimDgv.Dock = System.Windows.Forms.DockStyle.Top;
            this.KYonetimDgv.Location = new System.Drawing.Point(0, 50);
            this.KYonetimDgv.Name = "KYonetimDgv";
            this.KYonetimDgv.Size = new System.Drawing.Size(740, 195);
            this.KYonetimDgv.TabIndex = 1;
            this.KYonetimDgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.KYonetimDgv_CellClick);
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
            this.button2.Location = new System.Drawing.Point(395, 380);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(110, 25);
            this.button2.TabIndex = 8;
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
            this.button4.Location = new System.Drawing.Point(510, 380);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(110, 25);
            this.button4.TabIndex = 9;
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
            this.button3.Location = new System.Drawing.Point(625, 380);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 25);
            this.button3.TabIndex = 10;
            this.button3.Text = "SİL";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // KayitYonetim
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(740, 415);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AciklamaTb);
            this.Controls.Add(this.SaatTb);
            this.Controls.Add(this.AdTb);
            this.Controls.Add(this.label_aciklama);
            this.Controls.Add(this.label_kursSaati);
            this.Controls.Add(this.label_kursAdi);
            this.Controls.Add(this.KYonetimDgv);
            this.Controls.Add(this.panel_ust);
            this.Name = "KayitYonetim";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KayitYonetim";
            this.Load += new System.EventHandler(this.KayitYonetim_Load);
            this.panel_ust.ResumeLayout(false);
            this.panel_ust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KYonetimDgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_ust;
        private System.Windows.Forms.Label label_geri;
        private System.Windows.Forms.Label label_baslik;
        private System.Windows.Forms.TextBox FilterTb;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Yenile;
        private Guna.UI2.WinForms.Guna2DataGridView KYonetimDgv;
        private System.Windows.Forms.Label label_kursAdi;
        private System.Windows.Forms.Label label_kursSaati;
        private System.Windows.Forms.Label label_aciklama;
        private System.Windows.Forms.TextBox AdTb;
        private System.Windows.Forms.TextBox SaatTb;
        private System.Windows.Forms.TextBox AciklamaTb;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
    }
}
