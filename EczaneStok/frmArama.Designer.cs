namespace EczaneStok
{
    partial class frmArama
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cbTur = new System.Windows.Forms.ComboBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.txtAranan = new System.Windows.Forms.TextBox();
            this.lblAranan = new System.Windows.Forms.Label();
            this.btnArama = new System.Windows.Forms.Button();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // pictureBox1
            // 
            this.pictureBox1.Image = global::EczaneStok.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 24);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // cbTur
            // 
            this.cbTur.FormattingEnabled = true;
            this.cbTur.Items.AddRange(new object[] {
            "ID",
            "AD",
            "TÜR",
            "STOK",
            "FİYAT",
            "BARKOD",
            "AÇIKLAMA",
            "GERİ ÖDEME KODU"});
            this.cbTur.Location = new System.Drawing.Point(177, 66);
            this.cbTur.Name = "cbTur";
            this.cbTur.Size = new System.Drawing.Size(121, 25);
            this.cbTur.TabIndex = 2;
            this.cbTur.Text = "Seçim Yapınız";
            // 
            // lblArama
            // 
            this.lblArama.AutoSize = true;
            this.lblArama.Location = new System.Drawing.Point(174, 46);
            this.lblArama.Name = "lblArama";
            this.lblArama.Size = new System.Drawing.Size(76, 17);
            this.lblArama.TabIndex = 3;
            this.lblArama.Text = "Arama Türü";
            // 
            // txtAranan
            // 
            this.txtAranan.Location = new System.Drawing.Point(12, 66);
            this.txtAranan.Name = "txtAranan";
            this.txtAranan.Size = new System.Drawing.Size(148, 25);
            this.txtAranan.TabIndex = 4;
            // 
            // lblAranan
            // 
            this.lblAranan.AutoSize = true;
            this.lblAranan.Location = new System.Drawing.Point(9, 46);
            this.lblAranan.Name = "lblAranan";
            this.lblAranan.Size = new System.Drawing.Size(104, 17);
            this.lblAranan.TabIndex = 5;
            this.lblAranan.Text = "Aranacak Kelime";
            // 
            // btnArama
            // 
            this.btnArama.Image = global::EczaneStok.Properties.Resources.arama;
            this.btnArama.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnArama.Location = new System.Drawing.Point(318, 53);
            this.btnArama.Name = "btnArama";
            this.btnArama.Size = new System.Drawing.Size(65, 38);
            this.btnArama.TabIndex = 9;
            this.btnArama.Text = "Ara";
            this.btnArama.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnArama.UseVisualStyleBackColor = true;
            this.btnArama.Click += new System.EventHandler(this.btnArama_Click);
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(12, 105);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(43, 17);
            this.lblSonuc.TabIndex = 11;
            this.lblSonuc.Text = "label1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 125);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.ShowEditingIcon = false;
            this.dataGridView1.Size = new System.Drawing.Size(856, 173);
            this.dataGridView1.TabIndex = 12;
            // 
            // frmArama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(880, 310);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.btnArama);
            this.Controls.Add(this.lblAranan);
            this.Controls.Add(this.txtAranan);
            this.Controls.Add(this.lblArama);
            this.Controls.Add(this.cbTur);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblHosgeldin);
            this.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmArama";
            this.Text = "Arama Ekranı";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmArama_FormClosed);
            this.Load += new System.EventHandler(this.frmArama_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHosgeldin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cbTur;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.TextBox txtAranan;
        private System.Windows.Forms.Label lblAranan;
        private System.Windows.Forms.Button btnArama;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}