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
    public partial class KullaniciTanit : Form
    {
        public KullaniciTanit()
        {
            InitializeComponent();
        }

        Baglanti baglanti = new Baglanti();

        private void KullaniciTanit_Load(object sender, EventArgs e)
        {
            KayitliKullaniciEkranaBas();
        }


        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection bag = new SqlConnection(@"Data Source=(localdb)\deniz;Initial Catalog=database;Integrated Security=True");

        public void KayitliKullaniciEkranaBas()
        {
            try
            {
                cmd = new SqlCommand("SELECT userName From kullanici", bag);
                bag.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    comboBox1_KullanicilarEkranaBas.Items.Add(dr["userName"].ToString().Trim());
                }
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



        public bool KullaniciTanitmaKullaniciEkraniAc(string kullanici_userName)
        {
            try
            {
                cmd = new SqlCommand("SELECT * From kullanici WHERE userName = @kullanici_userName", bag);
                cmd.Parameters.Add("@kullanici_userName", SqlDbType.VarChar);
                cmd.Parameters["@kullanici_userName"].Value = kullanici_userName;

                bag.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    KullaniciVeriAktarimi.kullaniciUserName = dr["userName"].ToString();
                    if (KullaniciVeriAktarimi.kullaniciUserName != "")
                    {
                        return false;
                    }
                }
            }
            catch (Exception E)
            {
                MessageBox.Show("Veri tabanı bağlantı Hatası" + E.ToString());
            }
            finally
            {
                bag.Close();
            }
            return true;
        }

        private void yeniKulEkleBtn_Click(object sender, EventArgs e)
        {
            if (comboBox1_KullanicilarEkranaBas.Text != "")
            {
                YeniKullaniciEkleme();
            }
            else
                MessageBox.Show("Lütfen Bir Kullanıcı Adı Girin");
        }

        private void YeniKullaniciEkleme()
        {
            string aranan_kullanici = comboBox1_KullanicilarEkranaBas.Text;

            bool poliklinik_ac_bool = KullaniciTanitmaKullaniciEkraniAc(aranan_kullanici);
            // false geri dönüş var ise veri var demektir
            if (poliklinik_ac_bool == false)
            {
                KullaniciVeriAktarimi.kullaniciUserName = aranan_kullanici;
                Kullanici p = new Kullanici();
                p.MdiParent = Program.owner;
                p.Show();
                this.Close();
            }
            if (poliklinik_ac_bool == true)
            {
                try
                {
                    cmd = new SqlCommand("INSERT INTO kullanici (userName) VALUES (@aranan_kullanici)", bag);
                    cmd.Parameters.Add("@aranan_kullanici", SqlDbType.VarChar);   // ??????????????????????????????????????????????????????????
                    cmd.Parameters["@aranan_kullanici"].Value = aranan_kullanici;

                    bag.Open();

                    dr = cmd.ExecuteReader();
                    // Diğer formda verileri okuyabilmek için kullanıcı adı ataması yapıldı
                    KullaniciVeriAktarimi.kullaniciUserName = aranan_kullanici;

                    // Ekledikten sonra bilgi ekranına yönlendirme yapıldı
                    Kullanici p = new Kullanici();
                    p.MdiParent = Program.owner;
                    p.Show();
                    this.Close();
                }
                catch (Exception E)
                {
                    MessageBox.Show("Veri tabanı bağlantı Hatası" + E.ToString());
                }
                finally
                {
                    bag.Close();
                }
            }
        }

        private void comboBox1_KullanicilarEkranaBas_SelectedIndexChanged(object sender, EventArgs e)
        {
            string aranan_kullanici = comboBox1_KullanicilarEkranaBas.Text;

            bool poliklinik_ac_bool = KullaniciTanitmaKullaniciEkraniAc(aranan_kullanici);
            // false geri dönüş var ise veri var demektir
            if (poliklinik_ac_bool == false)
            {
                Kullanici p = new Kullanici();
                p.MdiParent = Program.owner;
                p.Show();
                this.Close();
            }
        }
    }
}
