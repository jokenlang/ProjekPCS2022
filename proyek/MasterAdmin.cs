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
        }

        private void MasterAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Close();
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            koneksi.closeConn();
            Form1 form = new Form1();
            form.Show();
            this.Hide();

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
