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

        Baglanti baglanti = new Baglanti();
        Giris child = new Giris();

        private void Home_Load(object sender, EventArgs e)
        {
            //Giris girisChild = new Giris();
            //girisChild.MdiParent = this;
            //girisChild.Show();
            
            child.ShowDialog(this);

        }
        
        public void yetki(string yetki,int kod) // yetki ve kod alıp maine yazdırma 
        {
            bbbbbbb.Text = yetki;
            if (yetki == "0")
            {
                label1.Text=kod.ToString();
                referanslarToolStripMenuItem.Visible = true;
            }
            else
            {
                label1.Text = kod.ToString();
                referanslarToolStripMenuItem.Visible = false;
            }
            
        }


        private void çıkışToolStripMenuItem1_Click(object sender, EventArgs e) // çıkış butonu
        {
            Application.Exit();
        }

        private void poliklinikTanıtmaToolStripMenuItem_Click(object sender, EventArgs e) 
        {
            Poliklinik poliklinikChild = new Poliklinik();
            poliklinikChild.MdiParent = this;
            poliklinikChild.Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //baglanti.kod = 0;
            //baglanti.yetki = "";
            //child.ShowDialog();
            
        }

        private void kullanıcıTanıtmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KullaniciTanit kullaniciT = new KullaniciTanit();
            kullaniciT.MdiParent = this;
            kullaniciT.Show();
        }
    }
}
