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
    public partial class frmYonetici : Form
    {
        public frmYonetici()
        {
            InitializeComponent();
        }

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlDataAdapter mySqlDataAdapter;

        private void frmYonetici_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "okulprojesi";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            YoneticiDB();

            lblHosgeldin.Text = "Hoşgeldiniz, " + frmGiris.isim + ".";
        }

        private void YoneticiDB()
        {
            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from admins", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

                this.CloseConnection();
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

        private void btnYenile_Click(object sender, EventArgs e)
        {
            YoneticiDB();
        }

        private void frmYonetici_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStokEkrani.yoneticiform = false;
        }

        private void btnYoneticiEkle_Click(object sender, EventArgs e)
        {
            frmYoneticiKayit f = new frmYoneticiKayit();
            if (frmStokEkrani.yoneticikayitform == false)
            {
                f.Show();
                frmStokEkrani.yoneticikayitform = true;
            }
            else
            {
                Application.OpenForms[f.Name].Focus();
                System.Media.SystemSounds.Beep.Play();
            }
        }
    }
}
