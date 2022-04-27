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
using static TKM_Game_Hunter.Resources;

namespace TKM_Game_Hunter
{
    public partial class ProfilePage : Form
    {
        NpgsqlConnection conn;
        NpgsqlCommand cmd;
        string username;
        public ProfilePage(string username)
        {
            InitializeComponent();
            this.username = username;
            lbl_user.Text = GetInfo(username, ACC_Col.username);
            lbl_age.Text = GetInfo(username, ACC_Col.age);
            lbl_email.Text = GetInfo(username, ACC_Col.email);
            lbl_utype.Text = GetInfo(username, ACC_Col.u_type);
            try
            {
                pictureBox1.BackgroundImage = Image.FromFile(GetInfo(username, ACC_Col.profilepic));
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception ex)
            {
                   
            }
        }

        private void lbl_user_Click(object sender, EventArgs e)
        {

        }

        private void but_ppic_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.BackgroundImage = new Bitmap(openFileDialog.FileName);
                conn = new NpgsqlConnection(Resources.CONSTRING);
                conn.Open();
                cmd = new NpgsqlCommand($"update account set profilepic='{openFileDialog.FileName}' where username='{username}'",conn);
                cmd.ExecuteNonQuery();
                conn.Close();
                pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
