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
    public partial class Furniture : Form
    {
        private Form f;
        MySqlConnection conn;
        DataSet ds;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlCommandBuilder cb;
        public Furniture(Form f)
        {
            InitializeComponent();
            this.f = f;
            
        }

        private void Furniture_Load(object sender, EventArgs e)
        {
            loaddgv();
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


        private void Furniture_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*koneksi.closeConn();*/
        }

        public void gid()
        {
            int x = -1;
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = koneksi.getConn();

                cmd.CommandText = "SELECT COUNT(*)+1 FROM furniture";


                try
                {
                    x = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch
                {

                }
                tb_id.Text = x.ToString();
            }
            catch
            {

            }
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

        private void tb_jumlah_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void clear()
        {
            tb_id.Text = "";
            tb_nama.Text = "";
            tb_jumlah.Text = "";
            dateTimePicker1.Value = DateTime.Now;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            gid();
            Console.WriteLine(dateTimePicker1.Value);
            Console.WriteLine(DateTime.Now);
            if (tb_id.Text!=""&&tb_nama.Text!=""&&tb_jumlah.Text!=""&&dateTimePicker1.Value>=DateTime.Now&&(radioButton1.Checked != false || radioButton2.Checked != false))
            {
                Console.WriteLine("masuk");
                int status = 2;
                if (radioButton1.Checked == true)
                {
                    status = 1;
                }
                string id = tb_id.Text;
                string nama = tb_nama.Text;
                string jumlah = tb_jumlah.Text;
                DateTime date = dateTimePicker1.Value;
                string masuk = date.ToString("yyyy-MM-dd");
                

                try
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = koneksi.getConn();

                    cmd.CommandText = "insert into furniture (fur_id,fur_name,fur_jumlah, fur_masuk,fur_status)" +
                            "values(@id,@nama,@jumlah,@masuk,@status)";
                    cmd.Parameters.Add(new MySqlParameter("@id", id));
                    cmd.Parameters.Add(new MySqlParameter("@nama", nama));
                    cmd.Parameters.Add(new MySqlParameter("@jumlah", jumlah));
                    cmd.Parameters.Add(new MySqlParameter("@masuk", masuk));
                    cmd.Parameters.Add(new MySqlParameter("@status", status));

                    cmd.ExecuteNonQuery();
                    loaddgv();
                    clear();
                }
                catch (System.Exception excep)
                {

                    Console.WriteLine(excep.Message);
                }
            }
            else
            {
                MessageBox.Show("Semua field harus diisi");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = tb_id.Text;

            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = koneksi.getConn();
                cmd.CommandText = "delete from furniture where fur_id= @id";
                cmd.Parameters.Add(new MySqlParameter("@id", id));

                cmd.ExecuteNonQuery();

                loaddgv();
                clear();
                MessageBox.Show("Berhasil delete");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            clear();
            int ctr = -1;
            ctr = dataGridView1.CurrentCell.RowIndex;
            tb_id.Text = dataGridView1.Rows[ctr].Cells[0].Value.ToString();
            tb_nama.Text = dataGridView1.Rows[ctr].Cells[1].Value.ToString();
            tb_jumlah.Text = dataGridView1.Rows[ctr].Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.Rows[ctr].Cells[3].Value.ToString();
            string temp = dataGridView1.Rows[ctr].Cells[4].Value.ToString();
            if (temp=="Bagus")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }
/*
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int status = 2;
            if (radioButton1.Checked == true)
            {
                status = 1;
            }
            string id = tb_id.Text;
            string nama = tb_nama.Text;
            string jumlah = tb_jumlah.Text;
            DateTime date = dateTimePicker1.Value;
            string masuk = date.ToString("yyyy-MM-dd");
            try
            {

                cmd = new MySqlCommand();
                cmd.Connection = koneksi.getConn();

                cmd.CommandText = "update furniture set fur_name=@nama ,fur_jumlah=@jumlah, fur_masuk=@masuk,fur_status=@status where fur_id=@id";
                cmd.Parameters.Add(new MySqlParameter("@id", id));
                cmd.Parameters.Add(new MySqlParameter("@nama", nama));
                cmd.Parameters.Add(new MySqlParameter("@jumlah", jumlah));
                cmd.Parameters.Add(new MySqlParameter("@masuk", masuk));
                cmd.Parameters.Add(new MySqlParameter("@status", status));

                cmd.ExecuteNonQuery();
                loaddgv();
                clear();
                MessageBox.Show("Berhasil Update");
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }*/
    }
}
