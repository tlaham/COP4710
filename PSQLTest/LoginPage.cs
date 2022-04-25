﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace PSQLTest
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=cop4710;User Id=postgres;Password=spring99");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"select u_id from users where u_name='{unameBox.Text}' and u_pswd='{pswdBox.Text}'";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                this.Hide();
                MainPage mp = new MainPage();
                mp.Show();
            }
            else
            {
                MessageBox.Show("Username and or Password do not exist", "Error", MessageBoxButtons.OK ,MessageBoxIcon.Error);
            }
            cmd.Dispose();
            conn.Close();
        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegisterPage RP = new RegisterPage(this);
            RP.Show();
        }
    }
}