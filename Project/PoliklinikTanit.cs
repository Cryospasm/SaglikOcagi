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
    public partial class PoliklinikTanit : Form
    {
        public PoliklinikTanit()
        {
            InitializeComponent();
        }

        Baglanti baglanti = new Baglanti();

        private void PoliklinikTanit_Load(object sender, EventArgs e)
        {
            poliklinikIsimOkuma();
        }

        public void poliklinikIsimOkuma()
        {
            try
            {
                DataTable dt = new DataTable();
                dt=baglanti.DataTableGetir("SELECT poliklinikAdi from poliklinik");
                comboBox1_PoliklinikGirisAd.DataSource = dt;
                comboBox1_PoliklinikGirisAd.ValueMember = "poliklinikAdi"; //Datatable'ın hangi sütunundan veri çekilecek ?
                
            }
            catch (Exception E)
            {
                MessageBox.Show("Veri tabanı bağlantı Hatası" + E.ToString());
                return;
            }
            finally
            {
                //SQLBaglanti.SqlBaglan().Close();
            }
        }

        SqlCommand cmd;
        SqlDataReader dr;
        SqlConnection bag = new SqlConnection(@"Data Source=(localdb)\deniz;Initial Catalog=database;Integrated Security=True");
        private void comboBox1_PoliklinikGirisAd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && comboBox1_PoliklinikGirisAd.Text != "")
            {
                try
                {
                    //Kayi varsa diğer formu açar ve kayıtları doldurur.
                    string poliklinikGirisAd = comboBox1_PoliklinikGirisAd.Text;
                    bool poliklinik_ac_bool = PoliklinikVeriGirisiKayitVarMi(poliklinikGirisAd);
                    // false geri dönüş var ise veri var demektir gerisine gerek yok
                    if (poliklinik_ac_bool == false)
                        return;

                    DialogResult result = MessageBox.Show("Böyle Bir Kayit Bulunamadı, Yeni Bir Kayit Oluşturmak İster Misiniz?", "Poliklinik Bulunamadi", MessageBoxButtons.OKCancel);
                    if (result == DialogResult.Cancel)
                    {
                        comboBox1_PoliklinikGirisAd.Text = "";
                        checkBox1_gecerliMi.Checked = false;
                    }
                    if (result == DialogResult.OK)
                    {
                        try
                        {
                            PoliklinikVeriAktarimi.poliklinikAd = comboBox1_PoliklinikGirisAd.Text;
                            cmd = new SqlCommand("INSERT INTO poliklinik (poliklinikAdi) VALUES(@PoliklinikAd)", bag);

                            cmd.Parameters.Add("@PoliklinikAd", SqlDbType.VarChar);
                            cmd.Parameters["@PoliklinikAd"].Value = PoliklinikVeriAktarimi.poliklinikAd;

                            bag.Open();
                            cmd.ExecuteNonQuery();

                            Poliklinik p = new Poliklinik();
                            p.MdiParent = Program.owner;
                            p.Show();
                            this.Close();
                        }
                        catch (Exception E)
                        {
                            MessageBox.Show("Hata : ", E.ToString());
                        }
                        finally
                        {
                            bag.Close();
                        }
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show("Hata : " + E.ToString());
                }
            }
        }

        public bool PoliklinikVeriGirisiKayitVarMi(string poliklinikAd)
        {
            try
            {
                cmd = new SqlCommand("SELECT * From poliklinik WHERE poliklinikAdi = @PoliklinikAd", bag);
                cmd.Parameters.Add("@PoliklinikAd", SqlDbType.VarChar);
                cmd.Parameters["@PoliklinikAd"].Value = poliklinikAd;
                bag.Open();

                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    PoliklinikVeriAktarimi.gecerliMi = dr["durum"].ToString();
                    PoliklinikVeriAktarimi.poliklinikAciklama = dr["aciklama"].ToString();
                    PoliklinikVeriAktarimi.poliklinikAd = dr["poliklinikAdi"].ToString();
                    if (PoliklinikVeriAktarimi.poliklinikAd != "" || PoliklinikVeriAktarimi.gecerliMi != "" || PoliklinikVeriAktarimi.poliklinikAciklama != "")
                    {
                        Poliklinik p = new Poliklinik();
                        p.MdiParent = Program.owner;
                        p.Show();
                        this.Close();
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
    }
}
