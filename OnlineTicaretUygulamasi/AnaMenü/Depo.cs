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
    public partial class Depo : Form
    {
        public string ServerAdress = "11.11.13.8";
        public string UserName = "sa305";
        public string Password = "sa305";
        public string DataBaseName = "Friendyol";
        public SqlConnection Kopru = new SqlConnection();
        public Depo()
        {
            InitializeComponent();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Yeni depo girişi yapıldığında veri tabanına kayıt yapılacaktır..
            // Bu işlem için Sql bağlantısı ve Insert komutu yazılmalı.. 
           
            string KaydetKomutu = "Insert Into Depo (DepoAdi,Adresi) values ('";
            KaydetKomutu += textBox1.Text + "','" + textBox2.Text + "') ";
            string Mesaj = yardimci.Kaydet_Guncelle_Sil(KaydetKomutu, ServerAdress, UserName, Password,DataBaseName);
            MessageBox.Show(Mesaj);
            textBox2.Text = "";
            textBox1.Text = null;
            Listele();
            this.Refresh();
         

        }

        private void Depo_Load(object sender, EventArgs e)
        {
            // Bu alanda form açıldığında var olan depolar Grid içine listelecektir..
            Listele();
        }

        private void Listele()
        {
            Kopru = yardimci.Baglan(ServerAdress, UserName, Password, DataBaseName);
            string DepoSorgusu = "select DepoID,DepoAdi,Adresi from Depo";
            DataTable DtDepo = yardimci.VerileriOku(Kopru, DepoSorgusu);
            if (DtDepo.Rows.Count > 0)
            {
                dataGridView1.DataSource = DtDepo;
            }
            else
            {
                MessageBox.Show("Kayıtlı Depo bulunamadı");
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int Satir = dataGridView1.CurrentRow.Index;
            label3.Text = dataGridView1.Rows[Satir].Cells[0].Value.ToString();
            textBox1.Text = dataGridView1.Rows[Satir].Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.Rows[Satir].Cells[2].Value.ToString();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string Guncelle = "Update Depo";
            Guncelle += " Set DepoAdi = '" + textBox1.Text + "',";
            Guncelle += " Adresi = '" + textBox2.Text + "'";
            Guncelle += " where DepoID = " + label3.Text;
            string Mesaj = yardimci.Kaydet_Guncelle_Sil(Guncelle, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Mesaj);
            Listele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string Sil = "Delete Depo where DepoID =" + label3.Text;
            string Mesaj = yardimci.Kaydet_Guncelle_Sil(Sil, ServerAdress, UserName, Password, DataBaseName);
            MessageBox.Show(Mesaj);
            Listele();
        }
    }
}
