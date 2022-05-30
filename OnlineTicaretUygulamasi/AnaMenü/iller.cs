using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineTicaretUygulamasi.AnaMenü
{
    public partial class iller : Form
    {
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
            // TODO: This line of code loads data into the 'friendyolDataSet.Iller' table. You can move, or remove it, as needed.
            this.illerTableAdapter.Fill(this.friendyolDataSet.Iller);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex > -1)
            {
                txtil.Text = listBox1.Text;
                label2.Text = listBox1.SelectedValue.ToString();
                label3.Text = listBox1.SelectedIndex.ToString();
            }

        }
    }
}
