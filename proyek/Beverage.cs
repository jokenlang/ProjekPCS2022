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
    public partial class Beverage : Form
    {
        private Form f;
        MySqlConnection conn;
        DataSet ds;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlCommandBuilder cb;
        public Beverage(Form f)
        {
            InitializeComponent();
        }

        private void clear()
        {
            tbIDfilm.Text = "";
            tbfilm.Text = "";
            cbJumlah.SelectedIndex = -1;
        }

        void loaddgv()
        {
            try
            {
                dt = new DataTable();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter("SELECT BEV_ID AS 'ID',BEV_AMOUNT AS 'Jumlah',BEV_NAME AS 'Nama',BEV_PRICE AS 'Harga', CASE WHEN BEV_STATUS = 1 THEN 'Tersedia' WHEN BEV_STATUS = 2 THEN 'Out of Order' END AS 'Status' FROM beverage", koneksi.getConn());

                /*cmd.ExecuteReader();*/
                /* da.SelectCommand = cmd;*/

                da.Fill(dt);

                dataGridView1.DataSource = null;
                dataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        private void Beverage_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

    }
}
