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
        public GamesList()
        {
            InitializeComponent();
        }

        private void GamesList_Load(object sender, EventArgs e)
        {
            conn = new NpgsqlConnection(CONSTRING);
            this.Select();
        }

        private void Select()
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand("select * from game", conn);
            DataTable dt = new DataTable();
            dt.Load(cmd.ExecuteReader());
            conn.Close();
            dgv_games.DataSource = null;
            dgv_games.DataSource = dt;
        }

        private void dgv_games_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                txtbx_title.Text = dgv_games.Rows[e.RowIndex].Cells["game_name"].Value.ToString();
                pbx_splash.BackgroundImage = Image.FromFile(dgv_games.Rows[e.RowIndex].Cells["splashart"].Value.ToString());
                pbx_splash.BackgroundImageLayout = ImageLayout.Stretch;
            }
        }
    }
}
