namespace EczaneStok
{
    partial class frmSatis
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
            this.lblUrunID = new System.Windows.Forms.Label();
            this.txtUrunID = new System.Windows.Forms.TextBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblTur = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblAded = new System.Windows.Forms.Label();
            this.lblStok = new System.Windows.Forms.Label();
            this.txtAded = new System.Windows.Forms.TextBox();
            this.btnGoster = new System.Windows.Forms.Button();
            this.btnSatis = new System.Windows.Forms.Button();
            this.lblSatisYapildi = new System.Windows.Forms.Label();
            this.lblTopFiyat = new System.Windows.Forms.Label();
            this.lblKalanStok = new System.Windows.Forms.Label();
            this.btnSifirla = new System.Windows.Forms.Button();
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
            // lblUrunID
            // 
            this.lblUrunID.AutoSize = true;
            this.lblUrunID.Location = new System.Drawing.Point(12, 60);
            this.lblUrunID.Name = "lblUrunID";
            this.lblUrunID.Size = new System.Drawing.Size(219, 17);
            this.lblUrunID.TabIndex = 2;
            this.lblUrunID.Text = "1) Satış yapılan ürünün ID\'sini giriniz.";
            // 
            // txtUrunID
            // 
            this.txtUrunID.Location = new System.Drawing.Point(15, 81);
            this.txtUrunID.Name = "txtUrunID";
            this.txtUrunID.Size = new System.Drawing.Size(133, 25);
            this.txtUrunID.TabIndex = 3;
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(15, 120);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(31, 17);
            this.lblAd.TabIndex = 6;
            this.lblAd.Text = "Ad: ";
            // 
            // lblTur
            // 
            this.lblTur.AutoSize = true;
            this.lblTur.Location = new System.Drawing.Point(15, 146);
            this.lblTur.Name = "lblTur";
            this.lblTur.Size = new System.Drawing.Size(34, 17);
            this.lblTur.TabIndex = 7;
            this.lblTur.Text = "Tür: ";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(15, 174);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(41, 17);
            this.lblFiyat.TabIndex = 8;
            this.lblFiyat.Text = "Fiyat: ";
            // 
            // lblAded
            // 
            this.lblAded.AutoSize = true;
            this.lblAded.Location = new System.Drawing.Point(260, 60);
            this.lblAded.Name = "lblAded";
            this.lblAded.Size = new System.Drawing.Size(186, 17);
            this.lblAded.TabIndex = 9;
            this.lblAded.Text = "2) Satış yapılacak adedi giriniz.";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(15, 201);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(40, 17);
            this.lblStok.TabIndex = 10;
            this.lblStok.Text = "Stok: ";
            // 
            // txtAded
            // 
            this.txtAded.Location = new System.Drawing.Point(263, 81);
            this.txtAded.Name = "txtAded";
            this.txtAded.Size = new System.Drawing.Size(100, 25);
            this.txtAded.TabIndex = 11;
            // 
            // btnGoster
            // 
            this.btnGoster.Location = new System.Drawing.Point(155, 81);
            this.btnGoster.Name = "btnGoster";
            this.btnGoster.Size = new System.Drawing.Size(60, 25);
            this.btnGoster.TabIndex = 12;
            this.btnGoster.Text = "Göster";
            this.btnGoster.UseVisualStyleBackColor = true;
            this.btnGoster.Click += new System.EventHandler(this.btnGoster_Click);
            // 
            // btnSatis
            // 
            this.btnSatis.Location = new System.Drawing.Point(369, 81);
            this.btnSatis.Name = "btnSatis";
            this.btnSatis.Size = new System.Drawing.Size(75, 25);
            this.btnSatis.TabIndex = 13;
            this.btnSatis.Text = "Satış Yap";
            this.btnSatis.UseVisualStyleBackColor = true;
            this.btnSatis.Click += new System.EventHandler(this.btnSatis_Click);
            // 
            // lblSatisYapildi
            // 
            this.lblSatisYapildi.AutoSize = true;
            this.lblSatisYapildi.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSatisYapildi.Location = new System.Drawing.Point(260, 174);
            this.lblSatisYapildi.Name = "lblSatisYapildi";
            this.lblSatisYapildi.Size = new System.Drawing.Size(170, 20);
            this.lblSatisYapildi.TabIndex = 14;
            this.lblSatisYapildi.Text = "Satış işlemi gerçekleşti.";
            // 
            // lblTopFiyat
            // 
            this.lblTopFiyat.AutoSize = true;
            this.lblTopFiyat.Location = new System.Drawing.Point(260, 120);
            this.lblTopFiyat.Name = "lblTopFiyat";
            this.lblTopFiyat.Size = new System.Drawing.Size(184, 17);
            this.lblTopFiyat.TabIndex = 15;
            this.lblTopFiyat.Text = "Satılan ürünlerin toplam fiyatı: ";
            // 
            // lblKalanStok
            // 
            this.lblKalanStok.AutoSize = true;
            this.lblKalanStok.Location = new System.Drawing.Point(260, 146);
            this.lblKalanStok.Name = "lblKalanStok";
            this.lblKalanStok.Size = new System.Drawing.Size(118, 17);
            this.lblKalanStok.TabIndex = 16;
            this.lblKalanStok.Text = "Kalan stok miktarı: ";
            // 
            // btnSifirla
            // 
            this.btnSifirla.Location = new System.Drawing.Point(334, 12);
            this.btnSifirla.Name = "btnSifirla";
            this.btnSifirla.Size = new System.Drawing.Size(140, 30);
            this.btnSifirla.TabIndex = 17;
            this.btnSifirla.Text = "Tüm Alanları Sıfırla";
            this.btnSifirla.UseVisualStyleBackColor = true;
            this.btnSifirla.Click += new System.EventHandler(this.btnSifirla_Click);
            // 
            // frmSatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(486, 231);
            this.Controls.Add(this.btnSifirla);
            this.Controls.Add(this.lblKalanStok);
            this.Controls.Add(this.lblTopFiyat);
            this.Controls.Add(this.lblSatisYapildi);
            this.Controls.Add(this.btnSatis);
            this.Controls.Add(this.btnGoster);
            this.Controls.Add(this.txtAded);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.lblAded);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblTur);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.txtUrunID);
            this.Controls.Add(this.lblUrunID);
            this.Controls.Add(this.lblHosgeldin);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSatis";
            this.Text = "Satış Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSatis_FormClosed);
            this.Load += new System.EventHandler(this.frmSatis_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.Label lblUrunID;
        private System.Windows.Forms.TextBox txtUrunID;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblTur;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblAded;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.TextBox txtAded;
        private System.Windows.Forms.Button btnGoster;
        private System.Windows.Forms.Button btnSatis;
        private System.Windows.Forms.Label lblSatisYapildi;
        private System.Windows.Forms.Label lblTopFiyat;
        private System.Windows.Forms.Label lblKalanStok;
        private System.Windows.Forms.Button btnSifirla;
    }
}