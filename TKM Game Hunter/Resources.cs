using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace TKM_Game_Hunter
{
    public static class Resources
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

        public const string CONSTRING = "Server=localhost;Port=5432;Database=cop4710;User Id=postgres;Password=spring99";
        public const string GETAGE = "update account set age=(select extract(year from age(dob)) from account)";

        public static string GetInfo(string username, ACC_Col colName)
        {
            object val = "NO VALUE SET";
            NpgsqlConnection conn = new NpgsqlConnection(CONSTRING);
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
            NpgsqlConnection conn = new NpgsqlConnection(CONSTRING);
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand($"update account set age = (select extract(year from age(dob)) from account where username='{username}')where username='{username}';", conn);
            cmd.ExecuteNonQueryAsync();
            
        }
    }
}
