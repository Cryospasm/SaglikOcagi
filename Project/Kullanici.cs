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
    public partial class Kullanici : Form
    {
        public Kullanici()
        {
            InitializeComponent();
        }


        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection bag = new SqlConnection(@"Data Source=(localdb)\deniz;Initial Catalog=database;Integrated Security=True");

        private void Kullanici_Load(object sender, EventArgs e)
        {
            CinsiyetMedeniHalKanGrubuUnvanVeriDoldurma();
            if (KullaniciVeriAktarimi.kullaniciUserName != "")
            {
                VarOlanKullaniciVerileriYukleme();
            }
        }


        private void VarOlanKullaniciVerileriYukleme()
        {
            cmd = new SqlCommand("SELECT * From kullanici WHERE userName=@userName", bag);
            cmd.Parameters.Add("@userName", SqlDbType.VarChar);
            cmd.Parameters["@userName"].Value = KullaniciVeriAktarimi.kullaniciUserName;
            try
            {
                bag.Open();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    textBox1_KullaniciKod.Text = dr["KullaniciKod"].ToString().Trim();
                    textBox_TC.Text = dr["TC"].ToString().Trim();
                    textBox_DogumYeri.Text = dr["DogumYeri"].ToString().Trim();
                    textBox_BabaAdi.Text = dr["BabaAd"].ToString().Trim();
                    textBox_AnneAdi.Text = dr["AnneAd"].ToString().Trim();
                    textBox_CepTel.Text = dr["cepTelefonNo"].ToString().Trim();
                    textBox_EvTel.Text = dr["evTelefonNo"].ToString().Trim();
                    textBox_Ad.Text = dr["Ad"].ToString().Trim();
                    textBox_Soyad.Text = dr["Soyad"].ToString().Trim();
                    dateTimePicker1_isBaslama.Text = dr["isBaslamaTarih"].ToString().Trim();
                    dateTimePicker2_DogumTarihi.Text = dr["dogumTarihi"].ToString().Trim();
                    comboBox1_cinsiyet.Text = dr["cinsiyet"].ToString().Trim();
                    comboBox2_MedeniHal.Text = dr["medeniHal"].ToString().Trim();
                    textBox_adres.Text = dr["adres"].ToString().Trim();
                    comboBox3_KanGrubu.Text = dr["kanGrubu"].ToString().Trim();
                    textBoxMaas.Text = dr["maas"].ToString().Trim();
                    comboBox1_Unvan.Text = dr["unvan"].ToString().Trim();
                    textBox_KullaniciAd.Text = dr["userName"].ToString().Trim();
                    textBox_Sifre.Text = dr["sifre"].ToString().Trim();
                    string yetki_belgesi = dr["yetki"].ToString().Trim();

                    if (yetki_belgesi == "true")
                    {
                        checkBox_yetkiliKullaniciMi.Checked = true;
                    }
                    else
                        checkBox_yetkiliKullaniciMi.Checked = false;
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
            finally
            {
                bag.Close();
            }
        }


        private void CinsiyetMedeniHalKanGrubuUnvanVeriDoldurma()
        {
            string[] cinsiyetler = { "Kadın", "Erkek" };
            string[] medeniHal = { "Bekar", "Evli", "Dul" };
            string[] unvan = { "Teknisyen", "Doktor", "Gorevli", "Saglik Personeli" };
            string[] kanGrublari = { "AB Rh+", "AB Rh-", "A Rh+", "A Rh-", "B Rh+", "B Rh-", "0 Rh+", "0 Rh-" };

            foreach (var item in cinsiyetler)
                comboBox1_cinsiyet.Items.Add(item);

            foreach (var item in medeniHal)
                comboBox2_MedeniHal.Items.Add(item);

            foreach (var item in kanGrublari)
                comboBox3_KanGrubu.Items.Add(item);

            foreach (var item in unvan)
                comboBox1_Unvan.Items.Add(item);
        }


        public void KullaniciUpdate()
        {
            cmd = new SqlCommand();
            cmd.Connection = bag;
            cmd.CommandText = "UPDATE kullanici SET TC=@TC,dogumYeri=@DogumYeri,babaAd=@BabaAd,anneAd=@AnneAd,cepTelefonNo=@CepTel,evTelefonNo=@EvTel,ad=@Ad,soyad=@Soyad," +
                "maas=@Maas,isBaslamaTarih=@isBaslama,dogumTarihi=@DogumTarihi,cinsiyet=@Cinsiyet,medeniHal=@MedeniHal,kanGrubu=@KanGrubu,unvan=@Unvan,adres=@Adres,userName=@userName," +
                "sifre=@SifreKullanici,yetki=@yetki_durumu WHERE kullaniciKod=@KullaniciKod";

            cmd.Parameters["@KullaniciKod"].Value = Convert.ToInt32(textBox1_KullaniciKod.Text.Trim());

            cmd.Parameters["@TC"].Value = Convert.ToInt32(textBox_TC.Text.Trim());

            cmd.Parameters["@DogumYeri"].Value = textBox_DogumYeri.Text.Trim();

            cmd.Parameters["@BabaAd"].Value = textBox_BabaAdi.Text.Trim();

            cmd.Parameters["@AnneAd"].Value = textBox_AnneAdi.Text.Trim();

            cmd.Parameters["@CepTel"].Value = textBox_CepTel.Text.Trim();

            cmd.Parameters["@EvTel"].Value = textBox_EvTel.Text.Trim();

            cmd.Parameters["@Ad"].Value = textBox_Ad.Text.Trim();

            cmd.Parameters["@Soyad"].Value = textBox_Soyad.Text.Trim();

            cmd.Parameters["@Maas"].Value = textBoxMaas.Text.Trim();

            cmd.Parameters["@isBaslama"].Value = dateTimePicker1_isBaslama.Value;

            cmd.Parameters["@DogumTarihi"].Value = dateTimePicker2_DogumTarihi.Value;

            cmd.Parameters["@Cinsiyet"].Value = comboBox1_cinsiyet.Text.Trim();

            cmd.Parameters["@MedeniHal"].Value = comboBox2_MedeniHal.Text.Trim();

            cmd.Parameters["@KanGrubu"].Value = comboBox3_KanGrubu.Text.Trim();

            cmd.Parameters["@Unvan"].Value = comboBox1_Unvan.Text.Trim();

            cmd.Parameters["@Adres"].Value = textBox_adres.Text.Trim();

            cmd.Parameters["@userName"].Value = textBox_KullaniciAd.Text.Trim();

            cmd.Parameters["@SifreKullanici"].Value = textBox_Sifre.Text.Trim();


            if (checkBox_yetkiliKullaniciMi.Checked == true)
            {
                cmd.Parameters["@yetki_durumu"].Value = ("true").ToString();
            }
            else
                cmd.Parameters["@yetki_durumu"].Value = ("false").ToString();

            try
            {
                bag.Open();
                cmd.ExecuteNonQuery();
                MessageBox.Show("Update Başarılı");
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
                return;
            }
            finally
            {
                bag.Close();
            }
        }


        public void EkraniTemizle()
        {
            textBox_KullaniciAd.Text = "";
            comboBox1_Unvan.Text = "";
            textBoxMaas.Text = "";
            textBox_TC.Text = "";
            textBox_DogumYeri.Text = "";
            textBox_BabaAdi.Text = "";
            textBox_AnneAdi.Text = "";
            textBox_CepTel.Text = "";
            textBox_EvTel.Text = "";
            textBox_Ad.Text = "";
            textBox_Soyad.Text = "";
            comboBox1_cinsiyet.Text = "";
            comboBox2_MedeniHal.Text = "";
            comboBox3_KanGrubu.Text = "";
            textBox_adres.Text = "";
            textBox_Sifre.Text = "";
            textBox_KullaniciAd.Text = "";
        }


        private void kullaniciSil()
        {
            cmd = new SqlCommand("DELETE FROM kullanici WHERE kullaniciKod=@KullaniciKod", bag);

            cmd.Parameters["@KullaniciKod"].Value = textBox1_KullaniciKod.Text;
            try
            {
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
            }
        }


        private void textBox_TC_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void textBox_DogumYeri_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsSeparator(e.KeyChar);
        }

        private void button2_Guncelle_Click(object sender, EventArgs e)
        {
            if (textBox_TC.Text != "" && textBox_Ad.Text != "" && textBox_Soyad.Text != "")
            {
                DialogResult result = MessageBox.Show("Verileri Güncellemek İstediğinize Emin Misiniz?", "Verileri Güncelle", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    KullaniciUpdate();
                }
            }
            else
                MessageBox.Show("TC, Ad ve Soyad Bölümleri Boş Olamaz");
        }

        private void button1_Temizle_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("Tüm alanları temizlemek istediğinize emin misiniz?", "Ekrani Temizle", MessageBoxButtons.YesNo);
            if (m == DialogResult.Yes)
            {
                EkraniTemizle();
            }
        }

        private void button3_Sil_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = MessageBox.Show("Var Olan Kullanıcıyı Silmek İstediğinize Emin Misiniz! İşlem Geri Alınamamaktadır.", "Kullanıcı Silme", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    kullaniciSil();
                    KullaniciTanit K = new KullaniciTanit();
                    K.MdiParent = Program.owner;
                    K.Show();
                    this.Close();
                }
            }
            catch (Exception E)
            {
                MessageBox.Show(E.ToString());
            }
        }

        private void button4_Cikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
