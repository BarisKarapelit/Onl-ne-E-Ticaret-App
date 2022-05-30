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

namespace OnlineTicaretUygulamasi
{
    public partial class illerelle : Form
    {
        public illerelle()
        {
            InitializeComponent();
        }

        private void illerelle_Load(object sender, EventArgs e)
        {
            
           



           


        }

        private void button1_Click(object sender, EventArgs e)
        {
            VerileriOku();
        }

        private void VerileriOku()
        {
            string Sunucu = "11.11.13.8";
            string Kullanici = "sa305";
            string sifre = "sa305";
            string Veritabani = "Friendyol";
            string BaglantiCumlesi = "Data Source =" + Sunucu +
                "; Initial Catalog = " + Veritabani +
                "; User Id = " + Kullanici + "; Password =" + sifre;

            SqlConnection Baglan = new SqlConnection(@BaglantiCumlesi);
            // Baglantı cümlesi = "Data Source = 11.11.13.8; 
            //  Initial Catalog = Friendyol; User Id = sa305; Password = sa305;"
           
            string SqlSorgu = "Select ilID, ilAdi from Iller";
            DataTable ilTablosu = new DataTable();
            SqlCommand SqlKomut = new SqlCommand();
            SqlKomut.CommandText = SqlSorgu;
            SqlKomut.Connection = Baglan;
            SqlKomut.CommandType = CommandType.Text;
            SqlDataAdapter Adapter = new SqlDataAdapter(SqlKomut);
            Adapter.Fill(ilTablosu);
            try
            {
                Baglan.Close();
                Baglan.Open();
                if (Baglan.State == ConnectionState.Open)
                {
                    label2.Text = "Baglandı";
                    SqlKomut.ExecuteNonQuery();
                    Baglan.Close();
                    dataGridView1.DataSource = ilTablosu;
                    
                }
                else
                {
                    label2.Text = "Baglanamadı";
                }
            }
            catch (Exception err)
            {

                label2.Text = err.ToString(); ;
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Verileri Kaydet ...
            //  string KaydetSorgusu = "INSERT [dbo].[Iller] ( [ilAdi]) VALUES ( N'Yeni İl')";
            string KaydetSorgusu = "Insert into Iller ( [ilAdi]) values ('" + textBox1.Text + "')";
            string Sunucu = "11.11.13.8"; // "S305-00"
            string Kullanici = "sa305";
            string sifre = "sa305";
            string Veritabani = "Friendyol";
            string BaglantiCumlesi = "Data Source =" + Sunucu +
                "; Initial Catalog = " + Veritabani +
                "; User Id = " + Kullanici + "; Password =" + sifre;

            SqlConnection Baglan = new SqlConnection(@BaglantiCumlesi);
            SqlCommand KaydetKomut = new SqlCommand();
            KaydetKomut.CommandType = CommandType.Text;
            KaydetKomut.Connection = Baglan;
            KaydetKomut.CommandText = KaydetSorgusu;
            try
            {
                Baglan.Open();
                KaydetKomut.ExecuteNonQuery();
                Baglan.Close();
                label2.Text = "Kayıt Yapıldı";            }
            catch (Exception ex)
            {

                label2.Text = " Kayıt Yapılamadı : " + ex.ToString();
            }
          

        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Verileri Kaydet ...
            int rowindex = dataGridView1.CurrentRow.Index;
            //    string GuncelleSorgusu = "Update Iller  Set ilAdi = 'Değişti'  where ilID = 1";
            string Sunucu = "11.11.13.8"; // "S305-00"
            string GuncelleSorgusu = "Update Iller Set ilAdi = ";
            GuncelleSorgusu += "'" + textBox1.Text + "'"; 
                   GuncelleSorgusu += " where ilID ="
                + dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            string Kullanici = "sa305";
            string sifre = "sa305";
            string Veritabani = "Friendyol";
            string BaglantiCumlesi = "Data Source =" + Sunucu +
                "; Initial Catalog = " + Veritabani +
                "; User Id = " + Kullanici + "; Password =" + sifre;

            SqlConnection Baglan = new SqlConnection(@BaglantiCumlesi);
            SqlCommand KaydetKomut = new SqlCommand();
            KaydetKomut.CommandType = CommandType.Text;
            KaydetKomut.Connection = Baglan;
            KaydetKomut.CommandText = GuncelleSorgusu;
            try
            {
                Baglan.Open();
                KaydetKomut.ExecuteNonQuery();
                Baglan.Close();
                label2.Text = "Kayıt Yapıldı";
            }
            catch (Exception ex)
            {

                label2.Text = " Kayıt Yapılamadı : " + ex.ToString();
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;
            textBox1.Text = dataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            label3.Text = " Seçilen Kaydın ID Değeri = " 
                + dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            label4.Text = " Seçilen Satırın İndex no: " + rowindex.ToString();
        }
    }
}
