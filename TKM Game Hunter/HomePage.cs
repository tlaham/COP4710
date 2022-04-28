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
using Npgsql;

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
            DisplayTopGames();
            DisplayReviews();
        }

        private void DisplayReviews()
        {
            NpgsqlConnection conn, conn2, conn3;
            NpgsqlCommand cmd, cmd2, cmd3;
            conn = new NpgsqlConnection(Resources.CONSTRING);
            conn.Open();
            cmd = new NpgsqlCommand($"SELECT Game.game_name, Review.rating, Review.description FROM Game FULL OUTER JOIN Review ON Game.game_id = Review.game_id ORDER BY Review.review_id DESC LIMIT 1", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lblGame1.Text = Convert.ToString(dr["game_name"]);
                lblRating1.Text = Convert.ToString(dr["rating"]) + " / 5 Stars";
                txtbx_review1.Text = Convert.ToString(dr["description"]);
            }

            conn2 = new NpgsqlConnection(Resources.CONSTRING);
            conn2.Open();
            cmd2 = new NpgsqlCommand($"SELECT Game.game_name, Review.rating, Review.description FROM Game FULL OUTER JOIN Review ON Game.game_id = Review.game_id ORDER BY Review.review_id DESC LIMIT 1 OFFSET 1", conn2);
            dr = cmd2.ExecuteReader();
            if (dr.Read())
            {
                lblGame2.Text = Convert.ToString(dr["game_name"]);
                lblRating2.Text = Convert.ToString(dr["rating"]) + " / 5 Stars";
                txtbx_review2.Text = Convert.ToString(dr["description"]);
            }

            conn3 = new NpgsqlConnection(Resources.CONSTRING);
            conn3.Open();
            cmd3 = new NpgsqlCommand($"SELECT Game.game_name, Review.rating, Review.description FROM Game FULL OUTER JOIN Review ON Game.game_id = Review.game_id ORDER BY Review.review_id DESC LIMIT 1 OFFSET 2", conn3);
            dr = cmd3.ExecuteReader();
            if (dr.Read())
            {
                lblGame3.Text = Convert.ToString(dr["game_name"]);
                lblRating3.Text = Convert.ToString(dr["rating"]) + " / 5 Stars";
                txtbx_review3.Text = Convert.ToString(dr["description"]);
            }
        }

        private void DisplayTopGames()
        {
            NpgsqlConnection conn;
            NpgsqlCommand cmd;
            List<string> list = new List<string>();
            conn = new NpgsqlConnection(Resources.CONSTRING);
            conn.Open();
            cmd = new NpgsqlCommand($"SELECT DISTINCT Game.game_name, AVG(Review.rating) " +
                 $"FROM Game INNER JOIN Review ON Game.game_id = Review.game_id " +
                 $"GROUP BY Game.game_name " +
                 $"ORDER BY AVG(Review.rating) DESC LIMIT 3", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                list.Add(Convert.ToString(dr["game_name"]));
            }
            txtTopGame1.Text = list[0];
            txtTopGame2.Text = list[1];
            txtTopGame3.Text = list[2];
            conn.Close();
        }

        public void HPRefresh()
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
            DisplayTopGames();
            DisplayReviews();
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

        private void lbl_price1_Click(object sender, EventArgs e)
        {
        }

        private void txtbx_review1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
