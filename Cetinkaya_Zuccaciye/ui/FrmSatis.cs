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
    public partial class FrmSatis : Form
    {
        public FrmSatis()
        {
            InitializeComponent();
        }

      
        public Satislar Satislar { get; set; }
        public bool Güncelleme { get; set; } = false;
        private void btnTamam_Click(object sender, EventArgs e)
        {
            if(nmFiyat.Value==0)
            {
                errorProvider1.SetError(nmFiyat, "Fiyat Giriniz");
                nmFiyat.Focus();
            }
            else
            {
                errorProvider1.SetError(nmFiyat, "");
            }

            Satislar.Tarih = dtTarih.Value;
            Satislar.Fiyat = (double)nmFiyat.Value;
            Satislar.Urunlerid =Guid.Parse( txtUrun.Text);
            Satislar.Musterilerid =Guid.Parse (txtMusteri.Text);


            DialogResult = DialogResult.OK;
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void FrmSatis_Load(object sender, EventArgs e)
        {
            txtId.Text = Satislar.ID.ToString();
            if (Güncelleme)
            {
                txtMusteri.Text = Satislar.Musterilerid.ToString();
                txtUrun.Text = Satislar.Urunlerid.ToString();
                nmFiyat.Value = (decimal)Satislar.Fiyat;
                dtTarih.Value = Satislar.Tarih;
            }
         
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //musteriler = frm.Müsteriler;
                txtMusteri.Text =frm.Müsteriler.ID .ToString();
            }
            
        }

        private void btnÜrünSeç_Click(object sender, EventArgs e)
        {
            Ürünler frm = new Ürünler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                //urunler = frm.Urunler;
                txtUrun.Text =frm.Urunler.ID.ToString();
            }
        }
    }
}
