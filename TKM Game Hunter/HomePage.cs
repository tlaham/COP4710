using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static TKM_Game_Hunter.Resources;

namespace TKM_Game_Hunter
{
    public partial class HomePage : Form
    {
        string username;
        public HomePage(string username)
        {
            InitializeComponent();
            this.username = username;
            lbl_welcome.Text = $"Welcome {username}";
            tooltip_profile.SetToolTip(profilepic, "Click to access profile");
            try
            {
                profilepic.BackgroundImage = Image.FromFile(GetInfo(username, ACC_Col.profilepic));
                profilepic.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception)
            {

            }
        }

        public void Refresh()
        {
            lbl_welcome.Text = "Happy Game Hunting!";
            try
            {
                profilepic.BackgroundImage = Image.FromFile(GetInfo(username, ACC_Col.profilepic));
                profilepic.BackgroundImageLayout = ImageLayout.Stretch;
            }
            catch (Exception)
            {

            }
        }

        private void txtbx_review1_TextChanged(object sender, EventArgs e)
        {

        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void lbl_welcome_Click(object sender, EventArgs e)
        {
            
        }

        private void HomePage_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void profilepic_Click(object sender, EventArgs e)
        {
            ProfilePage PP = new ProfilePage(username, this);
            PP.Show();
        }

        private void btn_editgames_Click(object sender, EventArgs e)
        {
            GamesList GL = new GamesList(this, username);
            GL.Show();
            this.Hide();
        }

        private void btn_logout_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Restart();
                Environment.Exit(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
