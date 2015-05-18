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
    public partial class frmSatis : Form
    {
        public frmSatis()
        {
            InitializeComponent();
        }

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        private void frmSatis_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStokEkrani.satisform = false;
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "okulprojesi";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);

            txtAded.Enabled = false;
            btnSatis.Enabled = false;
            
            lblAd.Visible = false;
            lblTur.Visible = false;
            lblFiyat.Visible = false;
            lblStok.Visible = false;

            lblSatisYapildi.Visible = false;
            lblTopFiyat.Visible = false;
            lblKalanStok.Visible = false;
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

        string stokdb;
        string id;
        string fiyatdb;

        private void btnGoster_Click(object sender, EventArgs e)
        {
            if (txtUrunID.Text != "")
            {
                id = txtUrunID.Text;
                string query = "SELECT * FROM ilac WHERE id="+id;

                if (this.OpenConnection() == true)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        MySqlDataReader dataReader = cmd.ExecuteReader();

                        while (dataReader.Read())
                        {
                            string addb = dataReader.GetString("ad");
                            string turdb = dataReader.GetString("tur");
                            fiyatdb = dataReader.GetString("fiyat");
                            stokdb = dataReader.GetString("stok");

                            lblAd.Text = "Ad: " + addb;
                            lblTur.Text = "Tür: " + turdb;
                            lblFiyat.Text = "Fiyat: " + fiyatdb + " TL";
                            lblStok.Text = "Stok: " + stokdb;

                            lblAd.Visible = true;
                            lblTur.Visible = true;
                            lblFiyat.Visible = true;
                            lblStok.Visible = true;

                            txtAded.Enabled = true;
                            btnSatis.Enabled = true;
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

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            txtAded.Text = "";
            txtUrunID.Text = "";

            txtAded.Enabled = false;
            btnSatis.Enabled = false;

            lblAd.Visible = false;
            lblTur.Visible = false;
            lblFiyat.Visible = false;
            lblStok.Visible = false;

            lblSatisYapildi.Visible = false;
            lblTopFiyat.Visible = false;
            lblKalanStok.Visible = false;
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            if (txtAded.Text != "")
            {
                string aded = txtAded.Text;
                int stok = Convert.ToInt32(stokdb) - Convert.ToInt32(aded);

                string query = "UPDATE `okulprojesi`.`ilac` SET `stok` = '" + stok + "' WHERE `ilac`.`id` = "+id;

                if (this.OpenConnection() == true)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        int q = cmd.ExecuteNonQuery();
                        if (q != 0)
                        {
                            lblSatisYapildi.Visible = true;
                            lblTopFiyat.Visible = true;
                            lblKalanStok.Visible = true;

                            lblTopFiyat.Text = "Satılan ürünlerin toplam fiyatı: " + Convert.ToInt32(fiyatdb) * Convert.ToInt32(aded) + " TL";
                            lblKalanStok.Text = "Kalan stok miktarı: " + stok;
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
