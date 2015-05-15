namespace EczaneStok
{
    partial class frmStokEkrani
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
            this.lblStok = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnArama = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnUrunKaydi = new System.Windows.Forms.Button();
            this.btnListe = new System.Windows.Forms.Button();
            this.lnkKritikStok = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Location = new System.Drawing.Point(42, 12);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(79, 17);
            this.lblHosgeldin.TabIndex = 0;
            this.lblHosgeldin.Text = "Hoşgeldiniz,";
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(16, 91);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(126, 17);
            this.lblStok.TabIndex = 4;
            this.lblStok.Text = "Güncel Stok Durumu";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(856, 416);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnArama
            // 
            this.btnArama.Image = global::EczaneStok.Properties.Resources.arama;
            this.btnArama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArama.Location = new System.Drawing.Point(288, 46);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(80, 38);
            this.btnArama.TabIndex = 8;
            this.btnArama.Text = "Arama";
            this.btnArama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::EczaneStok.Properties.Resources.user;
            this.pictureBox1.Image = global::EczaneStok.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // btnYenile
            // 
            this.btnYenile.Image = global::EczaneStok.Properties.Resources.yenile;
            this.btnYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYenile.Location = new System.Drawing.Point(798, 80);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(70, 25);
            this.btnYenile.TabIndex = 5;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Image = global::EczaneStok.Properties.Resources.cikis;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCikis.Location = new System.Drawing.Point(773, 9);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(95, 38);
            this.btnCikis.TabIndex = 3;
            this.btnCikis.Text = "Çıkış Yap";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnUrunKaydi
            // 
            this.btnUrunKaydi.Image = global::EczaneStok.Properties.Resources._16Ekle;
            this.btnUrunKaydi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUrunKaydi.Location = new System.Drawing.Point(147, 46);
            this.btnUrunKaydi.Name = "btnUrunKaydi";
            this.btnUrunKaydi.Size = new System.Drawing.Size(135, 38);
            this.btnUrunKaydi.TabIndex = 2;
            this.btnUrunKaydi.Text = "Yeni Ürün Kaydı";
            this.btnUrunKaydi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUrunKaydi.UseVisualStyleBackColor = true;
            this.btnUrunKaydi.Click += new System.EventHandler(this.btnUrunKaydi_Click);
            // 
            // btnListe
            // 
            this.btnListe.Image = global::EczaneStok.Properties.Resources.admin;
            this.btnListe.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListe.Location = new System.Drawing.Point(16, 46);
            this.btnListe.Name = "btnListe";
            this.btnListe.Size = new System.Drawing.Size(125, 38);
            this.btnListe.TabIndex = 1;
            this.btnListe.Text = "Yönetici Listesi";
            this.btnListe.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnListe.UseVisualStyleBackColor = true;
            this.btnListe.Click += new System.EventHandler(this.btnListe_Click);
            // 
            // lnkKritikStok
            // 
            this.lnkKritikStok.AutoSize = true;
            this.lnkKritikStok.Location = new System.Drawing.Point(362, 91);
            this.lnkKritikStok.Name = "lnkKritikStok";
            this.lnkKritikStok.Size = new System.Drawing.Size(214, 17);
            this.lnkKritikStok.TabIndex = 9;
            this.lnkKritikStok.TabStop = true;
            this.lnkKritikStok.Text = "Stok durumu kritik olan ürün sayısı: ";
            this.lnkKritikStok.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkKritikStok_LinkClicked);
            // 
            // frmStokEkrani
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 539);
            this.ControlBox = false;
            this.Controls.Add(this.lnkKritikStok);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnUrunKaydi);
            this.Controls.Add(this.btnListe);
            this.Controls.Add(this.lblHosgeldin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmStokEkrani";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eczane İlaç Stoğu";
            this.Load += new System.EventHandler(this.frmStokEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.Button btnListe;
        private System.Windows.Forms.Button btnUrunKaydi;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.LinkLabel lnkKritikStok;
    }
}