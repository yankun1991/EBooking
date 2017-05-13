using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using eBooking.DBhelper;
using System.Data;
using eBooking.Models;

namespace eBooking.DBAccess
{
  public class DistributorAccess
    {
        public static int Select(string userName)
        {
            SqlConnection con = DBConnect.DBOpen();
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select top 1 DTId from {0} where DTName='{1}'", DBConfig.Distributor, userName);
            SqlCommand cmd = new SqlCommand(sql.ToString(), con);
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                if (!reader.IsDBNull(0))
                {
                    int userId = reader.GetInt32(0);
                    DBConnect.DBClose();
                    return userId;
                }
            }
            DBConnect.DBClose();
            return 0;
        }

        public static bool Loin(string userName, string passWord)
        {
            SqlConnection con = DBConnect.DBOpen();
            StringBuilder sql = new StringBuilder();
            sql.AppendFormat("select DTPassWord from {0} where DTName='{1} 'and [DTValid]=1", DBConfig.Distributor, userName);
            SqlCommand cmd = new SqlCommand(sql.ToString(), con);
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
        public static DataSet Select()
        {
            DataSet ds = new DataSet();
            SqlConnection con = DBConnect.DBOpen();
            SqlDataAdapter sqld = new SqlDataAdapter("select DTID '分销商ID',DTName '分销名称',[DTAccount] '分销商账户',DTRoleId'分销商角色Id' from " + DBConfig.Distributor + " where DTValid=1", con);
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
        public static bool SelectById(int userId)
        {
            DataSet ds = new DataSet();
            SqlConnection con = DBConnect.DBOpen();
            SqlDataAdapter sqld = new SqlDataAdapter("select * from " + DBConfig.Distributor + " where DTId="+userId, con);
            sqld.Fill(ds, "user");
            DataTable dTable = ds.Tables["user"];
            DataRowCollection rows = dTable.Rows;
            if (rows.Count > 0)
            {
                DBConnect.DBClose();
                return true;
            }
            DBConnect.DBClose();
            return false;
        }
        public static bool DeleteDistribute(int DTId)
        {
            DataSet ds = new DataSet();
            SqlConnection con = DBConnect.DBOpen();
            SqlCommand cmd = new SqlCommand("update " + DBConfig.Distributor + "set DTValid=0 where DTId=" + DTId, con);
            int count = cmd.ExecuteNonQuery();
            if (count == 1)
            {
                DBConnect.DBClose();
                return true;
            }
            DBConnect.DBClose();
            return false;
        }
        public static bool AddDistribute(Distributor distributor)
        {
            SqlConnection con = DBConnect.DBOpen();
            SqlCommand cmd = new SqlCommand("insert into " + DBConfig.Distributor + "([DTId] ,[DTName] ,[DTRoleId],[DTPassWord],[DTRemark])" +
                "values(@DTId,@DTName,@DTRoleId,@DTPassWord,@DTRemark)", con);
            cmd.Parameters.AddWithValue("@DTId",distributor.DTId );
            cmd.Parameters.AddWithValue("@DTName",distributor.DTName);
            cmd.Parameters.AddWithValue("@DTRoleId",distributor.DTRoleId);
         //   cmd.Parameters.AddWithValue("@DTAccount", distributor.DTAccount);
            cmd.Parameters.AddWithValue("@DTPassWord",distributor.DTPassWord );
            cmd.Parameters.AddWithValue("@DTRemark", distributor.DTRemark);
            int count = cmd.ExecuteNonQuery();
            if (count == 1)
            {
                DBConnect.DBClose();
                return true;
            }
            DBConnect.DBClose();
            return false;
        }
        //public static DataSet SelectById(int DTId)
        //{
        //    DataSet ds = new DataSet();
        //    SqlConnection con = DBConnect.DBOpen();
        //    SqlDataAdapter sqld = new SqlDataAdapter("select DTID '分销商ID',DTName '分销名称',[DTAccount] '分销商账户' from " + DBConfig.Distributor + " where DTValid=1", con);
        //    sqld.Fill(ds, "user");
        //    DataTable dTable = ds.Tables["user"];
        //    DataRowCollection rows = dTable.Rows;
        //    if (rows.Count > 0)
        //    {
        //        DBConnect.DBClose();
        //        return ds;
        //    }
        //    DBConnect.DBClose();
        //    return null;
        //}
    }
}
