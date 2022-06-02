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
    public partial class Furniture : Form
    {
        private Form f;
        public Furniture(Form f)
        {
            InitializeComponent();
            this.f = f; 
        }

        private void Furniture_FormClosed(object sender, FormClosedEventArgs e)
        {
           f.Show();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            /*koneksi.closeConn();*/
            this.Close();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbIDfilm_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Furniture_FormClosing(object sender, FormClosingEventArgs e)
        {
            koneksi.closeConn();
        }
    }
}
