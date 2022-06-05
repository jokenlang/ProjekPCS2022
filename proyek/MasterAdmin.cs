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
    public partial class MasterAdmin : Form
    {
        private Form f;
        MySqlConnection conn;
        DataSet ds;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlCommandBuilder cb;
        public MasterAdmin(Form f)
        {
            InitializeComponent();
            this.f = f;
        }
        private void MasterAdmin_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        void loaddgv()
        {
            try
            {
                dt = new DataTable();
                cmd = new MySqlCommand();
                da = new MySqlDataAdapter("SELECT mo_id AS 'ID Movie', mo_title AS 'Judul Movie', CONCAT(mo_duration DIV 3600, ' jam ', FLOOR((mo_duration - ((mo_duration DIV 3600) * 3600)) / 60),' menit ',ROUND((mo_duration - (((mo_duration DIV 3600)*3600) / 60 )) MOD 60,0),' detik') AS 'Durasi Movie', CASE WHEN mo_status = 1 THEN 'Playing Now' WHEN mo_status= 2 THEN 'Coming Soon' END AS 'Status Movie', mo_genre AS 'Genre' FROM movie", koneksi.getConn());

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

        private void MasterAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
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

        public void gid()
        {
            int x = -1;
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = koneksi.getConn();

                cmd.CommandText = "SELECT COUNT(mo_id)+1 FROM movie";

               
                try
                {
                    x = Convert.ToInt32(cmd.ExecuteScalar());
                }
                catch
                {

                }
                 tbIDfilm.Text = x.ToString(); 
            }
            catch
            {

            }
        }

        private void clear()
        {
            tbIDfilm.Text= "";
            tbfilm.Text = "";
            cbfilm.SelectedIndex = -1;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            jam.Text = "0";
            menit.Text = "0";
            detik.Text = "0";
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            gid();
            if (tbIDfilm.Text!="" && tbfilm.Text !="" && cbfilm.SelectedIndex!=-1 && (radioButton1.Checked!=false||radioButton2.Checked!=false))
            {
                if ( jam.Text != "0" || menit.Text != "0" || detik.Text != "0")
                {
                    int status = 2;
                    if (radioButton1.Checked == true)
                    {
                        status = 1;
                    }
                    string id = tbIDfilm.Text;
                    string judul = tbfilm.Text;
                    string genre = cbfilm.Text;
                    int waktu = Convert.ToInt32(jam.Text) * 3600 + Convert.ToInt32(menit.Text) * 60 + Convert.ToInt32(detik.Text);

                    try
                    {
                        cmd = new MySqlCommand();
                        cmd.Connection = koneksi.getConn();

                        cmd.CommandText = "insert into movie (mo_id,mo_title,mo_duration, mo_status,mo_genre)" +
                                "values(@id,@judul,@durasi,@status,@genre)";
                        cmd.Parameters.Add(new MySqlParameter("@id", id));
                        cmd.Parameters.Add(new MySqlParameter("@judul", judul));
                        cmd.Parameters.Add(new MySqlParameter("@durasi", waktu));
                        cmd.Parameters.Add(new MySqlParameter("@status", status));
                        cmd.Parameters.Add(new MySqlParameter("@genre", genre));

                        cmd.ExecuteNonQuery();
                        loaddgv();
                        clear();
                    }
                    catch (System.Exception excep)
                    {
                        MessageBox.Show(excep.Message);
                    }


                }
                else
                {
                    MessageBox.Show("semua text field harus diisi");
                }
            }
            else
            {
                MessageBox.Show("semua text field harus diisi");
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();

        }

        private void jam_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void menit_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void detik_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ctr = -1;
            string temp = "";
            string tempg = "";
            string[] sp = new string[6];
            clear();
            ctr = dataGridView1.CurrentCell.RowIndex;
            tbIDfilm.Text = dataGridView1.Rows[ctr].Cells[0].Value.ToString();
            tbfilm.Text = dataGridView1.Rows[ctr].Cells[1].Value.ToString();

            temp = dataGridView1.Rows[ctr].Cells[3].Value.ToString();

            tempg = dataGridView1.Rows[ctr].Cells[4].Value.ToString();

            if (temp == "Playing Now")
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }


            if (tempg == "Action")
            {
                cbfilm.SelectedIndex = 0;
            }
            else if (tempg == "Horror")
            {
                cbfilm.SelectedIndex = 1;
            }
            else if (tempg == "Comedy")
            {
                cbfilm.SelectedIndex = 2;
            }
            else if (tempg == "Drama")
            {
                cbfilm.SelectedIndex = 3;
            }
            else if (tempg == "Science Fiction")
            {
                cbfilm.SelectedIndex = 4;
            }
            else if (tempg == "Thriller")
            {
                cbfilm.SelectedIndex = 5;
            }
            else if (tempg == "Romance")
            {
                cbfilm.SelectedIndex = 6;
            }
            sp = dataGridView1.Rows[ctr].Cells[2].Value.ToString().Split(' ');
            string tjam = sp[0];
            string tmenit = sp[2];
            string tdetik = sp[4];

            jam.Text = tjam;
            menit.Text = tmenit;
            detik.Text = tdetik;

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string id = tbIDfilm.Text;
            
            try
            {
                cmd = new MySqlCommand();
                cmd.Connection = koneksi.getConn();
                cmd.CommandText = "delete from movie where mo_id = @id";
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int status = 2;
            if (radioButton1.Checked == true)
            {
                status = 1;
            }
            string id = tbIDfilm.Text;
            string judul = tbfilm.Text;
            string genre = cbfilm.Text;
            int waktu = Convert.ToInt32(jam.Text) * 3600 + Convert.ToInt32(menit.Text) * 60 + Convert.ToInt32(detik.Text);
            
            try
            {
               
                cmd = new MySqlCommand();
                cmd.Connection = koneksi.getConn();

                cmd.CommandText = "update movie set mo_title=@judul ,mo_duration=@durasi, mo_status=@status,mo_genre=@genre where mo_id=@id";
                cmd.Parameters.Add(new MySqlParameter("@id", id));
                cmd.Parameters.Add(new MySqlParameter("@judul", judul));
                cmd.Parameters.Add(new MySqlParameter("@durasi", waktu));
                cmd.Parameters.Add(new MySqlParameter("@status", status));
                cmd.Parameters.Add(new MySqlParameter("@genre", genre));

                cmd.ExecuteNonQuery();
                loaddgv();
                clear();
            }
            catch (System.Exception excep)
            {
                MessageBox.Show(excep.Message);
            }
        }
    }
}
