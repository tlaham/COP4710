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
    public partial class CreateAccountPage : Form
    {
        NpgsqlConnection conn, conn2;
        NpgsqlCommand cmd;
        NpgsqlDataReader reader;
        LoginPage lp;
        public CreateAccountPage(LoginPage LP)
        {
            InitializeComponent();
            this.lp = LP;
            dob_picker.CustomFormat = "yyyy-MM-dd";
        }

        private void lbl_title_Click(object sender, EventArgs e)
        {

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

        }

        private void txtbx_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtbx_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_username_Click(object sender, EventArgs e)
        {

        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void btn_createAccount_Click(object sender, EventArgs e)
        {
            if (txtbx_username.Text == string.Empty || txtbx_password.Text == string.Empty || txtbx_pswdconfirm.Text == string.Empty || cmbobx_usertype.Text == String.Empty)
            {
                MessageBox.Show("Please Fill out all required fields marked by *", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtbx_password.Text != txtbx_pswdconfirm.Text)
            {
                MessageBox.Show("The 2 passwords entered do not match", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                conn = new NpgsqlConnection(Resources.CONSTRING);
                conn2 = new NpgsqlConnection(Resources.CONSTRING);
                conn.Open();
                cmd = new NpgsqlCommand($"select * from account where username ='{txtbx_username.Text}' or password='{txtbx_password.Text}' ", conn);
                reader = cmd.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Username and or Password already exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    conn2.Open();
                    cmd = new NpgsqlCommand($"insert into account (username, password, email, dob, u_type) values ('{txtbx_username.Text}','{txtbx_password.Text}','{txtbx_email.Text}','{dob_picker.Text}','{cmbobx_usertype.Text}')", conn2);
                    cmd.ExecuteNonQueryAsync();
                    lp.Show();
                    this.Hide();
                }


            }
        }

        private void back_button_Click(object sender, EventArgs e)
        {
            lp.Show();
            this.Hide();
        }

        private void CreateAccountPage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void CreateAccountPage_Load(object sender, EventArgs e)
        {

        }
    }
}
