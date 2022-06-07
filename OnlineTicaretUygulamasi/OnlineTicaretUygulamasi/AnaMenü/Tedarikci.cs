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
    public partial class Tedarikci : Form
    {
        public string ServerAdress = "11.11.13.8";
        public string UserName = "sa305";
        public string Password = "sa305";
        public string DataBaseName = "Friendyol";
        public SqlConnection Kopru = new SqlConnection();
        public Tedarikci()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void BtnKaydet_Click(object sender, EventArgs e)
        {
            string Kaydetkomutu = "Insert Into Tedarikci";
            Kaydetkomutu += "(SaticiTC,SaticiAdi,SaticiSoyadi,Adresi,Telefon";
            Kaydetkomutu += ",SaticiE_Posta,VergiNo)";
            Kaydetkomutu += " Values (' " + TxtTC.Text + "','" + TxtAdi.Text;
            Kaydetkomutu += "','" + TxtSoyadi.Text + "','" + TxtAdres.Text + "','";
            Kaydetkomutu += TxtTelefon.Text + "','" + TxtEposta.Text + "','";
            Kaydetkomutu += TxtVergi.Text + "')";
            string Mesaj = yardimci.Kaydet_Guncelle_Sil(Kaydetkomutu, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Mesaj);
            Listele();
        }
        private void Listele()
        {
            // Müşteri tablosu okunuyor ...
            string TedarikciSorgu = "SELECT [SaticiID] ,[SaticiTC],[SaticiAdi],[SaticiSoyadi],[Adresi],[Telefon],[SaticiE_Posta],[VergiNo]  FROM [dbo].[Tedarikci] ";
            Kopru = yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName);
            DataTable DtTedarikci = yardimci.VerileriOku(Kopru, TedarikciSorgu);
            if (DtTedarikci.Rows.Count > 0)
            {
                dataGridView1.DataSource = DtTedarikci;
            }
            else
            {
                MessageBox.Show("Kayıtlı Tedarikci Bulunamadı .. ");
            }
        }

        private void TxtTC_TextChanged(object sender, EventArgs e)
        {

        }

        private void Tedarikci_Load(object sender, EventArgs e)
        {
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int Secilen = dataGridView1.CurrentRow.Index;
            // Grid içinden textboxlara aktarma
            string Id = dataGridView1.Rows[Secilen].Cells[0].Value.ToString();
            label10.Text = Id;
            TxtAdi.Text = dataGridView1.Rows[Secilen].Cells[2].Value.ToString();
            TxtTC.Text = dataGridView1.Rows[Secilen].Cells[1].Value.ToString();
            TxtSoyadi.Text = dataGridView1.Rows[Secilen].Cells[3].Value.ToString();
            TxtAdres.Text = dataGridView1.Rows[Secilen].Cells[4].Value.ToString();
            TxtTelefon.Text = dataGridView1.Rows[Secilen].Cells[5].Value.ToString();
            TxtEposta.Text = dataGridView1.Rows[Secilen].Cells[6].Value.ToString();
            TxtVergi.Text = dataGridView1.Rows[Secilen].Cells[7].Value.ToString();
            
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TxtAdi.Text = null;
            TxtAdres.Text = null;
            TxtEposta.Text = null;
            TxtSoyadi.Text = null;
            TxtTC.Text = null;
            TxtTelefon.Text = null;
            TxtVergi.Text = null;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            //"SELECT [SaticiID] ,[SaticiTC],[SaticiAdi],[SaticiSoyadi],[Adresi],[Telefon],[SaticiE_Posta],[VergiNo]  FROM[dbo].[Tedarikci] ";

            string GSorgu = " UPDATE Tedarikci";
            GSorgu += " SET SaticiTC = '" + TxtTC.Text + "',";
            GSorgu += " SaticiAdi = '" + TxtAdi.Text + "',";
            GSorgu += "SaticiSoyadi ='" + TxtSoyadi.Text + "',";
            GSorgu += "Adresi = '" + TxtAdres.Text + "',";
            GSorgu += " Telefon ='" + TxtTelefon.Text + "',";
            GSorgu += "SaticiE_Posta ='" + TxtEposta.Text + "',";
            GSorgu += "VergiNo ='" + TxtVergi.Text + "'";
            
            GSorgu += " WHERE SaticiID =" + label10.Text;
            string Mesaj = yardimci.Kaydet_Guncelle_Sil(GSorgu, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Mesaj);
            Listele();
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;
            string Sil = "Delete from Tedarikci where SaticiID =" + dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            string Mesaj = yardimci.Kaydet_Guncelle_Sil(Sil, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Mesaj);
            Listele();
        }
    }
}
