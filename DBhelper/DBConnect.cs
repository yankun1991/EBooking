using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace eBooking.DBhelper
{
    public class DBConnect
    {

        public static string strCnn = @"Data Source=localhost;Initial Catalog=Ebooking;Integrated Security=True";
        public static SqlConnection con = new SqlConnection(strCnn);
        public static SqlConnection DBOpen()
        {
            con.Open();
            return con;
        }
        public static void DBClose()
        {
            con.Close();
        }
    }
}