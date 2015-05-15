using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace EczaneStok
{
    public partial class frmUrunKayit : Form
    {
        public frmUrunKayit()
        {
            InitializeComponent();
        }

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        private void frmUrunKayit_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "okulprojesi";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            lblHosgeldin.Text = "Hoşgeldiniz, " + frmGiris.isim + ".";
        }

        private bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {
                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Veritabanına bağlanılamıyor. Yönetici ile görüşün.");
                        break;

                    case 1045:
                        MessageBox.Show("Kullanıcı adı veya şifre yanlış. Tekrar deneyin.");
                        break;
                }
                return false;
            }
        }

        private bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        private void frmUrunKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStokEkrani.urunkayitform = false;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string barkod = txtBarkod.Text;
            string stok = txtStok.Text;
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            string aciklama = rtbAciklama.Text;
            string tur = cbTur.Text;
            string geriodeme = txtGeriOdeme.Text;

            string query = "INSERT INTO `okulprojesi`.`ilac` (`id`, `ad`, `barkod`, `tur`, `stok`, `aciklama`, `fiyat`, `GeriOdemeKodu`) VALUES (NULL, '" + ad + "', '" + barkod + "', '" + tur + "', '" + stok + "', '" + aciklama + "', '" + fiyat + "', '" + geriodeme + "')";
            if (ad != "" && barkod != "" && stok != "" && fiyat != 0 && aciklama != "" && tur != "" && geriodeme != "")
            {
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    int q = cmd.ExecuteNonQuery();
                    if (q != 0)
                    {
                        MessageBox.Show("Ürün başarıyla eklendi. Stok sayfasını yenileyiniz.", "Yeni ürün eklendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtAd.Text = "";
                        txtBarkod.Text = "";
                        txtStok.Text = "";
                        txtFiyat.Text = "";
                        rtbAciklama.Text = "";
                        cbTur.Text = "";
                        txtGeriOdeme.Text = "";
                    }

                    this.CloseConnection();
                }
                else
                {
                    DialogResult err = MessageBox.Show("Veritabanıyla bağlantı kurulamadı.\nUygulama kapatılacak.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    if (err == DialogResult.OK)
                    {
                        Application.Exit();
                    }
                }
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayınız.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
