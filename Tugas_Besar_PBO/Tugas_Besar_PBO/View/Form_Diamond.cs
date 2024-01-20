using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tugas_Besar_PBO.Controller;
using Tugas_Besar_PBO.Model;

namespace Tugas_Besar_PBO.View
{
    public partial class Form_Diamond : Form
    {
        Koneksi koneksi = new Koneksi();
        M_Diamond m_Diamond = new M_Diamond();
        /*string id_diamond;*/

        public void Tampil()
        {
            Diamond.DataSource = koneksi.ShowData("SELECT * FROM t_data_diamond");
            Diamond.Columns[0].HeaderText = "ID_Diamond";
            Diamond.Columns[1].HeaderText = "Jumlah_Diamond";
            Diamond.Columns[2].HeaderText = "Bonus_Diamond";
            Diamond.Columns[3].HeaderText = "Harga_Diamond";
        }

        public Form_Diamond()
        {
            InitializeComponent();
        }

        private void Form_Diamond_Load(object sender, EventArgs e)
        {
            Tampil();
        }

       
    }
}
