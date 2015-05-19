namespace EczaneStok
{
    partial class frmDuzenle
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHosgeldin = new System.Windows.Forms.Label();
            this.btnListele = new System.Windows.Forms.Button();
            this.lblUrunID = new System.Windows.Forms.Label();
            this.txtDuzenleID = new System.Windows.Forms.TextBox();
            this.lblBarkod = new System.Windows.Forms.Label();
            this.txtBarkod = new System.Windows.Forms.TextBox();
            this.lblTur = new System.Windows.Forms.Label();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtStok = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblKod = new System.Windows.Forms.Label();
            this.txtKod = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.rtbAciklama = new System.Windows.Forms.RichTextBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Location = new System.Drawing.Point(43, 16);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(83, 17);
            this.lblHosgeldin.TabIndex = 1;
            this.lblHosgeldin.Text = "Hoşgeldiniz, ";
            // 
            // btnListele
            // 
            this.btnListele.Location = new System.Drawing.Point(119, 72);
            this.btnListele.Name = "btnListele";
            this.btnListele.Size = new System.Drawing.Size(100, 30);
            this.btnListele.TabIndex = 2;
            this.btnListele.Text = "Ürünü Göster";
            this.btnListele.UseVisualStyleBackColor = true;
            this.btnListele.Click += new System.EventHandler(this.btnListele_Click);
            // 
            // lblUrunID
            // 
            this.lblUrunID.AutoSize = true;
            this.lblUrunID.Location = new System.Drawing.Point(9, 51);
            this.lblUrunID.Name = "lblUrunID";
            this.lblUrunID.Size = new System.Drawing.Size(264, 17);
            this.lblUrunID.TabIndex = 3;
            this.lblUrunID.Text = "Düzenlemek istediğiniz ürünün ID\'sini giriniz.";
            // 
            // txtDuzenleID
            // 
            this.txtDuzenleID.Location = new System.Drawing.Point(13, 72);
            this.txtDuzenleID.Name = "txtDuzenleID";
            this.txtDuzenleID.Size = new System.Drawing.Size(100, 25);
            this.txtDuzenleID.TabIndex = 4;
            // 
            // lblBarkod
            // 
            this.lblBarkod.AutoSize = true;
            this.lblBarkod.Location = new System.Drawing.Point(139, 128);
            this.lblBarkod.Name = "lblBarkod";
            this.lblBarkod.Size = new System.Drawing.Size(49, 17);
            this.lblBarkod.TabIndex = 7;
            this.lblBarkod.Text = "Barkod";
            // 
            // txtBarkod
            // 
            this.txtBarkod.Location = new System.Drawing.Point(142, 148);
            this.txtBarkod.Name = "txtBarkod";
            this.txtBarkod.Size = new System.Drawing.Size(100, 25);
            this.txtBarkod.TabIndex = 8;
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(271, 128);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(27, 17);
            this.lblTur.TabIndex = 9;
            this.lblTur.Text = "Tür";
            // 
            // cbTur
            // 
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Items.AddRange(new object[] {
            "Ampul",
            "Damla",
            "Efervesan tablet",
            "Emülsiyon",
            "Flakon",
            "Implant sistem",
            "Inhaler sistem",
            "Kapsül",
            "Krem",
            "Losyon",
            "Merhem",
            "Sampuan",
            "Sprey",
            "Surup",
            "Süspansiyon",
            "Tablet",
            "Toz",
            "Transdermal sistem"});
            this.cbTur.Location = new System.Drawing.Point(274, 148);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(121, 25);
            this.cbTur.TabIndex = 10;
            this.cbTur.Text = "Listeden Seçiniz";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(9, 201);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(33, 17);
            this.lblStok.TabIndex = 11;
            this.lblStok.Text = "Stok";
            // 
            // txtStok
            // 
            this.txtStok.Location = new System.Drawing.Point(12, 221);
            this.txtStok.Name = "txtStok";
            this.txtStok.Size = new System.Drawing.Size(100, 25);
            this.txtStok.TabIndex = 12;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(139, 201);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(34, 17);
            this.lblFiyat.TabIndex = 13;
            this.lblFiyat.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(142, 221);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(100, 25);
            this.txtFiyat.TabIndex = 14;
            // 
            // lblKod
            // 
            this.lblKod.AutoSize = true;
            this.lblKod.Location = new System.Drawing.Point(271, 201);
            this.lblKod.Name = "lblKod";
            this.lblKod.Size = new System.Drawing.Size(114, 17);
            this.lblKod.TabIndex = 15;
            this.lblKod.Text = "Geri Ödeme Kodu";
            // 
            // txtKod
            // 
            this.txtKod.Location = new System.Drawing.Point(274, 221);
            this.txtKod.Name = "txtKod";
            this.txtKod.Size = new System.Drawing.Size(100, 25);
            this.txtKod.TabIndex = 16;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(9, 268);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(59, 17);
            this.lblAciklama.TabIndex = 17;
            this.lblAciklama.Text = "Açıklama";
            // 
            // rtbAciklama
            // 
            this.rtbAciklama.Location = new System.Drawing.Point(12, 288);
            this.rtbAciklama.Name = "rtbAciklama";
            this.rtbAciklama.Size = new System.Drawing.Size(261, 67);
            this.rtbAciklama.TabIndex = 18;
            this.rtbAciklama.Text = "";
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(283, 288);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(110, 67);
            this.btnDuzenle.TabIndex = 19;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(9, 128);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(24, 17);
            this.lblAd.TabIndex = 20;
            this.lblAd.Text = "Ad";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(12, 148);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(100, 25);
            this.txtAd.TabIndex = 21;
            // 
            // frmDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 377);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.rtbAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtKod);
            this.Controls.Add(this.lblKod);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtStok);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.txtBarkod);
            this.Controls.Add(this.lblBarkod);
            this.Controls.Add(this.txtDuzenleID);
            this.Controls.Add(this.lblUrunID);
            this.Controls.Add(this.btnListele);
            this.Controls.Add(this.lblHosgeldin);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(421, 406);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(421, 406);
            this.Name = "frmDuzenle";
            this.Text = "Stok Düzenleme";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmDuzenle_FormClosed);
            this.Load += new System.EventHandler(this.frmDuzenle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.Button btnListele;
        private System.Windows.Forms.Label lblUrunID;
        private System.Windows.Forms.TextBox txtDuzenleID;
        private System.Windows.Forms.Label lblBarkod;
        private System.Windows.Forms.TextBox txtBarkod;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox txtStok;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblKod;
        private System.Windows.Forms.TextBox txtKod;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.RichTextBox rtbAciklama;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
    }
}