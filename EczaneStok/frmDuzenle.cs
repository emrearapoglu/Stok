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
    public partial class frmDuzenle : Form
    {
        public frmDuzenle()
        {
            InitializeComponent();
        }

        private void frmDuzenle_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStokEkrani.duzenleform = false;
        }
        
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        string id;

        private void btnListele_Click(object sender, EventArgs e)
        {
            if (txtDuzenleID.Text != "")
            {
                id = txtDuzenleID.Text;
                string query = "SELECT * FROM ilac WHERE id = " + id;

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        txtAd.Text = dataReader.GetString("ad");
                        txtBarkod.Text = dataReader.GetString("barkod");
                        txtFiyat.Text = dataReader.GetString("fiyat");
                        txtKod.Text = dataReader.GetString("GeriOdemeKodu");
                        txtStok.Text = dataReader.GetString("stok");
                        rtbAciklama.Text = dataReader.GetString("aciklama");
                        cbTur.SelectedItem = dataReader.GetString("tur");
                    }

                    dataReader.Close();

                    this.CloseConnection();
                }

                txtAd.Enabled = true;
                txtBarkod.Enabled = true;
                txtFiyat.Enabled = true;
                txtKod.Enabled = true;
                txtStok.Enabled = true;
                cbTur.Enabled = true;
                rtbAciklama.Enabled = true;
                btnDuzenle.Enabled = true;
            }
            else
            {
                MessageBox.Show("Boş alan bırakmayın", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmDuzenle_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "okulprojesi";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            txtAd.Enabled = false;
            txtBarkod.Enabled = false;
            txtFiyat.Enabled = false;
            txtKod.Enabled = false;
            txtStok.Enabled = false;
            cbTur.Enabled = false;
            rtbAciklama.Enabled = false;
            btnDuzenle.Enabled = false;
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

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            string ad = txtAd.Text;
            string barkod = txtBarkod.Text;
            string stok = txtStok.Text;
            string fiyat = txtFiyat.Text;
            string kod = txtKod.Text;
            string tur = cbTur.Text;
            string aciklama = rtbAciklama.Text;

            if (ad != "" && barkod != "" && stok != "" && fiyat != "" && kod != "" && tur != "" && aciklama != "")
            {
                string query = "UPDATE `okulprojesi`.`ilac` SET `ad` = '" + ad + "', `barkod` = '" + barkod + "', `tur` = '" + tur + "', `stok` = '" + stok + "', `aciklama` = '" + aciklama + "', `fiyat` = '" + fiyat + "', `GeriOdemeKodu` = '" + kod + "' WHERE `ilac`.`id` = " + id;

                if (this.OpenConnection() == true)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        int q = cmd.ExecuteNonQuery();
                        if (q != 0)
                        {
                            MessageBox.Show("ID'si " + id + " olan ürün, başarıyla güncellendi.", "Ürün Güncellendi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            txtAd.Enabled = false;
                            txtBarkod.Enabled = false;
                            txtFiyat.Enabled = false;
                            txtKod.Enabled = false;
                            txtStok.Enabled = false;
                            cbTur.Enabled = false;
                            rtbAciklama.Enabled = false;
                            btnDuzenle.Enabled = false;

                            txtAd.Text = "";
                            txtBarkod.Text = "";
                            txtDuzenleID.Text = "";
                            txtFiyat.Text = "";
                            txtKod.Text = "";
                            txtStok.Text = "";
                            rtbAciklama.Text = "";
                            cbTur.SelectedIndex = -1;

                        }

                        this.CloseConnection();
                    }
                    catch
                    {
                        MessageBox.Show("Girdiğiniz bilgileri kontrol ederek tekrar deneyiniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        this.CloseConnection();
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
