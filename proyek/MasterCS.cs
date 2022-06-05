using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
namespace proyek
{
    public partial class MasterCS : Form
    {
        private Form f;
      
        MySqlConnection conn;
        DataSet ds;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlCommandBuilder cb;
        public MasterCS(Form f)
        {
            InitializeComponent();
            this.f = f;
        }
        void loaddgv()
        {
            try
            {
                dt = new DataTable();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter("SELECT fur_id AS 'ID', fur_name AS 'Nama Furniture' , fur_jumlah AS 'Jumlah' ,date_format(fur_masuk,'%d-%M-%Y'), CASE WHEN fur_status = 1 THEN 'Bagus' WHEN fur_status= 2 THEN 'Rusak' END AS 'Status Furniture' FROM furniture", koneksi.getConn());

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
        private void MasterCS_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Show();
        }

       

        private void MasterCS_FormClosing(object sender, FormClosingEventArgs e)
        {
            koneksi.closeConn();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            koneksi.closeConn();
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (radioButton1.Visible == true)
            {
                int status = 2;
                if (radioButton1.Checked == true)
                {
                    status = 1;
                }
                string ids = id.Text;
                try
                {

                    cmd = new MySqlCommand();
                    cmd.Connection = koneksi.getConn();

                    cmd.CommandText = "update furniture set fur_status=@status where fur_id=@id";
                    cmd.Parameters.Add(new MySqlParameter("@id", ids));
                    cmd.Parameters.Add(new MySqlParameter("@status", status));

                    cmd.ExecuteNonQuery();
                    loaddgv();

                    MessageBox.Show("Berhasil Update");
                }
                catch (System.Exception excep)
                {
                    MessageBox.Show(excep.Message);
                }
            }
            else
            {

            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            radioButton1.Visible = true;
            radioButton2.Visible = true;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            int ctr = -1;
            ctr = dataGridView1.CurrentCell.RowIndex;
            string temp = dataGridView1.Rows[ctr].Cells[4].Value.ToString();
            id.Text = dataGridView1.Rows[ctr].Cells[0].Value.ToString();
            if (temp == "Bagus")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void MasterCS_Load(object sender, EventArgs e)
        {
            loaddgv();
            radioButton1.Visible = false; 
            radioButton2.Visible = false; 
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            radioButton1.Visible = false;
            radioButton2.Visible = false; 
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
