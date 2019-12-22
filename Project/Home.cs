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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }


        private void Home_Load(object sender, EventArgs e)
        {
            Giris girisChild = new Giris();
            //girisChild.MdiParent = this;
            girisChild.ShowDialog();
        }

        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void poliklinikTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Poliklinik poliklinikChild = new Poliklinik();
            poliklinikChild.MdiParent = this;
            poliklinikChild.Show();
        }
    }
}
