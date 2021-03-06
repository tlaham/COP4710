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
    public partial class GamesList : Form
    {
        private NpgsqlConnection conn;
        private NpgsqlCommand cmd;
        private int rowindex = -1;
        private string imgPath = string.Empty;
        private HomePage HP;
        private string username;
        
        public GamesList(HomePage HP, string username)
        {
            InitializeComponent();
            this.username = username;
            if(GetInfo(username,ACC_Col.u_type)=="Admin")
            {
                but_browse.Visible = true;
                but_delete.Visible = true;
                but_update.Visible = true;
                but_insert.Visible = true;
                but_save.Visible = true;
                but_rev.Visible = true;
                lbl_splashart.Visible = true;
            }
            else
            {
                but_browse.Visible = false;
                but_delete.Visible = false;
                but_update.Visible=false;
                but_insert.Visible=false;
                but_save.Visible = false;
                but_rev.Visible = true;
                lbl_splashart.Visible = false;
            }
            this.HP = HP;
        }

        private void GamesList_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(CONNSTRING);
            this.RefreshTable();
        }

        private void RefreshTable()
        {
            conn.Open();
            cmd = new NpgsqlCommand("select * from game", conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            dgv_games.DataSource = null;
            dgv_games.DataSource = dt;
            DataGridViewCellEventArgs e = new DataGridViewCellEventArgs(0, 0);
            dgv_games_CellClick(dt,e);
        }

        private void dgv_games_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0)
                {
                    LockInputs();
                    rowindex = e.RowIndex;
                    but_rev.Text = $"Review: {dgv_games.Rows[e.RowIndex].Cells["game_name"].Value.ToString()}";
                    txtbx_title.Text = dgv_games.Rows[e.RowIndex].Cells["game_name"].Value.ToString();
                    txtbx_genre.Text = dgv_games.Rows[e.RowIndex].Cells["genre"].Value.ToString();
                    txtbx_platform.Text = dgv_games.Rows[e.RowIndex].Cells["platform"].Value.ToString();
                    txtbx_price.Text = dgv_games.Rows[e.RowIndex].Cells["price"].Value.ToString();
                    txtbx_company.Text = dgv_games.Rows[e.RowIndex].Cells["company"].Value.ToString();
                    if (dgv_games.Rows[e.RowIndex].Cells["splashart"].Value.ToString() != string.Empty)
                    {
                        try
                        {
                            pbx_splash.BackgroundImage = Image.FromFile(dgv_games.Rows[e.RowIndex].Cells["splashart"].Value.ToString());
                            pbx_splash.BackgroundImageLayout = ImageLayout.Stretch;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        pbx_splash.BackgroundImage = null;
                    }
                }
            }
            catch { }
        }

        private void LockInputs()
        {
            txtbx_title.ReadOnly = txtbx_genre.ReadOnly = txtbx_platform.ReadOnly = txtbx_price.ReadOnly = txtbx_company.ReadOnly = true;
            but_browse.Enabled = false;
        }

        private void UnlockInputs()
        {
            txtbx_title.ReadOnly = txtbx_genre.ReadOnly = txtbx_platform.ReadOnly = txtbx_price.ReadOnly = txtbx_company.ReadOnly = false;
            but_browse.Enabled = true;
        }

        private void but_insert_Click(object sender, EventArgs e)
        {
            UnlockInputs();
            rowindex = -1;
            txtbx_title.Text = txtbx_genre.Text = txtbx_platform.Text = txtbx_company.Text = txtbx_price.Text = null;
            pbx_splash.BackgroundImage = null;
            imgPath = string.Empty;
        }

        private void but_update_Click(object sender, EventArgs e)
        {
            if(rowindex<0)
            {
                MessageBox.Show("Please Choose a game to update", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            else
            {
                UnlockInputs();
            }
        }

        private void but_delete_Click(object sender, EventArgs e)
        {
            if (rowindex < 0)
            {
                MessageBox.Show("Please Choose a game to delete", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            try
            {
                conn.Open();
                int id2Remove = int.Parse(dgv_games.Rows[rowindex].Cells["game_id"].Value.ToString());
                cmd = new NpgsqlCommand($"delete from game where game_id={id2Remove}", conn);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Deleted Game Successfully");
                rowindex = -1;
                conn.Close();
                RefreshTable();
            }
            catch (Exception ex)
            {
                conn.Close();
                MessageBox.Show($"Delete Failed Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void but_save_Click(object sender, EventArgs e)
        {
           if(rowindex<0)
            {
                try
                {
                    conn.Open();
                    cmd = new NpgsqlCommand($"INSERT INTO Game (game_name,genre,price,company,platform,splashart) VALUES('{txtbx_title.Text}'," +
                        $"'{txtbx_genre.Text}','{txtbx_price.Text}','{txtbx_company.Text}','{txtbx_platform.Text}','{imgPath}')", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Game Added Successfully");
                    conn.Close();
                    RefreshTable();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show($"Insertion Failed Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           else
            {
                try
                {
                    if(imgPath==String.Empty)
                    {
                        imgPath = dgv_games.Rows[rowindex].Cells["splashart"].Value.ToString();
                    }
                    conn.Open();
                    cmd = new NpgsqlCommand($"UPDATE game SET game_name = '{txtbx_title.Text}', genre = '{txtbx_genre.Text}', price = '{txtbx_price.Text}'," +
                        $"company = '{txtbx_company.Text}', platform = '{txtbx_platform.Text}', splashart = '{imgPath}' where " +
                        $"game_id = {dgv_games.Rows[rowindex].Cells["game_id"].Value.ToString()}", conn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Game Updated Successfully");
                    conn.Close();
                    RefreshTable();
                }
                catch (Exception ex)
                {
                    conn.Close();
                    MessageBox.Show($"Game Update Failed Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void but_browse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg;*.jpeg;.*.gif;)|*.jpg;*.jpeg;.*.gif";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgPath = openFileDialog.FileName;
                pbx_splash.BackgroundImage = new Bitmap(openFileDialog.FileName);
                pbx_splash.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }

        private void but_home_Click(object sender, EventArgs e)
        {
            this.Close();
            HP.Show();
        }

        private void GamesList_FormClosed(object sender, FormClosedEventArgs e)
        {
            HP.Show();
            HP.HPRefresh();
        }

        private void txtbx_title_TextChanged(object sender, EventArgs e)
        {

        }

        private void but_rev_Click(object sender, EventArgs e)
        {
            GamePage GP = new GamePage(Convert.ToInt32(dgv_games.Rows[rowindex].Cells["game_id"].Value.ToString()), username);
            GP.Show();
        }
    }
}
