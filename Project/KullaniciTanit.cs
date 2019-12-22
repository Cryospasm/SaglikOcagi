using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class KullaniciTanit : Form
    {
        public KullaniciTanit()
        {
            InitializeComponent();
        }

        Baglanti baglanti = new Baglanti();

        private void KullaniciTanit_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt=baglanti.DataTableGetir("SELECT username FROM kullanici");
            comboBox1.DisplayMember = "username";
            comboBox1.ValueMember = "username";
            comboBox1.DataSource = dt;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
