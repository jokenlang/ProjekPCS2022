using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyek
{
    public partial class MasterKasir : Form
    {
        private Form f;
        public MasterKasir(Form f)
        {
            InitializeComponent();
        }

        private void MasterKasir_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void button_WOC1_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            koneksi.closeConn();
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }

        private void MasterKasir_FormClosing(object sender, FormClosingEventArgs e)
        {
            koneksi.closeConn();
        }
    }
}
