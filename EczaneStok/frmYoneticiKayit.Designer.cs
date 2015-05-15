namespace EczaneStok
{
    partial class frmYoneticiKayit
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
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblIsim = new System.Windows.Forms.Label();
            this.txtIsim = new System.Windows.Forms.TextBox();
            this.btnYoneticiSifirla = new System.Windows.Forms.Button();
            this.btnYoneticiEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Location = new System.Drawing.Point(42, 16);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(83, 17);
            this.lblHosgeldin.TabIndex = 1;
            this.lblHosgeldin.Text = "Hoşgeldiniz, ";
            // 
            // lblKullaniciAdi
            // 
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(9, 53);
            this.lblKullaniciAdi.Name = "lblKullaniciAdi";
            this.lblKullaniciAdi.Size = new System.Drawing.Size(78, 17);
            this.lblKullaniciAdi.TabIndex = 2;
            this.lblKullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // txtKullaniciAdi
            // 
            this.txtKullaniciAdi.Location = new System.Drawing.Point(12, 73);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(121, 25);
            this.txtKullaniciAdi.TabIndex = 3;
            // 
            // lblSifre
            // 
            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(9, 116);
            this.lblSifre.Name = "lblSifre";
            this.lblSifre.Size = new System.Drawing.Size(34, 17);
            this.lblSifre.TabIndex = 4;
            this.lblSifre.Text = "Şifre";
            // 
            // txtSifre
            // 
            this.txtSifre.Location = new System.Drawing.Point(12, 136);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(121, 25);
            this.txtSifre.TabIndex = 5;
            // 
            // lblIsim
            // 
            this.lblIsim.AutoSize = true;
            this.lblIsim.Location = new System.Drawing.Point(9, 180);
            this.lblIsim.Name = "lblIsim";
            this.lblIsim.Size = new System.Drawing.Size(31, 17);
            this.lblIsim.TabIndex = 6;
            this.lblIsim.Text = "İsim";
            // 
            // txtIsim
            // 
            this.txtIsim.Location = new System.Drawing.Point(12, 200);
            this.txtIsim.Name = "txtIsim";
            this.txtIsim.Size = new System.Drawing.Size(121, 25);
            this.txtIsim.TabIndex = 7;
            // 
            // btnYoneticiSifirla
            // 
            this.btnYoneticiSifirla.Image = global::EczaneStok.Properties.Resources.sifirla;
            this.btnYoneticiSifirla.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoneticiSifirla.Location = new System.Drawing.Point(163, 105);
            this.btnYoneticiSifirla.Name = "btnYoneticiSifirla";
            this.btnYoneticiSifirla.Size = new System.Drawing.Size(140, 38);
            this.btnYoneticiSifirla.TabIndex = 9;
            this.btnYoneticiSifirla.Text = "Yöneticileri Sıfırla";
            this.btnYoneticiSifirla.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYoneticiSifirla.UseVisualStyleBackColor = true;
            this.btnYoneticiSifirla.Click += new System.EventHandler(this.btnYoneticiSifirla_Click);
            // 
            // btnYoneticiEkle
            // 
            this.btnYoneticiEkle.Image = global::EczaneStok.Properties.Resources._16Ekle;
            this.btnYoneticiEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoneticiEkle.Location = new System.Drawing.Point(163, 169);
            this.btnYoneticiEkle.Name = "btnYoneticiEkle";
            this.btnYoneticiEkle.Size = new System.Drawing.Size(140, 38);
            this.btnYoneticiEkle.TabIndex = 8;
            this.btnYoneticiEkle.Text = "Yeni Yönetici Ekle";
            this.btnYoneticiEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYoneticiEkle.UseVisualStyleBackColor = true;
            this.btnYoneticiEkle.Click += new System.EventHandler(this.btnYoneticiEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EczaneStok.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmYoneticiKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 256);
            this.Controls.Add(this.btnYoneticiSifirla);
            this.Controls.Add(this.btnYoneticiEkle);
            this.Controls.Add(this.txtIsim);
            this.Controls.Add(this.lblIsim);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblHosgeldin);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmYoneticiKayit";
            this.Text = "Yönetici Kayıt Formu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmYoneticiKayit_FormClosed);
            this.Load += new System.EventHandler(this.frmYoneticiKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.Label lblSifre;
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblIsim;
        private System.Windows.Forms.TextBox txtIsim;
        private System.Windows.Forms.Button btnYoneticiEkle;
        private System.Windows.Forms.Button btnYoneticiSifirla;
    }
}