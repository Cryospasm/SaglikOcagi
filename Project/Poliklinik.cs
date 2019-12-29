using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Poliklinik : Form
    {
        public Poliklinik()
        {
            InitializeComponent();
        }

        SqlCommand cmd;
        SqlConnection bag = new SqlConnection(@"Data Source=(localdb)\deniz;Initial Catalog=database;Integrated Security=True");
        

        private void Poliklinik_Load(object sender, EventArgs e)
        {
            GelenVerileriYukle();
        }

        private void GelenVerileriYukle()
        {
            if (PoliklinikVeriAktarimi.poliklinikAd != "" || PoliklinikVeriAktarimi.gecerliMi != "" || PoliklinikVeriAktarimi.poliklinikAciklama != "")
            {
                textBox1_poliklinikPoliklinikAd.Text = PoliklinikVeriAktarimi.poliklinikAd;
                if (PoliklinikVeriAktarimi.gecerliMi == "true")
                {
                    checkBox_poliklinikGecerliMi.Checked = false;
                }
                else
                    checkBox_poliklinikGecerliMi.Checked = true;

                textBox_PoliklinikAciklama.Text = PoliklinikVeriAktarimi.poliklinikAciklama;
            }
            PoliklinikVeriAktarimi.gecerliMi = "";
            PoliklinikVeriAktarimi.poliklinikAciklama = "";
            PoliklinikVeriAktarimi.poliklinikAd = "";
        }

        public void PoliklinikSecmeEkraniDon()
        {
            PoliklinikTanit p = new PoliklinikTanit();
            p.MdiParent = Program.owner;
            p.Show();
            this.Close();
        }


        private void PoliklinikSil()
        {
            try
            {
                cmd = new SqlCommand("DELETE FROM poliklinik WHERE poliklinikAdi='"+textBox1_poliklinikPoliklinikAd.Text+"'",bag); 
                bag.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Silme Başarılı");
            }
            catch (Exception E)
            {
                MessageBox.Show("Veri tabanı bağlantı Hatası" + E.ToString());
            }
            finally
            {
                bag.Close();
                PoliklinikSecmeEkraniDon();
            }
        }


        private void PoliklinikUpdate()
        {
            try
            {
                string check = "";
                if (checkBox_poliklinikGecerliMi.Checked)
                {
                    check = "Geçerli";
                }
                else
                {
                    check = "Geçersiz";
                }

                cmd = new SqlCommand("UPDATE poliklinik SET poliklinikAdi= '"+textBox1_poliklinikPoliklinikAd.Text+"', durum='"+check+"',aciklama='"+textBox_PoliklinikAciklama.Text+"' WHERE poliklinikAdi='"+textBox1_poliklinikPoliklinikAd.Text+"'", bag);
                
                bag.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Başarılı");
            this.Close();
            }
            catch (Exception E)
            {
                MessageBox.Show("Veri tabanı bağlantı Hatası" + E.ToString());
                return;
            }
            finally
            {
                bag.Close();
            }
        }

        private void button_PoliklinikCikisYap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_PoliklinikSil_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Silmek İstediğinize Emin Misiniz?", "Poliklinik Silme", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                PoliklinikSil();
            }
        }

        private void button1_PoliklinikGuncelle_Click(object sender, EventArgs e)
        {
            PoliklinikUpdate();
        }
    }
}
