using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineTicaretUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void stokHareketleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMenü.Musteriler form2 = new AnaMenü.Musteriler();
            form2.Show();
            this.Hide();

        }

        private void ürünlerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMenü.Urunler urunler = new AnaMenü.Urunler();
            urunler.MdiParent = this;
            urunler.Show();
           // this.Hide();


        }

        private void illerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMenü.iller iller = new AnaMenü.iller();
          //  illerelle iller = new illerelle();
            iller.MdiParent = this;
            iller.Show();
         //   this.Hide();

        }

        private void ilçelerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMenü.ilceler ilceler = new AnaMenü.ilceler();
            ilceler.Show();
            this.Hide();


        }

        private void kategoriToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMenü.Kategori kategori =new  AnaMenü.Kategori();
         
            kategori.Show();
            this.Hide();
            
        }

        private void kargoFirmalarıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMenü.KargoFirmalari kargoFirmalari = new AnaMenü.KargoFirmalari();
            kargoFirmalari.MdiParent = this;
            kargoFirmalari.Show();
           // this.Hide();
        }

        private void depoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMenü.Depo depo = new AnaMenü.Depo();
            depo.Show();
            this.Hide();

        }

        private void satışlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMenü.Satisler satisler = new AnaMenü.Satisler();
            satisler.Show();
            this.Hide();

        }

        private void satışSiparişToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satis.SatisSiparis satisSiparis = new Satis.SatisSiparis();
            satisSiparis.Show();
            this.Hide();


        }

        private void teslimatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Satis.Teslimat teslimat = new Satis.Teslimat();
            teslimat.Show();
            this.Hide();


        }

        private void üretimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stok_Hareketleri.Uretim uretim = new Stok_Hareketleri.Uretim();
            uretim.Show();
            this.Hide();

        }

        private void satınAlmaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stok_Hareketleri.SatinAlma satinAlma = new Stok_Hareketleri.SatinAlma();
            satinAlma.Show();
            this.Hide();

        }

        private void telimatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Stok_Hareketleri.Teslimat teslimat = new Stok_Hareketleri.Teslimat();
            teslimat.Show();
            this.Hide();

        }

        private void kasaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nakit_İslemleri.Kasa kasa = new Nakit_İslemleri.Kasa();
            kasa.Show();
            this.Hide();

        }

        private void bankaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Nakit_İslemleri.Kasa kasa = new Nakit_İslemleri.Kasa();
            kasa.Show();
            this.Hide();

        }

        private void tedarikçiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AnaMenü.Tedarikci tedarikci = new AnaMenü.Tedarikci();
            tedarikci.MdiParent = this;
            tedarikci.Show();
         //   this.Hide();
        }

        private void testToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TemizlemeKontrol tem = new TemizlemeKontrol();
            tem.MdiParent = this;
            tem.Show();
        }
    }
}
