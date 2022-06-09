using OnlineTicaretUygulamasi.Context;
using OnlineTicaretUygulamasi.ServerConnected;
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
    public partial class Urunler : Form
    {

        private static Server server = new Server();
        public SqlConnection Kopru = new SqlConnection();
        OpenFileDialog open = new OpenFileDialog();


        public Urunler()
        {

            InitializeComponent();
        }

        public string Yol { get; private set; }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string fn = "";
            string fl = "";
            // open file dialog   

            // image filters  
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp *tif *png )|*.jpg; *.jpeg; *.gif; *.bmp; *.tif; *.png ";
            // open.Filter = " PDF (*.pdf )| *.pdf)";
            if (open.ShowDialog() == DialogResult.OK)
            {
                fn = open.SafeFileName.ToString();
                label1.Text = fn;
                // display image in picture box  
                pictureBox1.Image = new Bitmap(open.FileName);
                // image file path  
                textBox1.Text = open.FileName;
                int toplam = textBox1.Text.Length;
                int dosya = fn.Length;
                fl = textBox1.Text.Substring(0, toplam - dosya);
                textBox1.Text = fl;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ResmiTasi(textBox1.Text, label1.Text);
        }

        private void ResmiTasi(string Yol, string file)
        {
            string fileName = file;
            string sourcePath = @Yol;
            string targetPath = @"C:\baris\";

            // Use Path class to manipulate file and directory paths.
            string sourceFile = System.IO.Path.Combine(sourcePath, fileName);
            string destFile = System.IO.Path.Combine(targetPath, fileName);

            // To copy a folder's contents to a new location:
            // Create a new target folder.
            // If the directory
            System.IO.Directory.CreateDirectory(targetPath);
            System.IO.File.Copy(sourceFile, destFile, true);


        }

        private void DbSave()
        {

            string filePath = open.FileName.ToString();
            string SSorgu = "INSERT INTO [dbo].[Urunler]" +
          " ([Kategori_ID]" +
          " ,[Fiyat]" +
          "  ,[Ozellikler]" +
          "  ,[StokMiktari]" +
          "  ,[Yorumlar]" +
          "  ,[Resimler]" +
          "  ,[Urun_Maliyeti]" +
          " ,[UrunAdi])" +
         " VALUES" +
          "('" + cmbKategori.SelectedValue + "','"
          + txtFiyat.Text + "','"
          + txtOzellikler.Text + "','"
          + txtStokMiktari.Text + "','"
          + txtYorum.Text + "','"
          + filePath + "','"
          + txtMaliyet.Text + "','"
          + txtUrunAdi.Text
          + "')";
            SSorgu += "";
            string mesaj = yardimci.Kaydet_Guncelle_Sil(SSorgu, server.ServerAdress, server.UserName, server.Password, server.DataBaseName);
            MessageBox.Show(mesaj);
        }

        private void Urunler_Load(object sender, EventArgs e)
        {
            string kSorgu = " SELECT Kategori_ID, Kategori_Name FROM Kategori";
            Kopru = yardimci.Baglan(server.ServerAdress, server.UserName, server.Password, server.DataBaseName);
            DataTable data = new DataTable();
            data = yardimci.VerileriOku(Kopru, kSorgu);
            if (data.Rows.Count > 0)
            {
                DataRow row = data.NewRow();
                row["Kategori_Name"] = "Lütfen Seçiniz ..";
                data.Rows.InsertAt(row, 0);
                cmbKategori.DataSource = data;
                cmbKategori.DisplayMember = "Kategori_Name";
                cmbKategori.ValueMember = "Kategori_ID";
                cmbKategori.SelectedItem = 0;
            }


            //Datagridview'e veri ekleme

            UrunListeleme();
        }

        private void UrunListeleme()
        {
            string uSorgu = "SELECT " +
          " [Kategori_ID]" +
          " ,[Fiyat]" +
          "  ,[Ozellikler]" +
          "  ,[StokMiktari]" +
          "  ,[Yorumlar]" +
          "  ,[Resimler]" +
          "  ,[Urun_Maliyeti]" +
          " ,[UrunAdi]" + "FROM Urunler";
            DataTable dataTable = new DataTable();
            dataTable = yardimci.VerileriOku(Kopru, uSorgu);

            if (dataTable.Rows.Count > 0)
            {
                dtUrunler.DataSource = dataTable;

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DbSave();
        }
    }
}
