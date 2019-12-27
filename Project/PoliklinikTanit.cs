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
                            cmd = new SqlCommand("INSERT INTO SOHTS.dbo.poliklinik (poliklinikAdi) VALUES(@PoliklinikAd)", SQLBaglanti.SqlBaglan());

                            cmd.Parameters.Add("@PoliklinikAd", SqlDbType.VarChar);
                            cmd.Parameters["@PoliklinikAd"].Value = PoliklinikVeriAktarimi.poliklinikAd;

                            SQLBaglanti.SqlBaglan().Open();
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
                            //SQLBaglanti.SqlBaglan().Close();
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
                cmd = new SqlCommand("SELECT * From SOHTS.dbo.poliklinik WHERE poliklinikAdi = @PoliklinikAd", SQLBaglanti.SqlBaglan());
                cmd.Parameters.Add("@PoliklinikAd", SqlDbType.VarChar);
                cmd.Parameters["@PoliklinikAd"].Value = poliklinikAd;
                SQLBaglanti.SqlBaglan().Open();

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
                //SQLBaglanti.SqlBaglan().Close();
            }
            return true;
        }
    }
}
