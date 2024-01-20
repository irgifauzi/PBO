using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tugas_Besar_PBO.View
{
    public partial class parentform : Form
    {
        public parentform()
        {
            InitializeComponent();
        }

     


        private void parentform_Load(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void aboutWeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paketDiamondToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
           
        }

        private void diamondToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_Data_Diamond FormFdd = new Form_Data_Diamond();
            FormFdd.MdiParent = this;
            FormFdd.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void diamondToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form_Diamond FormD = new Form_Diamond();
            FormD.MdiParent = this;
            FormD.Show();
        }

     

        private void konfirmasiPembayaranToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data_Transaksi Formp = new Data_Transaksi();
            Formp.MdiParent = this;
            Formp.Show();
        }

        private void jasaJokiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_jasa Formjs = new Form_jasa();
            Formjs.MdiParent = this;
            Formjs.Show();
        }

        private void parentform_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Form_Login form_Login = new Form_Login();
            form_Login.Show();
            this.Hide();
        }
    }
}
