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
    public partial class frmYoneticiKayit : Form
    {
        public frmYoneticiKayit()
        {
            InitializeComponent();
        }

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        private void frmYoneticiKayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStokEkrani.yoneticikayitform = false;
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

        private void frmYoneticiKayit_Load(object sender, EventArgs e)
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

        private void btnYoneticiSifirla_Click(object sender, EventArgs e)
        {
            DialogResult err = MessageBox.Show("Yönetici hesaplarını sıfırlamak istediğinize emin misiniz?\n\nBu seçencek root hariç diğer tüm yönetici hesaplarını siler.\n\nBU İŞLEMİN GERİ DÖNÜŞÜ YOKTUR", "Emin Misiniz?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (err == DialogResult.Yes)
            {
                string query = "truncate admins";
                string query2 = "INSERT INTO `okulprojesi`.`admins` (`id`, `username`, `password`, `isim`) VALUES (NULL, 'root', 'root', 'root')";
                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlCommand cmd2 = new MySqlCommand(query2, connection);
                    int q = cmd.ExecuteNonQuery();
                    int q2 = cmd2.ExecuteNonQuery();
                    if (q2 != 0)
                    {
                        MessageBox.Show("Yönetici hesapları başarıyla sıfırlandı.", "Veritabanı Sıfırlandı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        txtIsim.Text = "";
                        txtKullaniciAdi.Text = "";
                        txtSifre.Text = "";
                    }

                    this.CloseConnection();
                }
            }
        }

        private void btnYoneticiEkle_Click(object sender, EventArgs e)
        {
            string username = txtKullaniciAdi.Text;
            string isim = txtIsim.Text;
            string password = txtSifre.Text;

            if (username != "" && isim != "" && password != "")
            {
                string query = "INSERT INTO `okulprojesi`.`admins` (`id`, `username`, `password`, `isim`) VALUES (NULL, '"+username+"', '"+password+"', '"+isim+"')";
                if (this.OpenConnection() == true)
                {
                    try
                    {
                        MySqlCommand cmd = new MySqlCommand(query, connection);
                        int q = cmd.ExecuteNonQuery();
                        if (q != 0)
                        {
                            MessageBox.Show("Yeni yönetici '" + username + "' başarıyla eklendi.\n\nYönetici Listesi'ni yenileyiniz.", "Kayıt Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                            txtIsim.Text = "";
                            txtKullaniciAdi.Text = "";
                            txtSifre.Text = "";
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
