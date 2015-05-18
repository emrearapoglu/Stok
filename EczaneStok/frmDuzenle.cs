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
    }
}
