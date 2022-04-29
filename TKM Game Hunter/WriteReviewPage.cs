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
    public partial class WriteReviewPage : Form
    {
        int rating=0;
        string username;
        int gameid;

        NpgsqlConnection conn, conn2;
        NpgsqlCommand cmd;
        public WriteReviewPage(string username, int gameid)
        {
            InitializeComponent();
            this.username = username;
            this.gameid = gameid;
            conn2 = new NpgsqlConnection(Resources.CONNSTRING);
            conn2.Open();
            cmd = new NpgsqlCommand($"select game_name from game where game_id ='{gameid}' ", conn2);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                this.Text = $"{Convert.ToString(dr["game_name"])} Review Page";
                lbl_review.Text = $"Your Review of ({Convert.ToString(dr["game_name"])})";
            }
            else
            {
                MessageBox.Show("Issue");
            }
        }
        private void WriteReviewPage_Load(object sender, EventArgs e)
        {
        }
        private void pic_star1_Click(object sender, EventArgs e)
        {
            rating = 1;
            change_stars(rating);
        }

        private void pic_star2_Click(object sender, EventArgs e)
        {
            rating = 2;
            change_stars(rating);
        }

        private void pic_star3_Click(object sender, EventArgs e)
        {
            rating = 3;
            change_stars(rating);
        }

        private void pic_star4_Click(object sender, EventArgs e)
        {
            rating = 4;
            change_stars(rating);
        }

        private void pic_star5_Click(object sender, EventArgs e)
        {
            rating = 5;
            change_stars(rating);
        }
        private void btn_review_Click(object sender, EventArgs e)
        {
            if (rating > 0)
            {
                string comment = txtbx_review.Text;
                conn = new NpgsqlConnection(Resources.CONNSTRING);
                conn.Open();
                cmd = new NpgsqlCommand($"insert into Review (username, game_id, rating, description) values ('{username}','{gameid}','{rating}','{comment}')", conn);
                cmd.ExecuteNonQueryAsync();

                this.Hide();
                GamePage gp = new GamePage(gameid, username);
                gp.Show();
            }
            else
            {
                MessageBox.Show("Please Choose a Rating by clicking on the Stars(1-5)","Alert",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
        }

        public void change_stars(int rating)
        {
            switch (rating)
            {
                case 1:
                    pic_star1.BackgroundImage = Properties.Resources.star__1_;
                    pic_star2.BackgroundImage = Properties.Resources.star;
                    pic_star3.BackgroundImage = Properties.Resources.star;
                    pic_star4.BackgroundImage = Properties.Resources.star;
                    pic_star5.BackgroundImage = Properties.Resources.star;
                    break;
                case 2:
                    pic_star1.BackgroundImage = Properties.Resources.star__1_;
                    pic_star2.BackgroundImage = Properties.Resources.star__1_;
                    pic_star3.BackgroundImage = Properties.Resources.star;
                    pic_star4.BackgroundImage = Properties.Resources.star;
                    pic_star5.BackgroundImage = Properties.Resources.star;
                    break;
                case 3:
                    pic_star1.BackgroundImage = Properties.Resources.star__1_;
                    pic_star2.BackgroundImage = Properties.Resources.star__1_;
                    pic_star3.BackgroundImage = Properties.Resources.star__1_;
                    pic_star4.BackgroundImage = Properties.Resources.star;
                    pic_star5.BackgroundImage = Properties.Resources.star;
                    break;
                case 4:
                    pic_star1.BackgroundImage = Properties.Resources.star__1_;
                    pic_star2.BackgroundImage = Properties.Resources.star__1_;
                    pic_star3.BackgroundImage = Properties.Resources.star__1_;
                    pic_star4.BackgroundImage = Properties.Resources.star__1_;
                    pic_star5.BackgroundImage = Properties.Resources.star;
                    break;
                case 5:
                    pic_star1.BackgroundImage = Properties.Resources.star__1_;
                    pic_star2.BackgroundImage = Properties.Resources.star__1_;
                    pic_star3.BackgroundImage = Properties.Resources.star__1_;
                    pic_star4.BackgroundImage = Properties.Resources.star__1_;
                    pic_star5.BackgroundImage = Properties.Resources.star__1_;
                    break;
                default:
                    pic_star1.BackgroundImage = Properties.Resources.star;
                    pic_star2.BackgroundImage = Properties.Resources.star;
                    pic_star3.BackgroundImage = Properties.Resources.star;
                    pic_star4.BackgroundImage = Properties.Resources.star;
                    pic_star5.BackgroundImage = Properties.Resources.star;
                    break;
            }
        }


    }
}
