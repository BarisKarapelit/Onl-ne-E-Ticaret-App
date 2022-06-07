using OnlineTicaretUygulamasi.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineTicaretUygulamasi.Satis
{
    public partial class SatisSiparis : Form
    {
        public string ServerAdress = "11.11.13.8";
        public string UserName = "sa305";
        public string Password = "sa305";
        public string DataBaseName = "Friendyol";
        public SqlConnection Kopru = new SqlConnection();
        public SatisSiparis()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();

        }

        private void SatisSiparis_Load(object sender, EventArgs e)
        {
            // Form Açıldığında Veri tabanından Müşteriler Okunur..
            SqlConnection Kopru = yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName);
            string Sorgu = "SELECT  MusteriID  , MusteriAdi  FROM  Musteriler  ";
            DataTable DtMusteri = yardimci.VerileriOku(Kopru, Sorgu);
            if (DtMusteri.Rows.Count > 0)
            {
                DataRow row = DtMusteri.NewRow();
                row["MusteriAdi"] = "Lütfen Seçiniz ..";
                DtMusteri.Rows.InsertAt(row, 0);
                CmbMusteri.DataSource = DtMusteri;
                CmbMusteri.DisplayMember = "MusteriAdi";
                CmbMusteri.ValueMember = "MusteriID";
            }
            
        }

        private void CmbMusteri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CmbMusteri.SelectedIndex > 0 )
            {
                TxtMustAdi.Text = CmbMusteri.SelectedText.ToString(); // Display Mem.
                LblID.Text = CmbMusteri.SelectedValue.ToString();  // Value Member
                EskiSiparisler(LblID.Text);
                PNLSiparis.Visible = true;
            }
            else
            {
                PNLSiparis.Visible = false;
            }
        }
        private void EskiSiparisler(string Must)
        {
            string EskiSipSorgu = "Select SiparisID, SiparisTarihi  from Siparis";
            DataTable DtEskiSiparis = yardimci.VerileriOku(yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName), EskiSipSorgu);
            if (DtEskiSiparis.Rows.Count > 0)
            {
                DtGSiparisler.DataSource = DtEskiSiparis;
            } 
        }

        private void DtGSiparisler_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            PnlDetay.Visible = true;
            int RowIndex = DtGSiparisler.CurrentRow.Index;
            string SipId = DtGSiparisler.Rows[RowIndex].Cells[1].Value.ToString();
            string DetaySorgu = "SELECT SiparisDetaylari.SiparisDetayId, " +
                "Urunler.UrunAdi, SiparisDetaylari.SiparisAdedi, " +
                "SiparisDetaylari.SiparisFiyati FROM Siparis INNER JOIN  " +
                "SiparisDetaylari ON Siparis.SiparisID = SiparisDetaylari.SiparisID " +
                "INNER JOIN Urunler ON SiparisDetaylari.UrunID = Urunler.Urun_ID " +
                "WHERE(SiparisDetaylari.SiparisID =" + SipId + ")";
            DataTable DtDetay = yardimci.VerileriOku(yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName), DetaySorgu);
            if (DtDetay.Rows.Count > 0)
            {
                DtGDetay.DataSource = DtDetay;
            }
            else
            {
                MessageBox.Show("Bu Müşteriye ait sipariş satırları bunumadı..");
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            PnlDetay.Visible = false;
        }

        private void button5_Click(object sender, EventArgs e)


        {
            int odemeTipi = 0;

            if (string.IsNullOrEmpty(CmbMusteri.Text) || (RbtNakit.Checked == false && RbtBanka.Checked == false))
            {
                MessageBox.Show("Secilim Yapmadiniz...");
                CmbMusteri.Focus();
            }
            else
            {
                if (RbtNakit.Checked)
                {
                    odemeTipi = 1;
                }
                else if (RbtBanka.Checked)
                {
                    odemeTipi = 2;
                }

              


                string aa = dateTimePicker1.Value.ToShortDateString();
                string yeniSiparisSorgu = "insert into Siparis(MusteriID,SiparisTarihi,OdemeType) Values ('";
                yeniSiparisSorgu += CmbMusteri.SelectedValue + "'," +"CONVERT(Date,'"+aa+"',104)" + ",'";
                yeniSiparisSorgu += odemeTipi.ToString() + "')";
                string mesaj = yardimci.Kaydet_Guncelle_Sil(yeniSiparisSorgu, ServerAdress, UserName, Password, DataBaseName);
                MessageBox.Show(mesaj);
                EskiSiparisler(LblID.Text);
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            //index
            int secilen = DtGSiparisler.CurrentRow.Index;
            if (secilen >= 0)
            {
                string sipıd = DtGSiparisler.Rows[secilen].Cells[2].Value.ToString();
                sipıd = (Convert.ToDateTime(sipıd)).ToShortDateString();
                string bugun = DateTime.Now.ToShortDateString();
                if (sipıd == bugun)
                {
                    panel4.Visible = true;
                    MessageBox.Show("Ürün girebilirsiniz..");
                    dataGridView();
                    SqlConnection kopru = yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName);
                    string yeniurunsorgu = "Select Urun_ID,UrunAdi From Urunler";
                    DataTable dtyeniurun = yardimci.VerileriOku(kopru, yeniurunsorgu);
                    if (dtyeniurun.Rows.Count>0)
                    {
                        DataRow dtsec = dtyeniurun.NewRow();
                        dtsec["UrunAdi"] = "Ürün seçiniz";
                        dtyeniurun.Rows.InsertAt(dtsec, 0);
                        cmburunsec.DataSource = dtyeniurun;
                        cmburunsec.DisplayMember = "UrunAdi";
                        cmburunsec.ValueMember = "Urun_ID";
                        
                    }
                }
                else
                {
                    panel4.Visible = false;

                    MessageBox.Show("Geçmiş tarihe ürün giremezsiniz..");
                }

            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
           

            string yeniurunsorgu = "insert into SiparisDetaylari(UrunID,SiparisFiyati,SiparisAdedi) values('" + cmburunsec.SelectedValue + "','" + txtfiyat.Text + "','" + txtmiktar.Text + "')";
            string mesaj = yardimci.Kaydet_Guncelle_Sil(yeniurunsorgu, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(mesaj);
            dataGridView();




        }

      

        private void dataGridView()
        {
            SqlConnection kopru = yardimci.Baglan(ServerAdress, UserName, Password,DataBaseName);
            string yeniurunsorgu = "SELECT Urunler.UrunAdi, Urunler.Fiyat, SiparisDetaylari.SiparisAdedi FROM Urunler INNER JOIN SiparisDetaylari ON Urunler.Urun_ID = SiparisDetaylari.UrunID";
            DataTable dtyeniurun = yardimci.VerileriOku(kopru, yeniurunsorgu);
            if (dtyeniurun.Rows.Count > 0)
            {
                dataGridView1.DataSource = dtyeniurun;
            }

        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            dataGridView();
            string Gsorgu = "UPTADE SiparisDetaylari SET UrunID='" + cmburunsec.SelectedValue + "','" +
                "SiparisAdedi= '" + txtmiktar.Text + "','" + "SiparisFiyati='" + txtfiyat.Text + "'" + "WHERE SiparisDetayId=" + LblID.Text;
            string mesaj = yardimci.Kaydet_Guncelle_Sil(Gsorgu, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(mesaj);
            guncelle();

        }

        private void guncelle()
        {

            int secilen= dataGridView1.CurrentRow.Index;
            string sipıd = dataGridView1.Rows[secilen].Cells[0].Value.ToString();

            if (secilen>0)
            {
                cmburunsec.Text = "";
                cmburunsec.SelectedText= dataGridView1.Rows[secilen].Cells[0].Value.ToString();
                txtfiyat.Text= dataGridView1.Rows[secilen].Cells[1].Value.ToString();
                txtmiktar.Text= dataGridView1.Rows[secilen].Cells[2].Value.ToString();

                
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            guncelle();

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;
            string Sil = "Delete from SiparisDetaylari where UrunID =" + dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            string Mesaj = yardimci.Kaydet_Guncelle_Sil(Sil, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Mesaj);
            guncelle();

        }
    }
}
