﻿using System;
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
    public partial class Form1 : Form
    {
        private Form f;
        public static MySqlConnection conn;
        MySqlCommand cmd;

        public Form1()
        {

            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            /*koneksi.openConn("proyek_pcs_2022", "localhost", "root", "");*/
            if (tbUsername.Text!=""&&tbPassword.Text!="")
            {
                // 2 == admin

                try
                {
                   /* MySqlCommand cmd = new MySqlCommand("select status from pegawai where username = @username", koneksi.getConn());
                    cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                    int status = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd = new MySqlCommand("select count(*) from pegawai where username = @username", koneksi.getConn());
                    cmd.Parameters.AddWithValue("@username", tbUsername.Text);
                    int adauser = Convert.ToInt32(cmd.ExecuteScalar());

                    cmd = new MySqlCommand("select password from pegawai where username = @password", koneksi.getConn());
                    cmd.Parameters.AddWithValue("@password", tbPassword.Text);
                    string adapass = cmd.ExecuteScalar().ToString();*/

                    /* if (status == 1 && adauser > 0 && adapass != "" || adapass != null)
                     {
                         MasterAdmin m = new MasterAdmin(this);
                         m.Show();
                         this.Hide();
                     }
                     else if (status == 2 && adauser > 0 && adapass != "" || adapass != null)
                     {
                         MasterKasir m = new MasterKasir(this);
                         m.Show();
                         this.Hide();
                     }
                     else if (status == 3 && adauser > 0 && adapass != "" || adapass != null)
                     {
                         MasterCS m = new MasterCS(this);
                         m.Show();
                         this.Hide();
                     }
                     else
                     {
                         MessageBox.Show("Tidak terdaftar didatabase atau password salah");
                     }*/
                    if (tbUsername.Text=="admin")
                    {
                        MasterAdmin m = new MasterAdmin(this);
                        m.Show();
                        this.Hide();
                    }
                    else if (tbUsername.Text == "kasir")
                    {
                        MasterKasir m = new MasterKasir(this);
                        m.Show();
                        this.Hide();

                    }
                    else if (tbUsername.Text == "cs")
                    {
                        MasterCS m = new MasterCS(this);
                        m.Show();
                        this.Hide();
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("error");;
                }
            }
            else
            {
                MessageBox.Show("Semua field harus diisi");
            }
        }
    }
}
