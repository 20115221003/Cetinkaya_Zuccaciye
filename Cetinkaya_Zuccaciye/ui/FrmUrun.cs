using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cetinkaya_Zuccaciye.ui
{
    public partial class FrmUrun : Form
    {
        public FrmUrun()
        {
            InitializeComponent();
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox || c is ComboBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }



                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            if (c is NumericUpDown)
            {
                if (((NumericUpDown)c).Value ==0)
                {
                    errorProvider1.SetError(c, "Eksik veya hatalı bilgi");
                    c.Focus();
                    return false;
                }



                else
                {
                    errorProvider1.SetError(c, "");
                    return true;
                }
            }
            return true;
        }

        public Urunler Urunler { get; set; }
        public bool Güncelleme { get; set; } = false;
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtUrunAd))    return;
            if (!ErrorControl(cbKategori))   return;
            if (!ErrorControl(nmFiyat))      return;
            if (!ErrorControl(nmStok))       return;
            if (!ErrorControl(txtDetay))     return;

            Urunler.Ad = txtUrunAd.Text;
            Urunler.Kategori = cbKategori.Text;
            Urunler.Fiyat = (double)nmFiyat.Value;
            Urunler.Stok = (double)nmStok.Value;
            Urunler.Detay = txtDetay.Text;

            DialogResult = DialogResult.OK;

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmUrun_Load(object sender, EventArgs e)
        {
            txtId.Text = Urunler.ID.ToString();
            if(Güncelleme)
            {
                txtUrunAd.Text = Urunler.Ad;
                cbKategori.Text = Urunler.Kategori;
                nmFiyat.Value = (decimal)Urunler.Fiyat;
                nmStok.Value = (decimal)Urunler.Stok;
                txtDetay.Text = Urunler.Detay;
            }
        }
    }
}
