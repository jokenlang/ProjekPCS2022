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
    public partial class MasterAdmin : Form
    {
        private Form f;
        public MasterAdmin(Form f)
        {
            InitializeComponent();
            this.f = f;
        }

        private void MasterAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            koneksi.closeConn();
            this.Close();
        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            Furniture fur = new Furniture(this);
            fur.Show();
            this.Hide();
        }

        private void MasterAdmin_FormClosing(object sender, FormClosingEventArgs e)
        {

            koneksi.closeConn();
        }
    }
}
