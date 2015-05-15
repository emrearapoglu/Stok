namespace EczaneStok
{
    partial class frmUrunKayit
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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.lblTur = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Location = new System.Drawing.Point(42, 16);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(83, 17);
            this.lblHosgeldin.TabIndex = 0;
            this.lblHosgeldin.Text = "Hoşgeldiniz, ";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(12, 81);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(121, 25);
            this.txtAd.TabIndex = 1;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(9, 61);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(63, 17);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "Ürün İsmi";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(151, 81);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(121, 25);
            this.txtBarkod.TabIndex = 3;
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(148, 61);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(49, 17);
            this.lblBarkod.TabIndex = 4;
            this.lblBarkod.Text = "Barkod";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(292, 81);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(121, 25);
            this.txtStok.TabIndex = 5;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(289, 61);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(33, 17);
            this.lblStok.TabIndex = 6;
            this.lblStok.Text = "Stok";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(12, 155);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(121, 25);
            this.txtFiyat.TabIndex = 7;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(13, 135);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(34, 17);
            this.lblFiyat.TabIndex = 8;
            this.lblFiyat.Text = "Fiyat";
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Location = new System.Drawing.Point(12, 221);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(284, 95);
            this.rtbAciklama.TabIndex = 9;
            this.rtbAciklama.Text = "";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(13, 201);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(59, 17);
            this.lblAciklama.TabIndex = 10;
            this.lblAciklama.Text = "Açıklama";
            // 
            // cbTur
            // 
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Items.AddRange(new object[] {
            "Tablet",
            "Efervesan tablet",
            "Kapsül",
            "Flakon",
            "Ampul",
            "Krem",
            "Merhem",
            "Şampuan",
            "Toz",
            "Transdermal sistem",
            "İmplant sistem",
            "İnhaler sistem",
            "Süspansiyon",
            "Şurup",
            "Losyon",
            "Emülsiyon",
            "Damla",
            "Sprey"});
            this.cbTur.Location = new System.Drawing.Point(151, 155);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(121, 25);
            this.cbTur.TabIndex = 11;
            this.cbTur.Text = "Listeden seçiniz";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(148, 135);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(27, 17);
            this.lblTur.TabIndex = 12;
            this.lblTur.Text = "Tür";
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::EczaneStok.Properties.Resources.user;
            this.pictureBox1.Image = global::EczaneStok.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // btnEkle
            // 
            this.btnEkle.Image = global::EczaneStok.Properties.Resources.eklebuyuk1;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.Location = new System.Drawing.Point(302, 221);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(111, 95);
            this.btnEkle.TabIndex = 13;
            this.btnEkle.Text = "Yeni Ürün Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // frmUrunKayit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 328);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.rtbAciklama);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblHosgeldin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUrunKayit";
            this.Text = "Yeni Ürün Kaydı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmUrunKayit_FormClosed);
            this.Load += new System.EventHandler(this.frmUrunKayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}