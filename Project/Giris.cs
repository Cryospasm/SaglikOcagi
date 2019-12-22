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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }

        Baglanti baglanti = new Baglanti();
        

        private void cikisBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void temizleBtn_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void girisBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                MessageBox.Show("Lütfen boş alan bırakmayın.");
            }
            else
            {
                bool state;
                state = baglanti.Giris(textBox1.Text, textBox2.Text);
                if (state == true)
                {
                    MessageBox.Show("Giriş başarılı");
                    MessageBox.Show(baglanti.kod.ToString());
                    MessageBox.Show(baglanti.yetki.ToString());
                    this.Close();
                    
                }
                else if (state == false)
                {
                    MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
                }
            }
        }

        private void Giris_FormClosing(object sender, FormClosingEventArgs e)
        {
            Home parent = (Home)Owner;
            //parent.settext(baglanti.kod.ToString());
            if (baglanti.yetki == "doktor")
            {
                parent.yetki("0",baglanti.kod);
            }
            else if(baglanti.yetki == "hemşire")
            {
                parent.yetki("1",baglanti.kod);
            }
        }
    }
}
