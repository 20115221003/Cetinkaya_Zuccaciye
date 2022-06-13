using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cetinkaya_Zuccaciye.bl;
using Cetinkaya_Zuccaciye.ui;

namespace Cetinkaya_Zuccaciye
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }


        Musteriler mf = new Musteriler();
        Ürünler üf = new Ürünler();
        private void btnMüşteriler_Click(object sender, EventArgs e)
        {
            mf.ShowDialog();
        }

        private void btnÜrünler_Click(object sender, EventArgs e)
        {
            üf.ShowDialog();
        }

        private void btnSatışYap_Click(object sender, EventArgs e)
        {
            FrmSatis frm = new FrmSatis()
            {
                Text = "Satış Yap",
                Satislar = new Satislar()
                {
                    ID = Guid.NewGuid(),
                }

            };



            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatışEkle(frm.Satislar);
                if (b)
                {
                    DataSet ds = BLogic.SatışDetay();
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];

                }
            }
        }
        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataSet ds = BLogic.SatışDetay();
            if (ds != null)
                dataGridView1.DataSource = ds.Tables[0];

            DataSet ds2 = BLogic.ÜcretDetay();
            if (ds2 != null)
                dataGridView2.DataSource = ds2.Tables[0];
        }

        private void btnSatışDuzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            FrmSatis frm = new FrmSatis()
            {
                Text = "Satış Düzenle",
                Güncelleme = true,
                Satislar = new Satislar()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Musterilerid = Guid.Parse(row.Cells[1].Value.ToString()),
                    Urunlerid = Guid.Parse(row.Cells[2].Value.ToString()),
                    Fiyat = double.Parse(row.Cells[7].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[8].Value.ToString()),


                },

                //{ ID = Guid.NewGuid() },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisGüncelle(frm.Satislar);
                if (b)
                {

                    row.Cells[1].Value = frm.Satislar.Musterilerid;
                    row.Cells[2].Value = frm.Satislar.Urunlerid;
                    row.Cells[7].Value = frm.Satislar.Fiyat;
                    row.Cells[8].Value = frm.Satislar.Tarih;

                }
            }
        }

        private void btnSatışSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView1.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kaydı silmek ister misiniz?", "Silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.SatisSil(ID);


                if (b)
                {
                    DataSet ds = BLogic.SatışDetay();
                    if (ds != null)
                        dataGridView1.DataSource = ds.Tables[0];
                }
            }
        }

        private void btnÜcretYap_Click(object sender, EventArgs e)
        {
            FrmUcret frm = new FrmUcret()
            {
                Text = "Ücret Öde",
                Ücretler = new Ücretler()
                {
                    ID = Guid.NewGuid(),
                }

            };



            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÜcretEkle(frm.Ücretler);
                if (b)
                {
                    DataSet ds = BLogic.ÜcretDetay();
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];

                }
            }
        }

        private void btnÜcretDüzenle_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            FrmUcret frm = new FrmUcret()
            {
                Text = "Ücret Düzenle",
                Güncelleme = true,
                Ücretler = new Ücretler()
                {
                    ID = Guid.Parse(row.Cells[0].Value.ToString()),
                    Musterilerid = Guid.Parse(row.Cells[1].Value.ToString()),
                    Tarih = DateTime.Parse(row.Cells[3].Value.ToString()),
                    Tutar = double.Parse(row.Cells[4].Value.ToString()),                   
                    Tur = row.Cells[5].Value.ToString(),
                    Aciklama = row.Cells[6].Value.ToString(),

                },

                //{ ID = Guid.NewGuid() },
            };
            var sonuc = frm.ShowDialog();
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÜcretGüncelle(frm.Ücretler);
                if (b)
                {

                    row.Cells[1].Value = frm.Ücretler.Musterilerid;
                    row.Cells[3].Value = frm.Ücretler.Tarih;
                    row.Cells[4].Value = frm.Ücretler.Tutar;
                    row.Cells[5].Value = frm.Ücretler.Tur;
                    row.Cells[6].Value = frm.Ücretler.Aciklama;
                }
            }
        }

        private void btnÜcretSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = dataGridView2.SelectedRows[0];
            var ID = row.Cells[0].Value.ToString();

            var sonuc = MessageBox.Show("Seçili kaydı silmek ister misiniz?", "Silmeyi onayla", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (sonuc == DialogResult.OK)
            {
                bool b = BLogic.ÜcretSil(ID);


                if (b)
                {
                    DataSet ds = BLogic.ÜcretDetay();
                    if (ds != null)
                        dataGridView2.DataSource = ds.Tables[0];
                }
            }
        }
    }
}
        
    

