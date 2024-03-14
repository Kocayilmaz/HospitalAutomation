using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HastaneOtomasyon
{
    public class Baglanti
    {
        const string serverName = "DESKTOP-2CCU4AD\\MSSQLSERVERR";
        const string dataBaseName = "HastaneOtomasyonDB";
        public static SqlConnection hastaneConnection = new SqlConnection($"Server={serverName};Database={dataBaseName};Integrated Security=true;");
    }
}
