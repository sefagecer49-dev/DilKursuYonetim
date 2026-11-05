namespace WindowsFormsApp6
{
    partial class KursYazdir
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
            this.label9 = new System.Windows.Forms.Label();
            this.Yenile = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.FilterTb = new System.Windows.Forms.TextBox();
            this.label_baslik = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.KYonetimDgv = new Guna.UI2.WinForms.Guna2DataGridView();
            this.button3 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.panel_ust.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KYonetimDgv)).BeginInit();
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
            this.label9.TabIndex = 4;
            this.label9.Text = "<<<";
            this.label9.Click += new System.EventHandler(this.label9_Click);
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
            this.Yenile.TabIndex = 3;
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
            this.button5.Location = new System.Drawing.Point(580, 13);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(60, 25);
            this.button5.TabIndex = 2;
            this.button5.Text = "Ara";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
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
            this.label_baslik.Text = "Kurs Listesi";
            this.label_baslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // label1
            //
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(720, 30);
            this.label1.TabIndex = 3;
            this.label1.Text = "Kurs Listesi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //
            // KYonetimDgv
            //
            this.KYonetimDgv.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.KYonetimDgv.Location = new System.Drawing.Point(8, 102);
            this.KYonetimDgv.Name = "KYonetimDgv";
            this.KYonetimDgv.Size = new System.Drawing.Size(704, 260);
            this.KYonetimDgv.TabIndex = 1;
            //
            // button3
            //
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(600, 381);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(110, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "YAZDIR";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            //
            // printDocument1
            //
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            //
            // printPreviewDialog1
            //
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            //
            // KursYazdir
            //
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(720, 415);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.KYonetimDgv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel_ust);
            this.Name = "KursYazdir";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KursYazdir";
            this.Load += new System.EventHandler(this.KursYazdir_Load);
            this.panel_ust.ResumeLayout(false);
            this.panel_ust.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KYonetimDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_ust;
        private System.Windows.Forms.Label label_baslik;
        private System.Windows.Forms.TextBox FilterTb;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button Yenile;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DataGridView KYonetimDgv;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label9;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}
