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

namespace OnlineTicaretUygulamasi
{
    public partial class TemizlemeKontrol : Form
    {
        public TemizlemeKontrol()
        {
            InitializeComponent();
        }

        private void TemizlemeKontrol_Load(object sender, EventArgs e)
        {
            string CbilSorgusu = " Select ilID, ilAdi from Iller";
            SqlConnection KopruCbil = yardimci.Baglan("11.11.13.8", "sa305", "sa305", "Friendyol");
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
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            foreach (Control Ctrl in this.Controls)
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
                    case "System.Windows.Forms.RadioButton":
                        ((RadioButton)Ctrl).Checked = false;
                        break;
                    case "System.Windows.Forms.DateTimePicker":
                        ((DateTimePicker)Ctrl).Value = Convert.ToDateTime("01-01-1900");
                        break;
                    case "System.Windows.Forms.Label":
                        ((Label)Ctrl).BackColor = Color.Red;
                        break;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sira = 0;
            string aranan = "deneme";
            foreach( var a in textBox4.Text)

            {
                
                string x = " ";
                if (a.ToString() == x)
                {
                    string y = textBox4.Text.Substring(0, sira);
                    if (y== aranan)
                    {
                        MessageBox.Show("Buldum");
                    }
                    
                }
                sira++;



            }
        }
    }
}
