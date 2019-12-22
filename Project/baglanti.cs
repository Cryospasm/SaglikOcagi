using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Project
{
    public class Baglanti
    {
        public MySqlConnection baglan()//veritabanina baglanti kurar
        {
            MySqlConnection baglanti = new MySqlConnection("Server=127.0.0.1;Database=db;Uid=root;Pwd=cornelia;");
            baglanti.Open();
            MySqlConnection.ClearPool(baglanti);
            MySqlConnection.ClearAllPools();

            return baglanti;
        }


        public int idu(string sqlcumle)//insert update ve delete islemlerini yapar
        {

            MySqlConnection baglan = this.baglan();
            MySqlCommand sorgu = new MySqlCommand(sqlcumle, baglan);
            int sonuc = 0;
            try
            {
                sonuc = sorgu.ExecuteNonQuery();
            }
            catch (MySqlException ex)
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
            MySqlConnection baglan = this.baglan();
            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, baglan);
            DataTable dt = new DataTable();
            try
            {
                adapter.Fill(dt);
            }
            catch (MySqlException ex)
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

        public bool Giris(string id,string pass) // Login işlemleri
        {
            MySqlConnection baglan = this.baglan();
            MySqlCommand cmd = new MySqlCommand("SELECT * FROM kullanici WHERE username=@id AND password=@pass", baglan);
            cmd.Parameters.AddWithValue("@id", id);
            cmd.Parameters.AddWithValue("@pass", pass);
            MySqlDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                baglan.Close();
                return true;
            }
            else
            {
                baglan.Close();
                return false;
            }


        }
    }
}
