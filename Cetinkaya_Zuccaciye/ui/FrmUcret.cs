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
    public partial class FrmUcret : Form
    {
        public FrmUcret()
        {
            InitializeComponent();
        }

        public Ücretler Ücretler { get; set; }
        public bool Güncelleme { get; set; } = false;
        private void btnİptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void btnTamam_Click(object sender, EventArgs e)
        {
            if (nmUcret.Value == 0)
            {
                errorProvider1.SetError(nmUcret, "Ücret Giriniz");
                nmUcret.Focus();
            }
            else
            {
                errorProvider1.SetError(nmUcret, "");
            }

            if (cmbTur.SelectedItem == null)
            {
                errorProvider1.SetError(cmbTur, "Ücret Türü Seçin");
                cmbTur.Focus();
                return;
            }



            else
            {
                errorProvider1.SetError(cmbTur, "");
                
            }
            if (txtAciklama.Text=="")
            {
                errorProvider1.SetError(txtAciklama, "Açıklama oluşturun");
                txtAciklama.Focus();
                return;
            }



            else
            {
                errorProvider1.SetError(txtAciklama, "");

            }
            Ücretler.Musterilerid =Guid.Parse( txtMusteri.Text);
            Ücretler.Tur = cmbTur.SelectedItem.ToString();
            Ücretler.Tutar = (double)nmUcret.Value;
            Ücretler.Aciklama = txtAciklama.Text;
            Ücretler.Tarih = dtTarih.Value;

            DialogResult = DialogResult.OK;

        }

        private void FrmUcret_Load(object sender, EventArgs e)
        {
            txtId.Text = Ücretler.ID.ToString();
            if (Güncelleme)
            {
                txtMusteri.Text = Ücretler.Musterilerid.ToString();
                dtTarih.Text = Ücretler.Tarih.ToString();
                nmUcret.Value = (decimal)Ücretler.Tutar;
                cmbTur.SelectedItem = Ücretler.Tur;
                txtAciklama.Text = Ücretler.Aciklama.ToString();
            }
        }

        private void btnMüşteriSeç_Click(object sender, EventArgs e)
        {
            Musteriler frm = new Musteriler();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                
                txtMusteri.Text = frm.Müsteriler.ID.ToString();
            }
        }
    }
}
