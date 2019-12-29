using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Project
{
    public class Baglanti
    {
        public int kod;
        public string yetki;
        public SqlConnection baglan()//veritabanina baglanti kurar
        {
            SqlConnection baglanti = new SqlConnection(@"Data Source=(localdb)\deniz;Initial Catalog=database;Integrated Security=True");
            baglanti.Open();
            SqlConnection.ClearPool(baglanti);
            SqlConnection.ClearAllPools();

            return baglanti;
        }


        public int idu(string sqlcumle)//insert update ve delete islemlerini yapar
        {

            SqlConnection baglan = this.baglan();
            SqlCommand sorgu = new SqlCommand(sqlcumle, baglan);
            int sonuc = 0;
            try
            {
                sonuc = sorgu.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            sorgu.Dispose();
            baglan.Close();
            baglan.Dispose();
            return (sonuc);
        }


        public DataTable DataTableGetir(string sql)// veri çeker
        {
            SqlConnection baglan = this.baglan();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, baglan);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
            }
            catch (SqlException ex)
            {

                throw new Exception(ex.Message);
            }
            adapter.Dispose();
            baglan.Close();
            baglan.Dispose();
            return dt;

        }

        public DataRow DataRowGetir(string sql)// ilk satir verisini çeker
        {
            DataTable tablo = DataTableGetir(sql);
            if (tablo.Rows.Count == 0)
                return null;
            return tablo.Rows[0];
        }

        public bool Giris(string id,string sifre) // Login işlemleri
        {

            SqlConnection baglan = this.baglan();
            SqlCommand cmd = new SqlCommand("SELECT yetki,username,sifre FROM kullanici WHERE username=@id AND sifre=@sifre", baglan);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@sifre", sifre);
            SqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                YetkiliKullaniciKontorl.YetkliKullanici = read["yetki"].ToString().Trim(); // Yetkiyi kaydettik
                baglan.Close();
                return true;
            }
            else
            {
                baglan.Close();
                return false;
            }
        }


        public bool PoliklinikKontrol(string sql)
        {
            SqlConnection baglan = this.baglan();
            SqlCommand cmd = new SqlCommand(sql, this.baglan());
            SqlDataReader read = cmd.ExecuteReader();
            while(read.Read())
            {
                PoliklinikVeriAktarimi.gecerliMi = read["durum"].ToString();
                PoliklinikVeriAktarimi.poliklinikAciklama = read["aciklama"].ToString();
                PoliklinikVeriAktarimi.poliklinikAd = read["poliklinikAdi"].ToString();
                if (PoliklinikVeriAktarimi.poliklinikAd != "" || PoliklinikVeriAktarimi.gecerliMi != "" || PoliklinikVeriAktarimi.poliklinikAciklama != "")
                {
                    Poliklinik p = new Poliklinik();
                    p.MdiParent = Program.owner;
                    p.Show();
                    return true; //veri var
                }
                
            }
            return false;
        }










    }
}
