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
            Giris giris = new Giris();
            FormAc(giris);
            hastaKabulToolStripMenuItem.Enabled = false;
            kullaniciİşlemleriToolStripMenuItem.Enabled = false;
            raporlarToolStripMenuItem.Enabled = false;
            referanslarToolStripMenuItem.Visible = false;
        }

        Baglanti baglanti = new Baglanti();

        private void Home_Load(object sender, EventArgs e)
        {
            Program.owner = this;   //tüm program içinde owner formun bu form olduğunu belirtiyoruz.
            IsMdiContainer = true;

        }
        
        public void FormAc(Form AcilacakForm)
        {
            bool durum = false;

            foreach (Form form in this.MdiChildren)
            {
                //Eğer Form2 Form1 üzrinde açıldıysa
                if (form.Text == AcilacakForm.Text)
                {
                    // açıksa true 
                    durum = true;
                    // Form 2 Aktif Edildi
                    form.Activate();
                    form.Show();
                }
                else
                    form.Close();
            }

            // Form2 Form1 üzerinde açık değilse
            if (!durum)
            {
                //Form2'nin ana penceresi olarak Form1 i ayarladık
                AcilacakForm.MdiParent = this;
                //Form2'yi açtık
                AcilacakForm.Show();
            }
        }

        public void Menu_ReferanslarAktif()
        {
            hastaKabulToolStripMenuItem.Enabled = true;
            raporlarToolStripMenuItem.Enabled = true;
            referanslarToolStripMenuItem.Visible = true;
            kullaniciİşlemleriToolStripMenuItem.Enabled = true;
            YetkiliKullaniciKontrol();
        }

        public void YetkiliKullaniciKontrol()
        {
            if (YetkiliKullaniciKontorl.YetkliKullanici == "true")
            {
                referanslarToolStripMenuItem.Visible = true;
            }
            else
                referanslarToolStripMenuItem.Visible = false;
        }

        private void çıkışToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            hastaKabulToolStripMenuItem.Enabled = false;
            raporlarToolStripMenuItem.Enabled = false;
            referanslarToolStripMenuItem.Visible = false;
            Giris giris = new Giris();
            FormAc(giris);
        }
    }
}
