namespace EczaneStok
{
    partial class frmYonetici
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblStok = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnYoneticiEkle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHosgeldin
            // 
            this.lblHosgeldin.AutoSize = true;
            this.lblHosgeldin.Location = new System.Drawing.Point(42, 13);
            this.lblHosgeldin.Name = "lblHosgeldin";
            this.lblHosgeldin.Size = new System.Drawing.Size(79, 17);
            this.lblHosgeldin.TabIndex = 0;
            this.lblHosgeldin.Text = "Hoşgeldiniz,";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 61);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(443, 321);
            this.dataGridView1.TabIndex = 7;
            // 
            // lblStok
            // 
            this.lblStok.AutoSize = true;
            this.lblStok.Location = new System.Drawing.Point(13, 41);
            this.lblStok.Name = "lblStok";
            this.lblStok.Size = new System.Drawing.Size(135, 17);
            this.lblStok.TabIndex = 8;
            this.lblStok.Text = "Güncel Yönetici Listesi";
            // 
            // btnYenile
            // 
            this.btnYenile.Image = global::EczaneStok.Properties.Resources.yenile;
            this.btnYenile.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYenile.Location = new System.Drawing.Point(259, 28);
            this.btnYenile.Name = "btnYenile";
            this.btnYenile.Size = new System.Drawing.Size(70, 25);
            this.btnYenile.TabIndex = 9;
            this.btnYenile.Text = "Yenile";
            this.btnYenile.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = global::EczaneStok.Properties.Resources.user;
            this.pictureBox1.Image = global::EczaneStok.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // btnYoneticiEkle
            // 
            this.btnYoneticiEkle.Image = global::EczaneStok.Properties.Resources._16Ekle;
            this.btnYoneticiEkle.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnYoneticiEkle.Location = new System.Drawing.Point(335, 15);
            this.btnYoneticiEkle.Name = "btnYoneticiEkle";
            this.btnYoneticiEkle.Size = new System.Drawing.Size(120, 38);
            this.btnYoneticiEkle.TabIndex = 11;
            this.btnYoneticiEkle.Text = "Yönetici Ekle";
            this.btnYoneticiEkle.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnYoneticiEkle.UseVisualStyleBackColor = true;
            this.btnYoneticiEkle.Click += new System.EventHandler(this.btnYoneticiEkle_Click);
            // 
            // frmYonetici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 394);
            this.Controls.Add(this.btnYoneticiEkle);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnYenile);
            this.Controls.Add(this.lblStok);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblHosgeldin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmYonetici";
            this.Text = "Yönetici Listesi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmYonetici_FormClosed);
            this.Load += new System.EventHandler(this.frmYonetici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblStok;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnYoneticiEkle;
    }
}