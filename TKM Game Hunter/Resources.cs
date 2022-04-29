using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Npgsql;
using System.Windows.Forms;

namespace TKM_Game_Hunter
{
    public  class Resources
    {
        public enum ACC_Col{
            username,
            password,
            email,
            dob,
            age,
            u_type,
            profilepic
        }

        public static string CONNSTRING;
        public const string GETAGE = "update account set age=(select extract(year from age(dob)) from account)";

        static Resources()
        {
            try
            {
                CONNSTRING = (File.ReadAllText(@"..\..\..\CONNSTRING.txt"));
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public static string GetInfo(string username, ACC_Col colName)
        {
            object val = "NO VALUE SET";
            NpgsqlConnection conn = new NpgsqlConnection(CONNSTRING);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand($"select {colName.ToString()} from account where username = '{username}'",conn);
            NpgsqlDataReader NDR;
            NDR = cmd.ExecuteReader();
            NDR.Read();
            if (NDR.IsDBNull(0))
            {
                NDR.Close();
                conn.Close();
                return val.ToString();
            }
            else
            {
                val = NDR.GetValue(0);
                NDR.Close();
                conn.Close();
                return val.ToString();
            }
        }
        public static void CalcAge(string username)
        {
            NpgsqlConnection conn = new NpgsqlConnection(CONNSTRING);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand($"update account set age = (select extract(year from age(dob)) from account where username='{username}')where username='{username}';", conn);
            cmd.ExecuteNonQueryAsync();
            
        }

        public static string CalcReviews(string username)
        {
            NpgsqlConnection conn = new NpgsqlConnection(CONNSTRING);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand($"select count(*) from review where username = '{username}'",conn);
            NpgsqlDataReader NDR;
            NDR=cmd.ExecuteReader();
            NDR.Read();
            return NDR.GetValue(0).ToString();
        }
    }
}
