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
    public partial class frmGiris : Form
    {
        public frmGiris()
        {
            InitializeComponent();
        }

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public static string isim;

        private void frmGiris_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "okulprojesi";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            bool girdi = false;
            if (txtUsername.Text != "" && txtPassword.Text != "")
            {
                string query = "SELECT * FROM admins";

                if (this.OpenConnection() == true)
                {
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    while (dataReader.Read())
                    {
                        string username = dataReader.GetString("username");
                        string password = dataReader.GetString("password");
                        if (txtUsername.Text == username && txtPassword.Text == password)
                        {
                            girdi = true;
                            isim = dataReader.GetString("isim");
                        }
                    }

                    if (girdi == true)
                    {
                        this.Hide();
                        frmStokEkrani f = new frmStokEkrani();
                        f.Show();
                    }
                    else
                    {
                        MessageBox.Show("Kullanıcı adınız veya şifreniz yanlış.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                    dataReader.Close();

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
                MessageBox.Show("Boş alan bırakmayın", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

    }
}
