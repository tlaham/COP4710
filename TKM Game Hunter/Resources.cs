using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TKM_Game_Hunter
{
    public static class Resources
    {
        public const string CONSTRING = "Server=localhost;Port=5432;Database=cop4710;User Id=postgres;Password=spring99";
        public const string GETAGE = "select extract(year from age(dob)) from account";
    }
}
