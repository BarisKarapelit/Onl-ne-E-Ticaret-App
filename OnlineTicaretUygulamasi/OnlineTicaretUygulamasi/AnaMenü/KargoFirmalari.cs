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
    public partial class KargoFirmalari : Form


    {
        public string ServerAdress = "11.11.13.8";
        public string UserName = "sa305";
        public string Password = "sa305";
        public string DataBaseName = "Friendyol";
        public SqlConnection Kopru = new SqlConnection();

        public KargoFirmalari()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void KargoFirmalari_Load(object sender, EventArgs e)
        {
            Listele();
           
            //label4.Text = "-1";
           // temizle();
            //string kargofirmasorgu = "SELECT [KargoID],[KargoAdi],[Adresi],[Telefon] From [KargoFirmalari]";
            //Kopru = yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName);
            //DataTable dtkargofirmalari = yardimci.VerileriOku(Kopru, kargofirmasorgu);
            //if (dtkargofirmalari.Rows.Count>0)
            //{
            //    dataGridView1.DataSource = dtkargofirmalari;
            //}
            //else
            //{
            //    MessageBox.Show("Kayıtlı Kargo Firması Bulunamadı .. ");
            //}
        }

        private void temizle()
        {
            //   yardimci.silici(aa);

            foreach (Control Ctrl in this.panel1.Controls)
            {
                //Console.WriteLine(Ctrl.GetType().ToString());
                //MessageBox.Show ( (Ctrl.GetType().ToString())) ;

                switch (Ctrl.GetType().ToString())

                {
                    case "System.Windows.Forms.CheckBox":
                        ((CheckBox)Ctrl).Checked = false;

                        break;

                    case "System.Windows.Forms.TextBox":
                        ((TextBox)Ctrl).Text = "";
                        break;

                    case "System.Windows.Forms.RichTextBox":
                        ((RichTextBox)Ctrl).Text = "";
                        break;

                    case "System.Windows.Forms.ComboBox":
                        ((ComboBox)Ctrl).SelectedIndex = -1;
                        ((ComboBox)Ctrl).SelectedIndex = -1;
                        break;

                    case "System.Windows.Forms.MaskedTextBox":

                        ((MaskedTextBox)Ctrl).Text = "";
                        break;
                }
            }
        }

        private void btnkaydet_Click(object sender, EventArgs e)
        {
            string Kaydetkomutu = "Insert Into KargoFirmalari (KargoAdi,Adresi,Telefon) Values (' " + txtkargoadi.Text + "','" + txtadresi.Text + "','" + maskedTextBox1.Text +"')";



            string Mesaj = yardimci.Kaydet_Guncelle_Sil(Kaydetkomutu, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Mesaj);
            Listele();
            temizle();
        }

        private void Listele()
        {
            string kargofirmasorgu = "SELECT [KargoID],[KargoAdi],[Adresi],[Telefon] From [KargoFirmalari]";
            Kopru = yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName);
            DataTable dtkargofirmalari = yardimci.VerileriOku(Kopru, kargofirmasorgu);
            if (dtkargofirmalari.Rows.Count > 0)
            {
                dataGridView1.DataSource = dtkargofirmalari;
              //  dataGridView1.Rows[0].Selected = false;
            }
            else
            {
                MessageBox.Show("Kayıtlı Kargo Firması Bulunamadı .. ");
            }
            temizle();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;

            string GSorgu = " UPDATE KargoFirmalari";
            GSorgu += " SET KargoAdi = '" + txtkargoadi.Text + "',";
            GSorgu += " Adresi = '" + txtadresi.Text + "',";
            GSorgu += "Telefon ='" + maskedTextBox1.Text + "'";

            GSorgu += " WHERE KargoID =" + dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            string Mesaj = yardimci.Kaydet_Guncelle_Sil(GSorgu, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Mesaj);
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
 
            int Secilen = dataGridView1.CurrentRow.Index;
            string Id = dataGridView1.Rows[Secilen].Cells[0].Value.ToString();
            label4.Text = Id;
            txtkargoadi.Text= dataGridView1.Rows[Secilen].Cells[1].Value.ToString();
            txtadresi.Text = dataGridView1.Rows[Secilen].Cells[2].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[Secilen].Cells[3].Value.ToString();
 

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            int rowindex = dataGridView1.CurrentRow.Index;
            string Sil = "Delete from KargoFirmalari where KargoID =" + dataGridView1.Rows[rowindex].Cells[0].Value.ToString();
            string Mesaj = yardimci.Kaydet_Guncelle_Sil(Sil, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Mesaj);
            Listele();
            temizle();
        }

        

        private void dataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            dataGridView1.Rows[0].Selected = false;
            temizle(); 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            temizle();
        }
    }
}
