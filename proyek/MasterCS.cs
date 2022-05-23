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
    public partial class MasterCS : Form
    {
        private Form f;
        public MasterCS(Form f)
        {
            InitializeComponent();
        }

        private void MasterCS_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Close();
        }

       

        private void MasterCS_FormClosing(object sender, FormClosingEventArgs e)
        {
            koneksi.closeConn();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            koneksi.closeConn();
            Form1 form = new Form1();
            form.Show();
            this.Hide();
        }
    }
}
