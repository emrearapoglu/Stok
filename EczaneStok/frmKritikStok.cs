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
    public partial class frmKritikStok : Form
    {
        public frmKritikStok()
        {
            InitializeComponent();
        }

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlDataAdapter mySqlDataAdapter;

        private void frmKritikStok_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStokEkrani.kritikstokform = false;
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

        private void frmKritikStok_Load(object sender, EventArgs e)
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

            KritikStok();

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "İlaç Adı";
            dataGridView1.Columns[2].HeaderText = "Barkod";
            dataGridView1.Columns[3].HeaderText = "Tür";
            dataGridView1.Columns[4].HeaderText = "Stok";
            dataGridView1.Columns[5].HeaderText = "Açıklama";
            dataGridView1.Columns[6].HeaderText = "Fiyat";
            dataGridView1.Columns[7].HeaderText = "Geri Ödeme Kodu";
        }

        private void btnYenile_Click(object sender, EventArgs e)
        {
            KritikStok();
        }

        private void KritikStok()
        {
            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("SELECT * FROM ilac WHERE stok <= 5", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];                

                this.CloseConnection();

                KritikAdet();
            }
        }

        private void KritikAdet()
        {
            string query = "SELECT ad FROM ilac WHERE stok <= 5";
            int sayi = 0;

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                MySqlDataReader dataReader = cmd.ExecuteReader();
                while (dataReader.Read())
                {
                    sayi++;
                }

                lblKritik.Text = "Stok durumu kritik olan ürünler aşağıda listelenmiştir. (" + sayi + " adet)";

                this.CloseConnection();
            }
        }
    }
}
