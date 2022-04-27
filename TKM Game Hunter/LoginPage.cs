using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace TKM_Game_Hunter
{

    public partial class LoginPage : Form
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        NpgsqlDataReader reader;
        public LoginPage()
        {
            InitializeComponent();
        }

        private void txtbx_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(Resources.CONSTRING);
            conn.Open();
            cmd = new NpgsqlCommand($"select username from account where username='{txtbx_username.Text}' or password='{txtbx_password.Text}'", conn);
            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                this.Hide();
                HomePage HP = new HomePage(txtbx_username.Text);
                HP.Show();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password, try again or register a new account", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            conn.Close();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateAccountPage CAP = new CreateAccountPage(this);
            CAP.Show();
        }

        private void pswdvis_check_CheckedChanged(object sender, EventArgs e)
        {
            txtbx_password.UseSystemPasswordChar = !(txtbx_password.UseSystemPasswordChar);
        }
    }
}
