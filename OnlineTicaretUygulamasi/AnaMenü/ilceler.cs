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
    public partial class ilceler : Form
    {
        public string ServerAdress = "11.11.13.8";
        public string UserName = "sa305";
        public string Password = "sa305";
        public string DataBaseName = "Friendyol";
        public ilceler()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void ilceler_Load(object sender, EventArgs e)
        {
            SqlConnection Kopru = yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName);
            string Sorgu = "Select ilID,ilAdi from Iller";
            DataTable DtIller = yardimci.VerileriOku(Kopru, Sorgu);
            if (DtIller.Rows.Count > 0)
            {
              
                comboBox1.DisplayMember = "ilAdi";
                comboBox1.ValueMember = "ilID"; 
                comboBox1.DataSource = DtIller; 
            }
            else
            {
                MessageBox.Show("Kayıt bulunamadı");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int a = comboBox1.SelectedIndex;
                label3.Text = comboBox1.SelectedValue.ToString();
                label4.Text = comboBox1.SelectedIndex.ToString();
                if (comboBox1.SelectedIndex > -1)
                {
                    string ilceSorgu = "SELECT  [IlceId],[IlceAdi] ,[IlId]";
                    ilceSorgu += " FROM[Friendyol].[dbo].[Ilceler]";
                    ilceSorgu += " where IlId =" + label3.Text;
                    SqlConnection Kopru = yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName);
                    DataTable Dtilce = yardimci.VerileriOku(Kopru, ilceSorgu);
                    if (Dtilce.Rows.Count > 0)
                    {
                        dataGridView1.DataSource = Dtilce;
                    }
                    else
                    {
                        MessageBox.Show("Seçilen il ile ilgili İlçe bulunamadı..");
                        //  dataGridView1.Rows.Clear();
                        dataGridView1.DataSource = null;
                        textBox1.Focus();
                    }
                }
            }

            catch (Exception exx)
            {
 
            }
           
       
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string KaydetKomutu = "insert into Ilceler (IlceAdi,IlId) values ('" + textBox1.Text + "','" + label3.Text + "')";

            //string Kelime1 = "insert into Ilceler (IlceAdi,IlId) values ('";
            //string Kelime2 = textBox1.Text;
            //string Kelime3 = "','";
            //string Kelime4 = "6";
            //string Kelime5 = "')";
            //string Kelime = Kelime1 + Kelime2 + Kelime3 + Kelime4 + Kelime5;
           string Mesaj =  yardimci.Kaydet_Guncelle_Sil(KaydetKomutu, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Mesaj);
            string ilceSorgu = "SELECT  [IlceId],[IlceAdi] ,[IlId]";
            ilceSorgu += " FROM[Friendyol].[dbo].[Ilceler]";
            ilceSorgu += " where IlId =" + label3.Text;
            SqlConnection Kopru = yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName);
            DataTable Dtilce = yardimci.VerileriOku(Kopru, ilceSorgu);
            if (Dtilce.Rows.Count > 0)
            {
                dataGridView1.DataSource = Dtilce;
            }
            else
            {
                MessageBox.Show("Seçilen il ile ilgili İlçe bulunamadı..");
                textBox1.Focus();
            }

        }
    }
}

