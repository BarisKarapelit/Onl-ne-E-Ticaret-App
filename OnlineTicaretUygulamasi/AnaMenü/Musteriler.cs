using OnlineTicaretUygulamasi.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineTicaretUygulamasi.AnaMenü
{
    public partial class Musteriler : Form
    {
        public string ServerAdress = "11.11.13.8";
        public string UserName = "sa305";
        public string Password = "sa305";
        public string DataBaseName = "Friendyol";
        public SqlConnection Kopru = new SqlConnection();
        public Musteriler()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                label1.Text = "Adınız :";
                label2.Text = "Soyadınız";
                // 2. Yöntem ..
                label2.Visible = true;
                TxtSoyadi.Visible = true;
                label7.Visible = false;
                TxtVergi.Visible = false;
                TxtVergi.Text = "";
                label6.Visible = true;
                TxtTC.Visible = true;
            }
            else
            {
                label1.Text = "Unvan :";
                // 1. Yöntem 
                //label2.Text = "Unvan2:";
                // Soyadı alanı alanını kurumsalda unvan 2 olarak kullanmak istersek..
                // Label 2 text özelliği değiştirilmeli
                // 2. Yöntem
                // Bu yöntemde Soyadı alanının veri tabanındaki özelliği BOŞ GEÇİLEBİLİR
                // olmalıdır.
                label2.Visible = false;
                TxtSoyadi.Visible = false;
                label7.Visible = true;
                TxtVergi.Visible = true;
                label6.Visible = false;
                TxtTC.Visible = false;
                TxtTC.Text = "";


            }
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string Kaydetkomutu = "Insert Into Musteriler";
            Kaydetkomutu += "(MusteriTC,MusteriAdi,MusteriSoyadi,Adresi,Telefon";
            Kaydetkomutu += ",MusteriE_Posta,VergiNo,il,ilce )";
            Kaydetkomutu += " Values (' " + TxtTC.Text + "','" + TxtAdi.Text;
            Kaydetkomutu += "','" + TxtSoyadi.Text + "','" + TxtAdres.Text + "','";
            Kaydetkomutu += TxtTelefon.Text + "','" + TxtEposta.Text + "','";
            Kaydetkomutu += TxtVergi.Text + "','" + Cbil.SelectedValue.ToString();
            Kaydetkomutu += "','" + Cbilce.SelectedValue.ToString() + "')";
            string Mesaj = yardimci.Kaydet_Guncelle_Sil(Kaydetkomutu, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Mesaj);
            Listele();


        }

        private void Musteriler_Load(object sender, EventArgs e)
        {
            // Form Açıldığında CBİL doldurulacak .. 
            // Bunun için Iller tablosundan veriler okunmalı

            string CbilSorgusu = " Select ilID, ilAdi from Iller";
            SqlConnection KopruCbil = yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName);
            DataTable DtCbil = yardimci.VerileriOku(KopruCbil, CbilSorgusu);
            if (DtCbil.Rows.Count > 0)
            {
                DataRow row = DtCbil.NewRow();
                row["ilAdi"] = "Lütfen Seçiniz ..";
                DtCbil.Rows.InsertAt(row, 0);
                Cbil.DataSource = DtCbil;
                Cbil.DisplayMember = "ilAdi";
                Cbil.ValueMember = "ilID";
                Cbil.SelectedIndex = 0;
            }
            if (radioButton1.Checked)
            {
                label1.Text = "Adınız :";
                label2.Text = "Soyadınız";
                // 2. Yöntem ..
                label2.Visible = true;
                TxtSoyadi.Visible = true;
                label7.Visible = false;
                TxtVergi.Visible = false;
                label6.Visible = true;
                TxtTC.Visible = true;
            }
            else
            {
                label1.Text = "Unvan :";
                // 1. Yöntem 
                //label2.Text = "Unvan2:";
                // Soyadı alanı alanını kurumsalda unvan 2 olarak kullanmak istersek..
                // Label 2 text özelliği değiştirilmeli
                // 2. Yöntem
                // Bu yöntemde Soyadı alanının veri tabanındaki özelliği BOŞ GEÇİLEBİLİR
                // olmalıdır.
                label2.Visible = false;
                TxtSoyadi.Visible = false;
                label7.Visible = true;
                TxtVergi.Visible = true;
                label6.Visible = false;
                TxtTC.Visible = false;


            }
            // Var olan veya Yeni eklenen Müşterileri Göster..
            Listele();
        }

        private void Listele()
        {
            // Müşteri tablosu okunuyor ...
            string MusteriSorgu = "SELECT [MusteriID] ,[MusteriTC],[MusteriAdi],[MusteriSoyadi],[Adresi],[Telefon],[MusteriE_Posta],[VergiNo],[il],[ilce]  FROM[dbo].[Musteriler] ";
            Kopru = yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName);
            DataTable DtMusteri = yardimci.VerileriOku(Kopru, MusteriSorgu);
            if (DtMusteri.Rows.Count > 0)
            {
                dataGridView1.DataSource = DtMusteri;
            }
            else
            {
                MessageBox.Show("Kayıtlı Müşteri Bulunamadı .. ");
            }
        }

        private void Cbil_SelectedIndexChanged(object sender, EventArgs e)
        {
            // İl Seçilince ....
            // İlçeler çağırılıyor ..

            if (Cbil.SelectedIndex > 0)
            {
                string CbilceSorgu = "Select IlceId,IlceAdi from Ilceler";
                CbilceSorgu += " where IlId =" + Cbil.SelectedValue.ToString();
                SqlConnection CbilKopru = yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName);
                DataTable DtCbilce = yardimci.VerileriOku(CbilKopru, CbilceSorgu);
                if (DtCbilce.Rows.Count > 0)
                {
                    DataRow row = DtCbilce.NewRow();
                    row["IlceAdi"] = "Lütfen Seçiniz ..";
                    DtCbilce.Rows.InsertAt(row, 0);
                    Cbilce.DataSource = DtCbilce;
                    Cbilce.DisplayMember = "IlceAdi";
                    Cbilce.ValueMember = "IlceId";
                }
            }
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int Secilen = dataGridView1.CurrentRow.Index;
            // Grid içinden textboxlara aktarma
            string Id =  dataGridView1.Rows[Secilen].Cells[0].Value.ToString();
            label10.Text = Id;
            TxtAdi.Text = dataGridView1.Rows[Secilen].Cells[2].Value.ToString();
            TxtTC.Text = dataGridView1.Rows[Secilen].Cells[1].Value.ToString();
            TxtSoyadi.Text = dataGridView1.Rows[Secilen].Cells[3].Value.ToString();
            TxtAdres.Text = dataGridView1.Rows[Secilen].Cells[4].Value.ToString();
            TxtTelefon.Text = dataGridView1.Rows[Secilen].Cells[5].Value.ToString();
            TxtEposta.Text = dataGridView1.Rows[Secilen].Cells[6].Value.ToString();
            TxtVergi.Text = dataGridView1.Rows[Secilen].Cells[7].Value.ToString();
            Cbil.SelectedValue = dataGridView1.Rows[Secilen].Cells[8].Value.ToString();
            Cbilce.SelectedValue = dataGridView1.Rows[Secilen].Cells[9].Value.ToString();
            if (TxtTC.Text != "")
            {
                radioButton1.Checked = true;
                radioButton2.Checked = false;
            }
            else
            {
                radioButton1.Checked = false;
                radioButton2.Checked = true;
            }
            BtnYeni.Visible = true;



        }

        private void BtnYeni_Click(object sender, EventArgs e)
        {
            TxtAdi.Text = null;
            TxtAdres.Text = null;
            TxtEposta.Text = null;
            TxtSoyadi.Text = null;
            TxtTC.Text = null;
            TxtTelefon.Text = null;
            TxtVergi.Text = null;
            Cbil.SelectedIndex = 0;
            Cbilce.SelectedIndex = 0;

        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            // Guncelle Butonuna basınca ekrandaki verileri Kaydedecek

            string GSorgu = " UPDATE Tedarikci";
            GSorgu += " SET MusteriTC = '" + TxtTC.Text + "',";
            GSorgu += " MusteriAdi = '" + TxtAdi.Text + "',";
            GSorgu += "MusteriSoyadi ='" + TxtSoyadi.Text +"',";
            GSorgu += "Adresi = '" + TxtAdres.Text + "',";
            GSorgu += " Telefon ='" + TxtTelefon.Text + "',";
            GSorgu += "MusteriE_Posta ='" + TxtEposta.Text + "',";
            GSorgu += "VergiNo ='" + TxtVergi.Text + "',";
            GSorgu += "il = '" + Cbil.SelectedValue.ToString() +"',";
            GSorgu += "ilce ='" + Cbilce.SelectedValue.ToString() +"'";
            GSorgu += " WHERE MusteriID =" + label10.Text;
            string Mesaj = yardimci.Kaydet_Guncelle_Sil(GSorgu, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Mesaj);
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {


            //[MusteriID] ,[MusteriTC],[MusteriAdi],[MusteriSoyadi],[Adresi],[Telefon],[MusteriE_Posta],[VergiNo],[il],[ilce]
            int rowindex = dataGridView1.CurrentRow.Index;
            string Sil = "Delete from Musteriler where MusteriID =" + dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            string Mesaj = yardimci.Kaydet_Guncelle_Sil(Sil, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Mesaj);
            Listele();

            
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
