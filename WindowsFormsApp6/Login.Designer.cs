namespace WindowsFormsApp6
{
    partial class Login
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
            this.label_logo = new System.Windows.Forms.Label();
            this.label_baslik = new System.Windows.Forms.Label();
            this.label_kullanici = new System.Windows.Forms.Label();
            this.label_sifre = new System.Windows.Forms.Label();
            this.KullaniciTb = new System.Windows.Forms.TextBox();
            this.SifreTb = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            //
            // label_logo
            //
            this.label_logo.AutoSize = true;
            this.label_logo.Font = new System.Drawing.Font("Times New Roman", 32F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label_logo.ForeColor = System.Drawing.Color.White;
            this.label_logo.Location = new System.Drawing.Point(24, 14);
            this.label_logo.Name = "label_logo";
            this.label_logo.Size = new System.Drawing.Size(51, 49);
            this.label_logo.TabIndex = 0;
            this.label_logo.Text = "G";
            //
            // label_baslik
            //
            this.label_baslik.AutoSize = true;
            this.label_baslik.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.label_baslik.ForeColor = System.Drawing.Color.White;
            this.label_baslik.Location = new System.Drawing.Point(150, 26);
            this.label_baslik.Name = "label_baslik";
            this.label_baslik.Size = new System.Drawing.Size(154, 25);
            this.label_baslik.TabIndex = 1;
            this.label_baslik.Text = "Geçer Dil Kursu";
            //
            // label_kullanici
            //
            this.label_kullanici.AutoSize = true;
            this.label_kullanici.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_kullanici.ForeColor = System.Drawing.Color.White;
            this.label_kullanici.Location = new System.Drawing.Point(64, 112);
            this.label_kullanici.Name = "label_kullanici";
            this.label_kullanici.Size = new System.Drawing.Size(65, 17);
            this.label_kullanici.TabIndex = 2;
            this.label_kullanici.Text = "Kullanıcı:";
            //
            // label_sifre
            //
            this.label_sifre.AutoSize = true;
            this.label_sifre.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_sifre.ForeColor = System.Drawing.Color.White;
            this.label_sifre.Location = new System.Drawing.Point(86, 148);
            this.label_sifre.Name = "label_sifre";
            this.label_sifre.Size = new System.Drawing.Size(43, 17);
            this.label_sifre.TabIndex = 4;
            this.label_sifre.Text = "Şifre:";
            //
            // KullaniciTb
            //
            this.KullaniciTb.Location = new System.Drawing.Point(134, 111);
            this.KullaniciTb.Name = "KullaniciTb";
            this.KullaniciTb.Size = new System.Drawing.Size(130, 20);
            this.KullaniciTb.TabIndex = 3;
            //
            // SifreTb
            //
            this.SifreTb.Location = new System.Drawing.Point(134, 147);
            this.SifreTb.Name = "SifreTb";
            this.SifreTb.PasswordChar = '*';
            this.SifreTb.Size = new System.Drawing.Size(130, 20);
            this.SifreTb.TabIndex = 5;
            //
            // button1
            //
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.button1.Location = new System.Drawing.Point(134, 200);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 30);
            this.button1.TabIndex = 6;
            this.button1.Text = "LOGİN";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            //
            // Login
            //
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(47)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(370, 270);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.SifreTb);
            this.Controls.Add(this.KullaniciTb);
            this.Controls.Add(this.label_sifre);
            this.Controls.Add(this.label_kullanici);
            this.Controls.Add(this.label_baslik);
            this.Controls.Add(this.label_logo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_logo;
        private System.Windows.Forms.Label label_baslik;
        private System.Windows.Forms.Label label_kullanici;
        private System.Windows.Forms.Label label_sifre;
        private System.Windows.Forms.TextBox KullaniciTb;
        private System.Windows.Forms.TextBox SifreTb;
        private System.Windows.Forms.Button button1;
    }
}
