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
    public partial class FrmMusteri : Form
    {
        public FrmMusteri()
        {
            InitializeComponent();
        }
        public Müsteriler Musteriler { get; set; }
        public bool Güncelleme { get; set; } = false;

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (!ErrorControl(txtAd)) return;
            if (!ErrorControl(txtSoyad)) return;
            if (!ErrorControl(txtTel)) return;
            if (!ErrorControl(txtMail)) return;
            if (!ErrorControl(txtAdres)) return;

            Musteriler.Ad = txtAd.Text;
            Musteriler.Soyad = txtSoyad.Text;
            Musteriler.Telefon = txtTel.Text;
            Musteriler.Mail = txtMail.Text;
            Musteriler.Adres = txtAdres.Text;

            DialogResult = DialogResult.OK;

        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private bool ErrorControl(Control c)
        {
            if (c is TextBox)
            {
                if (c.Text == "")
                {
                    errorProvider1.SetError(txtAd, "Eksik veya hatalı bilgi");
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

        private void FrmMusteri_Load(object sender, EventArgs e)
        {
            txtId.Text = Musteriler.ID.ToString();
            if (Güncelleme)
            {
                txtAd.Text = Musteriler.Ad;
                txtSoyad.Text = Musteriler.Soyad;
                txtTel.Text = Musteriler.Telefon;
                txtMail.Text = Musteriler.Mail;
                txtAdres.Text = Musteriler.Adres;

            }
          
        }
    }
}
