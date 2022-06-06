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
    public partial class Movie : Form
    {
        private Form f;
        MySqlConnection conn;
        DataSet ds;
        MySqlCommand cmd;
        MySqlDataAdapter da;
        DataTable dt;
        MySqlCommandBuilder cb;
        public Movie(Form f)
        {
            InitializeComponent();
            this.f = f;
        }
        private void clear()
        {
            tbID.Text = "";
            tbfilm.Text = "";
            cbfilm.SelectedIndex = -1;
            jam.Text = "0";
            menit.Text = "0";
            detik.Text = "0";
            cbJumlah.SelectedIndex = -1;
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

        private void Movie_Load(object sender, EventArgs e)
        {
            loaddgv();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int ctr = -1;
            string temp = "";
            string tempg = "";
            string[] sp = new string[6];
            clear();
            ctr = dataGridView1.CurrentCell.RowIndex;
            tbID.Text = dataGridView1.Rows[ctr].Cells[0].Value.ToString();
            tbfilm.Text = dataGridView1.Rows[ctr].Cells[1].Value.ToString();

            temp = dataGridView1.Rows[ctr].Cells[3].Value.ToString();

            tempg = dataGridView1.Rows[ctr].Cells[4].Value.ToString();


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

        private void Movie_FormClosed(object sender, FormClosedEventArgs e)
        {
            f.Show();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (tbID.Text != "" && tbfilm.Text != "" && cbJumlah.SelectedIndex != -1)
            {
                cmd = new MySqlCommand("select count(*) from htrans_movie", koneksi.getConn());
                string id = tbID.Text;
                string tempHari = DateTime.Now.Date.ToString("ddMMyyyy");
                string tempnota = "GG" + tempHari + cmd.ExecuteScalar().ToString();
                string tanggal = DateTime.Now.Date.ToString("yyyy-MM-dd");
                int ht_id = Convert.ToInt32(cmd.ExecuteScalar());
                int jumlah = Convert.ToInt32(cbJumlah.SelectedItem);
                Console.WriteLine(tempnota);
                try
                {
                    cmd = new MySqlCommand();
                    cmd.Connection = koneksi.getConn();

                    cmd.CommandText = "insert into htrans_movie (ht_no_nota,ht_tanggal)" +
                            "values(@noNota,@tanggal)";
                    //cmd.Parameters.Add(new MySqlParameter("@id", id));
                    cmd.Parameters.Add(new MySqlParameter("@noNota", tempnota));
                    cmd.Parameters.Add(new MySqlParameter("@tanggal", tanggal));
                    cmd.ExecuteNonQuery();

                    cmd = new MySqlCommand();
                    cmd.Connection = koneksi.getConn();

                    cmd.CommandText = "insert into dtrans_movie (DT_HT_ID,DT_ID_MOVIE, DT_JUMLAH)" + "values(@id,@idMovie,@jumlah)";
                    cmd.Parameters.Add(new MySqlParameter("@id", ht_id));
                    cmd.Parameters.Add(new MySqlParameter("@idMovie", id));
                    cmd.Parameters.Add(new MySqlParameter("@jumlah", jumlah));
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
                MessageBox.Show("semua field harus diisi dulu");
            }
        }
    }
}
