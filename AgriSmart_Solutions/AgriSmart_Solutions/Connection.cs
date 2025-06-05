using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace AgriSmart_Solutions
{
    internal class Connection
    {
        public static SqlConnection DBCon = new SqlConnection(@"Data Source=DESKTOP-38U3S54;Initial Catalog=AgriSmart_Solutions_DB;Integrated Security=True");

        public static void Con_Open()
        {
            if(DBCon.State != ConnectionState.Open)
            {
                DBCon.Open();
            }
        }

        public static void Con_Close()
        {
            if(DBCon.State != ConnectionState.Closed)
            {
                DBCon.Close();
            }
        }
    }
}
