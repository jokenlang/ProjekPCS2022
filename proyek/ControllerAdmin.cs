using MySql.Data.MySqlClient;
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
    public partial class ControllerAdmin : Form
    {
        private Form f; 
        MySqlConnection conn;
        DataSet ds;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlCommandBuilder cb;
        public ControllerAdmin(Form f)
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnBuyFurniture_Click(object sender, EventArgs e)
        {
            Furniture m = new Furniture(this);
        }

        private void btnEditMovie_Click(object sender, EventArgs e)
        {
            MasterKasir m = new MasterKasir(this);
        }
    }
}
