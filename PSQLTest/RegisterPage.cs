using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PSQLTest
{
    public partial class RegisterPage : Form
    {
        LoginPage loginPage;
        public RegisterPage(LoginPage lp)
        {
            InitializeComponent();
            loginPage = lp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;Database=cop4710;User Id=postgres;Password=spring99");
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = $"insert into users (u_name, u_pswd) values ('{unameBox.Text}','{pswdBox.Text}')";
            cmd.ExecuteNonQuery();
            cmd.CommandText = $"select * from users where u_name = '{unameBox.Text}'";
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.HasRows)
            {
                this.Hide();
                loginPage.Show();
            }
        
            cmd.Dispose();
            conn.Close();
        }
    }
}
