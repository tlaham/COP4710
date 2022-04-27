using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
            ProfilePage PP = new ProfilePage(username);
            PP.Show();
            this.Hide();
        }

        private void btn_editgames_Click(object sender, EventArgs e)
        {
            GamesList GL = new GamesList();
            GL.Show();
            this.Hide();
        }
    }
}
