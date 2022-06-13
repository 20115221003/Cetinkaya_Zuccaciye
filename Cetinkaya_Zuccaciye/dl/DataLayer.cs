using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Cetinkaya_Zuccaciye.dl
{
    public class DataLayer
    {
        static MySqlConnection con = new MySqlConnection
        (
            new MySqlConnectionStringBuilder()
            {
                Server = "127.0.0.1",
                Database ="cetinkaya_zuccaciye",
                UserID ="root",
                Password ="20115221003",
            }.ConnectionString
        );
        public static int MusteriEkle(Müsteriler m)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("Cetinkaya_Zuccaciye_MusteriEkle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id",m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);
                komut.Parameters.AddWithValue("@adr", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
            
        }

        internal static int SatışEkle(Satislar satislar)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("Cetinkaya_Zuccaciye_SatisEkle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", satislar.ID);
                komut.Parameters.AddWithValue("@mid", satislar.Musterilerid);
                komut.Parameters.AddWithValue("@uid", satislar.Urunlerid);
                komut.Parameters.AddWithValue("@tarih", satislar.Tarih);
                komut.Parameters.AddWithValue("@fiyat", satislar.Fiyat);
                

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static DataSet SatışDetay()
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("Cetinkaya_Zuccaciye_SatisDetay", con);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

             
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int SatisGüncelle(Satislar s)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("Cetinkaya_Zuccaciye_SatisGuncelle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@sid", s.ID);
                komut.Parameters.AddWithValue("@mid", s.Musterilerid);
                komut.Parameters.AddWithValue("@uid", s.Urunlerid);
                komut.Parameters.AddWithValue("@tarih", s.Tarih);
                komut.Parameters.AddWithValue("@fiyat", s.Fiyat);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static DataSet ÜcretDetay()
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("Cetinkaya_Zuccaciye_ucretDetay", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;


                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int ÜcretEkle(Ücretler ücretler)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("Cetinkaya_Zuccaciye_ucretEkle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@uid", ücretler.ID);
                komut.Parameters.AddWithValue("@mid", ücretler.Musterilerid);
                komut.Parameters.AddWithValue("@tarih", ücretler.Tarih);
                komut.Parameters.AddWithValue("@tutar", ücretler.Tutar);
                komut.Parameters.AddWithValue("@tur", ücretler.Tur);
                komut.Parameters.AddWithValue("@aciklama", ücretler.Aciklama);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int ÜcretSil(string id)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("Cetinkaya_Zuccaciye_ucretSil", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@uid", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int ÜcretGüncelle(Ücretler ücretler)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("Cetinkaya_Zuccaciye_ucretGuncelle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@uid", ücretler.ID);
                komut.Parameters.AddWithValue("@mid", ücretler.Musterilerid);
                komut.Parameters.AddWithValue("@tarih", ücretler.Tarih);
                komut.Parameters.AddWithValue("@tutar", ücretler.Tutar);
                komut.Parameters.AddWithValue("@tur", ücretler.Tur);
                komut.Parameters.AddWithValue("@aciklama", ücretler.Aciklama);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int SatisSil(string id)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("Cetinkaya_Zuccaciye_SatisSil", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int MusteriSil(string id)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("Cetinkaya_Zuccaciye_MusteriSil", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);
               

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }

        }

        internal static DataSet UrunGetir(string filtre)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut;
                if (String.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("Cetinkaya_Zuccaciye_UrunlerHepsi", con);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;

                }
                else
                {
                    komut = new MySqlCommand("Cetinkaya_Zuccaciye_UrunBul", con);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;


            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        
    }

        internal static int UrunSil(object id)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("Cetinkaya_Zuccaciye_UrunSil", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", id);


                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int UrunGuncelle(Urunler u)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("Cetinkaya_Zuccaciye_UrunGuncelle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", u.ID);
                komut.Parameters.AddWithValue("@ad", u.Ad);
                komut.Parameters.AddWithValue("@kategori", u.Kategori);
                komut.Parameters.AddWithValue("@fiyat", u.Fiyat);
                komut.Parameters.AddWithValue("@stok", u.Stok);
                komut.Parameters.AddWithValue("@detay", u.Detay);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static int UrunEkle(Urunler urunler)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("Cetinkaya_Zuccaciye_UrunEkle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", urunler.ID);
                komut.Parameters.AddWithValue("@ad", urunler.Ad);
                komut.Parameters.AddWithValue("@kategori", urunler.Kategori);
                komut.Parameters.AddWithValue("@fiyat", urunler.Fiyat);
                komut.Parameters.AddWithValue("@stok", urunler.Stok);
                komut.Parameters.AddWithValue("@detay", urunler.Detay);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }

        }
    

        internal static int MusteriGuncelle(Müsteriler m)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut = new MySqlCommand("Cetinkaya_Zuccaciye_MusteriGuncelle", con);
                komut.CommandType = System.Data.CommandType.StoredProcedure;
                komut.Parameters.AddWithValue("@id", m.ID);
                komut.Parameters.AddWithValue("@ad", m.Ad);
                komut.Parameters.AddWithValue("@soy", m.Soyad);
                komut.Parameters.AddWithValue("@tel", m.Telefon);
                komut.Parameters.AddWithValue("@mail", m.Mail);
                komut.Parameters.AddWithValue("@adr", m.Adres);

                int res = komut.ExecuteNonQuery();
                return res;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }

        internal static DataSet MusteriGetir(string filtre)
        {
            try
            {
                if (con.State != System.Data.ConnectionState.Open)
                    con.Open();
                MySqlCommand komut;
                if (String.IsNullOrEmpty(filtre))
                {
                    komut = new MySqlCommand("Cetinkaya_Zuccaciye_MusterilerHepsi", con);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    
                }
                else
                {
                    komut = new MySqlCommand("Cetinkaya_Zuccaciye_MusteriBul", con);
                    komut.CommandType = System.Data.CommandType.StoredProcedure;
                    komut.Parameters.AddWithValue("@filtre", filtre);
                }
                DataSet dataSet = new DataSet();
                MySqlDataAdapter adp = new MySqlDataAdapter(komut);
                adp.Fill(dataSet);
                return dataSet;
                
                
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (con.State != System.Data.ConnectionState.Closed)
                    con.Close();
            }
        }
    }
}
