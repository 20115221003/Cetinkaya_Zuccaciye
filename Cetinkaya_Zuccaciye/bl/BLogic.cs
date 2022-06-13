using Cetinkaya_Zuccaciye.dl;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cetinkaya_Zuccaciye.bl
{
    public static class BLogic
    {
        public static bool MusteriEkle(Müsteriler m)
        {
            try {
                int res = DataLayer.MusteriEkle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }

            
        }

        internal static DataSet MusteriGetir(string filtre)
        {
            try
            {
                DataSet ds = DataLayer.MusteriGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return null;
            }
            
        }

        internal static bool MusteriGuncelle(Müsteriler m)
        {
            try
            {
                int res = DataLayer.MusteriGuncelle(m);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool SatışEkle(Satislar satislar)
        {
            try
            {
                int res = DataLayer.SatışEkle(satislar);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet SatışDetay()
        {
            try
            {
                DataSet ds = DataLayer.SatışDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return null;
            }
        }

        internal static bool MusteriSil(string id)
        {
            try
            {
                int res = DataLayer.MusteriSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet UrunGetir(string filtre)
        {

            try
            {
                DataSet ds = DataLayer.UrunGetir(filtre);
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return null;
            }
        }

        internal static bool SatisGüncelle(Satislar satislar)
        {
            try
            {
                int res = DataLayer.SatisGüncelle(satislar);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool UrunEkle(Urunler urunler)
        {
            try
            {
                int res = DataLayer.UrunEkle(urunler);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool SatisSil(string id)
        {
            try
            {
                int res = DataLayer.SatisSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool UrunGuncelle(Urunler u)
        {
            try
            {
                int res = DataLayer.UrunGuncelle(u);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static DataSet ÜcretDetay()
        {
            try
            {
                DataSet ds = DataLayer.ÜcretDetay();
                return ds;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return null;
            }
        }

        internal static bool ÜcretEkle(Ücretler ücretler)
        {
            try
            {
                int res = DataLayer.ÜcretEkle(ücretler);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool UrunSil(string id)
        {
            try
            {
                int res = DataLayer.UrunSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool ÜcretGüncelle(Ücretler ücretler)
        {
            try
            {
                int res = DataLayer.ÜcretGüncelle(ücretler);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }

        internal static bool ÜcretSil(string id)
        {
            try
            {
                int res = DataLayer.ÜcretSil(id);
                return (res > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluştu" + ex.Message);
                return false;
            }
        }
    }
}
