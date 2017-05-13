using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using eBooking.Models;
using eBooking.DBhelper;
using System.Data.SqlClient;
using System.Text;
using System.Data;
namespace eBooking.DBAccess
{
    public class AdminAccess
    {
        public static  bool Loin(string userName,string passWord)
        {
            SqlConnection con= DBConnect.DBOpen();
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select ACPassWord from {0} where ACID={1} and ACValide=1", DBConfig.Admin, userName);
            SqlCommand cmd = new SqlCommand(sql.ToString(),con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    string pass = reader.GetString(0);
                    if (pass != null && passWord != null && passWord == pass)
                    {
                        DBConnect.DBClose();
                        return true;
                    }
                }   
            }
            DBConnect.DBClose();
            return false;
        }
        public static bool AddSupperUser(Admin admin)
        {
            SqlConnection con = DBConnect.DBOpen();
            SqlCommand cmd = new SqlCommand("insert into " + DBConfig.Admin + "([ACID],[ACPassWord])" +
                "values(@ACID,@ACPassWord)", con);
            cmd.Parameters.AddWithValue("@ACID",admin.ACId);
            cmd.Parameters.AddWithValue("@ACPassWord",admin.ACPassWord);
            try
            {
                int count = cmd.ExecuteNonQuery();
                if (count == 1)
                {
                    DBConnect.DBClose();
                    return true;
                }
                DBConnect.DBClose();
            }
            catch
            {
                DBConnect.DBClose();
                return false;
            }
            return false;
        }
        public static DataSet ShowSupperUser()
        {
            DataSet ds = new DataSet();
            SqlConnection con = DBConnect.DBOpen();
            SqlDataAdapter sqld = new SqlDataAdapter("SELECT [ACID]'用户ID',[ACPassWord]'用户密码' from " + DBConfig.Admin + " where ACValide=1", con);
            sqld.Fill(ds, "user");
            DataTable dTable = ds.Tables["user"];
            DataRowCollection rows = dTable.Rows;
            if (rows.Count > 0)
            {
                DBConnect.DBClose();
                return ds;
            }
            DBConnect.DBClose();
            return null;
        }
        public static bool DeleteSupperUser(int ACId)
        {
            DataSet ds = new DataSet();
            SqlConnection con = DBConnect.DBOpen();
            SqlCommand cmd = new SqlCommand("update " + DBConfig.Admin + "set ACValide=0 where ACId=" + ACId, con);
            int count = cmd.ExecuteNonQuery();
            if (count == 1)
            {
                DBConnect.DBClose();
                return true;
            }
            DBConnect.DBClose();
            return false;
        }
    
    }

}