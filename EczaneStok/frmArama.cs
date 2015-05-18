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
    public partial class frmArama : Form
    {
        public frmArama()
        {
            InitializeComponent();
        }

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlDataAdapter mySqlDataAdapter;

        private void frmArama_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmStokEkrani.aramaform = false;
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

        private void frmArama_Load(object sender, EventArgs e)
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

        private void btnArama_Click(object sender, EventArgs e)
        {
            string aranan = txtAranan.Text;
            int tur = cbTur.SelectedIndex;
            string query = "";

            switch (tur)
            {
                case 0: query = "SELECT * FROM ilac WHERE id ="+aranan; break;
                case 1: query = "SELECT * FROM ilac WHERE ad LIKE '%" + aranan + "%'"; break;
                case 2: query = "SELECT * FROM ilac WHERE tur LIKE '%" + aranan + "%'"; break;
                case 3: query = "SELECT * FROM ilac WHERE stok LIKE " + aranan; break;
                case 4: query = "SELECT * FROM ilac WHERE fiyat=" + aranan; break;
                case 5: query = "SELECT * FROM ilac WHERE barkod LIKE " + aranan; break;
                case 6: query = "SELECT * FROM ilac WHERE aciklama LIKE '%" + aranan + "%'"; break;
                case 7: query = "SELECT * FROM ilac WHERE GeriOdemeKodu LIKE '%" + aranan + "%'"; break;
                default: query = "SELECT * FROM ilac"; break;
            }

            if (aranan != "" && tur != -1)
            {
                if (this.OpenConnection() == true)
                {
                    try
                    {
                        mySqlDataAdapter = new MySqlDataAdapter(query, connection);
                        DataSet DS = new DataSet();
                        mySqlDataAdapter.Fill(DS);
                        dataGridView1.DataSource = DS.Tables[0];

                        dataGridView1.Columns[0].HeaderText = "ID";
                        dataGridView1.Columns[1].HeaderText = "İlaç Adı";
                        dataGridView1.Columns[2].HeaderText = "Barkod";
                        dataGridView1.Columns[3].HeaderText = "Tür";
                        dataGridView1.Columns[4].HeaderText = "Stok";
                        dataGridView1.Columns[5].HeaderText = "Açıklama";
                        dataGridView1.Columns[6].HeaderText = "Fiyat";
                        dataGridView1.Columns[7].HeaderText = "Geri Ödeme Kodu";

                        int a = this.dataGridView1.Rows.Count;
                        lblSonuc.Text = "Arama sonucunda " + a.ToString() + " adet ürün listelendi.";

                        this.CloseConnection();
                    }
                    catch
                    {
                        MessageBox.Show("Arama yaparken bir hata oluştu.\nLütfen girdiğiniz bilgileri kontrol ederek tekrar deneyiniz.", "Hatalı Giriş", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        
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
