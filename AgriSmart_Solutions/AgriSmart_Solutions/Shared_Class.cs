using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AgriSmart_Solutions
{
    internal class Shared_Class
    {
        public static string Username = "";

        public static string User_Role = "";

        public static string LoginUserName = "";

        public static string User_Login = "";
        public static int User_Id = 0;
        public static int Flag = 0 ;

        public static int C_Id = 0; /// Single Customer Report Parameter

        /*public static int R = 0;
        public static string D = "";
        public static double B = 0;
        */
        public static int Auto_Incr(string TableName , string ColName , int Spt)
        {
            int Cnt = 0;

            Connection.Con_Open();

            SqlCommand Cmd = new SqlCommand();

            Cmd.Connection = Connection.DBCon;
            Cmd.CommandText = "Select Count(*) From " + TableName;

            Cnt = Convert.ToInt32(Cmd.ExecuteScalar());

            Cmd.Dispose();

            if(Cnt > 0 )
            {
                Cmd.Connection = Connection.DBCon;
                Cmd.CommandText = "Select Max(" + ColName + ") From " + TableName;

                Cnt = Convert.ToInt32(Cmd.ExecuteScalar()) + 1;
  
            }
            else
            {
                Cnt = Spt;
            }

            Connection.Con_Close();

            return Cnt;
        }

        public static void Bind_ComboBox(String ColName, ComboBox Cmbobj, string Query)
        {
            Connection.Con_Open();

            SqlCommand Cmd = new SqlCommand(Query,Connection.DBCon);
            SqlDataReader SDR = Cmd.ExecuteReader();

            Cmbobj.Items.Clear();

            while(SDR.Read())
            {
                ///Cmbobj.Items.Add(SDR.GetString(SDR.GetOrdinal(ColName)));
                string Val = SDR[ColName].ToString();
                Cmbobj.Items.Add(Val);
            }
            
            Connection.Con_Close();
        }

        public static void Bind_Date_ComboBox(String ColName, ComboBox Cmbobj, string Query)
        {
            Connection.Con_Open();

            SqlCommand Cmd = new SqlCommand(Query, Connection.DBCon);
            SqlDataReader SDR = Cmd.ExecuteReader();

            Cmbobj.Items.Clear();

            while (SDR.Read())
            {
                ///Cmbobj.Items.Add(SDR.GetString(SDR.GetOrdinal(ColName)));
                DateTime Val = Convert.ToDateTime(SDR[ColName].ToString());

                DateTime Dt = Val.Date;

                DateTime Today_Date = System.DateTime.Today.Date;
                if (Dt != Today_Date)
                {
                    Cmbobj.Items.Add(Dt);
                }
                   
            }

            Connection.Con_Close();
        }

        /*public static void Num_Bind_ComboBox(String ColName, ComboBox Cmbobj, string Query)
        {
            Connection.Con_Open();

            SqlCommand Cmd = new SqlCommand(Query, Connection.DBCon);
            SqlDataReader SDR = Cmd.ExecuteReader();

            Cmbobj.Items.Clear();

            while (SDR.Read())
            {
                Cmbobj.Items.Add(SDR[ColName].ToString());
            }

            Connection.Con_Close();
        }*/
        public static void Generate_Id()
        {
            Connection.Con_Open();

            SqlCommand Cmd = new SqlCommand();
            Cmd.CommandText = "Select User_Id from Login_Details where Username = @Unm";
            Cmd.Connection = Connection.DBCon;

            Cmd.Parameters.Add("Unm", SqlDbType.NVarChar).Value = Shared_Class.User_Login;

            User_Id = Convert.ToInt32(Cmd.ExecuteScalar());
            Connection.Con_Close();
        }

        public static void Bind_Grid(DataGridView dgv, string Query)
        {
            Connection.Con_Open();

            //dgv.Rows.Clear();

            SqlDataAdapter sda = new SqlDataAdapter(Query, Connection.DBCon);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            dgv.DataSource = dt;

            Connection.Con_Close();
        }


    }
}
