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
    public partial class frmStokEkrani : Form
    {
        public frmStokEkrani()
        {
            InitializeComponent();
        }

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private MySqlDataAdapter mySqlDataAdapter;

        public static Boolean urunkayitform = false;
        public static Boolean yoneticiform = false;
        public static Boolean yoneticikayitform = false;
        public static Boolean aramaform = false;
        public static Boolean kritikstokform = false;
        public static Boolean satisform = false;
        public static Boolean duzenleform = false;

        private void frmStokEkrani_Load(object sender, EventArgs e)
        {
            server = "localhost";
            database = "okulprojesi";
            uid = "root";
            password = "";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            IlacDB();
            KritikStok();

            lblHosgeldin.Text = "Hoşgeldiniz, " + frmGiris.isim + ".";

            dataGridView1.Columns[0].HeaderText = "ID";
            dataGridView1.Columns[1].HeaderText = "İlaç Adı";
            dataGridView1.Columns[2].HeaderText = "Barkod";
            dataGridView1.Columns[3].HeaderText = "Tür";
            dataGridView1.Columns[4].HeaderText = "Stok";
            dataGridView1.Columns[5].HeaderText = "Açıklama";
            dataGridView1.Columns[6].HeaderText = "Fiyat";
            dataGridView1.Columns[7].HeaderText = "Geri Ödeme Kodu";

        }

        private void IlacDB()
        {
            if (this.OpenConnection() == true)
            {
                mySqlDataAdapter = new MySqlDataAdapter("select * from ilac", connection);
                DataSet DS = new DataSet();
                mySqlDataAdapter.Fill(DS);
                dataGridView1.DataSource = DS.Tables[0];

                int a = this.dataGridView1.Rows.Count;
                lblStok.Text = "Güncel Stok Durumu (" + a + " adet ürün listelendi)";

                this.CloseConnection();
            }
        }

        private void KritikStok()
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

                lnkKritikStok.Text = "Stok durumu kritik olan ürün sayısı: " + sayi;

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
            IlacDB();
            KritikStok();
        }
        
        private void btnListe_Click(object sender, EventArgs e)
        {
            frmYonetici f = new frmYonetici();
            if (yoneticiform == false)
            {
                f.Show();
                yoneticiform = true;
            }
            else
            {
                Application.OpenForms[f.Name].Focus();
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            DialogResult err = MessageBox.Show("Programı kapatmak istediğinize emin misiniz?", "Program Kapatılacak", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
            if (err == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnUrunKaydi_Click(object sender, EventArgs e)
        {
            frmUrunKayit f = new frmUrunKayit();
            if (urunkayitform == false)
            {
                f.Show();
                urunkayitform = true;
            }
            else
            {
                Application.OpenForms[f.Name].Focus();
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void btnArama_Click(object sender, EventArgs e)
        {
            frmArama f = new frmArama();
            if (aramaform == false)
            {
                f.Show();
                aramaform = true;
            }
            else
            {
                Application.OpenForms[f.Name].Focus();
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void lnkKritikStok_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmKritikStok f = new frmKritikStok();
            if (kritikstokform == false)
            {
                f.Show();
                kritikstokform = true;
            }
            else
            {
                Application.OpenForms[f.Name].Focus();
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void btnSatis_Click(object sender, EventArgs e)
        {
            frmSatis f = new frmSatis();
            if (satisform == false)
            {
                f.Show();
                satisform = true;
            }
            else
            {
                Application.OpenForms[f.Name].Focus();
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            frmDuzenle f = new frmDuzenle();
            if (duzenleform == false)
            {
                f.Show();
                duzenleform = true;
            }
            else
            {
                Application.OpenForms[f.Name].Focus();
                System.Media.SystemSounds.Beep.Play();
            }
        }
    }
}
