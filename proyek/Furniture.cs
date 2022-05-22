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
        }

        private void Furniture_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Close();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            MasterAdmin m = new MasterAdmin(this);
            m.Show();
            this.Hide(); 
        }
    }
}
