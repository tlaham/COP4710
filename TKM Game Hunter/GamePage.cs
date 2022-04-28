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
    public partial class GamePage : Form
    {
        NpgsqlConnection conn, conn2, conn3;
        NpgsqlCommand cmd, cmd2;
        NpgsqlDataReader reader;

        int gameid;
        string username;
        public GamePage(int gameid, string username)
        {
            InitializeComponent();

            this.gameid = gameid;
            this.username = username;
            
            lv_reviews.View = View.Details;
            lv_reviews.GridLines = true;
            lv_reviews.FullRowSelect = true;
            lv_reviews.Columns.Add("Username" , 100);
            lv_reviews.Columns.Add("Rating", 100);
            lv_reviews.Columns.Add("Description", 300);

            conn = new NpgsqlConnection(Resources.CONSTRING);
            conn.Open();
            cmd = new NpgsqlCommand($"select game_name, price, platform, genre from game where game_id ='{gameid}' ", conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                lbl_game.Text = Convert.ToString(dr["game_name"]);
                lbl_price.Text = Convert.ToString(dr["price"]);
                lbl_platform.Text = Convert.ToString(dr["platform"]);
                lbl_genre.Text = Convert.ToString(dr["genre"]);

                conn2 = new NpgsqlConnection(Resources.CONSTRING);
                conn2.Open();
                cmd = new NpgsqlCommand($"select avg(rating) from review where game_id ='{gameid}' ", conn2);
                NpgsqlDataReader dr2 = cmd.ExecuteReader();
                if(dr2.Read())
                {
                    double rating = dr2.GetDouble(0);
                    int rate = Convert.ToInt32(rating);
                    change_stars(rate);
                }

                conn3 = new NpgsqlConnection(Resources.CONSTRING);
                conn3.Open();
                cmd2 = new NpgsqlCommand($"select username, rating, description  from review where game_id ='{gameid}' ", conn3);
                reader = cmd2.ExecuteReader();
                string[] arr = new string[4];
                while (reader.Read())
                {
                    string user = Convert.ToString(reader["username"]);
                    string rate = Convert.ToString(reader["rating"]);
                    string comment = Convert.ToString(reader["description"]);
                    arr[0] = user;
                    arr[1] = rate;
                    arr[2] = comment;
                    ListViewItem item = new ListViewItem(arr);

                    lv_reviews.Items.Add(item);
                }

            }
            else
            {
                MessageBox.Show("No Data Found");
            }

        }
        private void lbl_home_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage hp = new HomePage(username);
            hp.ShowDialog();
            this.Close();
        }


        private void picbx_profile_Click(object sender, EventArgs e)
        {
            this.Hide();
            //ProfilePage pp = new ProfilePage(username);
            //pp.ShowDialog();
            this.Close();
        }
        private void btn_review_Click(object sender, EventArgs e)
        {
            this.Hide();
            WriteReviewPage review = new WriteReviewPage(username, gameid);
            review.Show();
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

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        private void GamePage_Load(object sender, EventArgs e)
        {


        }

        private void lbl_search_Click(object sender, EventArgs e)
        {

        }
        private void lv_reviews_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pic_star5_Click(object sender, EventArgs e)
        {

        }

        private void pic_star4_Click(object sender, EventArgs e)
        {

        }

        private void pic_star3_Click(object sender, EventArgs e)
        {

        }

        private void pic_star2_Click(object sender, EventArgs e)
        {

        }



        private void lbl_game_Click(object sender, EventArgs e)
        {

        }

        private void pic_star1_Click(object sender, EventArgs e)
        {

        }
    }
}
