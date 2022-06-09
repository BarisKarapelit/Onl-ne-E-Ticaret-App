using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OnlineTicaretUygulamasi.AnaMenü;

namespace OnlineTicaretUygulamasi.Context
{
    class yardimci
    {
        // Bu Clas formlar içinde sık kullanılan methotları içerir

        public static SqlConnection Baglan(string serverAdress, string userName, string password, string dataBaseName)
        {
            string BaglantiCumlesi = "Data Source =" + serverAdress +
             "; Initial Catalog = " + dataBaseName +
             "; User Id = " + userName + "; Password =" + password;
            SqlConnection Baglanti = new SqlConnection(@BaglantiCumlesi);

            return Baglanti;
        }
        public static string Kaydet_Guncelle_Sil(string islev, string serverAdress, string userName, string password, string dataBaseName)
        {
            string Mesaj = "";
            SqlConnection Kopru = Baglan(serverAdress, userName, password, dataBaseName);
            SqlCommand Komut = new SqlCommand();
            Komut.Connection = Kopru;
            Komut.CommandType = System.Data.CommandType.Text;
            Komut.CommandText = islev;
            try
            {
                Kopru.Open();
                Komut.ExecuteNonQuery();
                Kopru.Close();
                Mesaj = "Kayıt Tamamlandı";
            }
            catch (Exception Hata)
            {
                Mesaj = Hata.ToString();
            }
            return Mesaj;

        }

        public static void silici(KargoFirmalari Frm)
        {


            foreach (Control Ctrl in Frm.Controls)
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
                    case "System.Windows.Forms.Panel":

                        Panel bb = new Panel();
                        bb.Name = Ctrl.Name.ToString();

                        foreach (Control Ctrl2 in bb.Controls)
                        {
                            MessageBox.Show(Ctrl2.Name.ToString() + " - " + Ctrl2.GetType().ToString());
                            switch (Ctrl2.GetType().ToString())

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


                        break;
                }


            }

        }

        public static DataTable VerileriOku(SqlConnection kopru, string sorgu)
        {
            DataTable ilTablosu = new DataTable();
            SqlCommand SqlKomut = new SqlCommand();
            SqlKomut.CommandText = sorgu;
            SqlKomut.Connection = kopru;
            SqlKomut.CommandType = CommandType.Text;
            SqlDataAdapter Adapter = new SqlDataAdapter(SqlKomut);
            Adapter.Fill(ilTablosu);
            try
            {
                if (kopru.State == ConnectionState.Closed)
                {
                    kopru.Open();
                    SqlKomut.ExecuteNonQuery();
                    kopru.Close();
                }
            }
            catch (Exception err)
            {
            }
            return ilTablosu;
        }
    }
}

