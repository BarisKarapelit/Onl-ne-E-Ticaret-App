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
    public partial class iller : Form
    {
       public string ServerAdress = "11.11.13.8";
        public string UserName = "sa305";
        public string Password = "sa305";
        public string DataBaseName = "Friendyol";
        public iller()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void iller_Load(object sender, EventArgs e)
        {
            // Bağlantı Olustur
            // 1. Yöntem : Method kullanarak
            VerileriGuncelle();
          
            
            // 2. Yöntem CLASS kullanarak
            // 3. Yöntem FORM Kodu içinde 
        }

        private void VerileriGuncelle()
        {
            SqlConnection Kopru = yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName);
            string Sorgu = "Select ilID,ilAdi from ILLER"; // iller tablosundan tüm veriler sorgulanıyor. 
            DataTable Dtil = yardimci.VerileriOku(Kopru, Sorgu);
            if (Dtil.Rows.Count > 0)
            {
                // Yapılan sorguda veri tabanından kayıt gelip gelmediği kontrol ediliyor ..
                dataGridView1.DataSource = Dtil;
                

            }
            else
            {
                MessageBox.Show("Aranılan kayıt bulunamadı");
            }
        }

        private void Btn_Kaydet_Click(object sender, EventArgs e)
        {
            // Verileri Kaydetmek için yapılmıştır. 
            string KaydetSorgusu = "Insert into Iller ( [ilAdi]) values ('" + txtil.Text + "')";
            string Mesaj = yardimci.Kaydet_Guncelle_Sil(KaydetSorgusu, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Mesaj);
            VerileriGuncelle();


        }

        private void Btn_Guncelle_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;
            string GuncelleSorgusu = "Update Iller Set ilAdi = ";
            GuncelleSorgusu += "'" + txtil.Text + "'";
            // Tablodaki iladi alanını txtil alanına girilen değerle değiştirir
            GuncelleSorgusu += " where ilID =" + dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            // WHERE komutu :  Değişiklik yapılacak kaydın ID değerine göre filitre eder
         string Sonuc =    yardimci.Kaydet_Guncelle_Sil(GuncelleSorgusu, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Sonuc);
            VerileriGuncelle();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index; // Seçilen satırın index numarasını gösterir
            txtil.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            label2.Text = "Seçilen kaydın ID değeri :" + dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            label3.Text = "Seçilen kaydın Index değeri :" + rowindex.ToString();
        }

        private void Btn_Sil_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;
            string SilmeKomutu = " Delete From Iller where ilID = " + dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            string Sonuc = yardimci.Kaydet_Guncelle_Sil(SilmeKomutu, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Sonuc);
            VerileriGuncelle();
        }
    }
}
