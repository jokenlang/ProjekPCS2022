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
    public partial class Form1 : Form
    {
        private Form f;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (tbUsername.Text!=""&&tbPassword.Text!="")
            {
                if (tbUsername.Text=="admin")
                {
                    MasterAdmin m = new MasterAdmin(this);
                    m.Show();
                    this.Hide();
                }
                else if (tbUsername.Text == "cs")
                {
                    MasterCS m = new MasterCS(this);
                    m.Show();
                    this.Hide();
                }
                else if (tbUsername.Text == "kasir")
                {
                    MasterKasir m = new MasterKasir(this);
                    m.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Tidak terdaftar didatabase");
                }
            }
            else
            {
                MessageBox.Show("Semua field harus diisi");
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
