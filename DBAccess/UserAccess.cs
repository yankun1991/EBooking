using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using eBooking.DBhelper;
using eBooking.Models;
using System.Data;

namespace eBooking.DBAccess
{
   public  class UserAccess
    {
       public static bool Add(User user)
       {
         SqlConnection con = DBConnect.DBOpen();
           SqlCommand cmd = new SqlCommand("insert into " + DBConfig.User + "(USName,USPhone,USPassWord,USValid,USRegisterTime,USLastLoginTime,USLastLoginIp,USMail)"+
               "values(@USName,@USPhone,@USPassWord,@USValid,@USRegisterTime,@USLastLoginTime,@USLastLoginIp,@USMail)", con);
                   cmd.Parameters.AddWithValue("@USName",user.USName);
                   cmd.Parameters.AddWithValue("@USPhone", user.USPhone);
                   cmd.Parameters.AddWithValue("@USPassWord", user.USPassWord);
                   cmd.Parameters.AddWithValue("@USValid", user.USValid);
                   cmd.Parameters.AddWithValue("@USRegisterTime", user.USRegisterTime);
                   cmd.Parameters.AddWithValue("@USLastLoginTime", user.USLastLoginTime);
                   cmd.Parameters.AddWithValue("@USLastLoginIp", user.USLastLoginIp);
                   cmd.Parameters.AddWithValue("@USMail", user.USEmail);
           int count = cmd.ExecuteNonQuery();
           if (count == 1)
           {
               DBConnect.DBClose();
               return true;
           }
           DBConnect.DBClose();
           return false;
       }
       public static int Select(string userName)
       {
           SqlConnection con = DBConnect.DBOpen();
           StringBuilder sql = new StringBuilder();
           sql.AppendFormat("select top 1 USId from {0} where USName='{1}'", DBConfig.User, userName);
           SqlCommand cmd = new SqlCommand(sql.ToString(), con);
           SqlDataReader reader = cmd.ExecuteReader();
           if (reader.Read())
           {
               if (!reader.IsDBNull(0))
               {       
                       int userId=reader.GetInt32(0);
                       DBConnect.DBClose();
                       return userId;                
               }
           }
           DBConnect.DBClose();
           return 0;
       }
       public static User Select(int userId)
       {
           SqlConnection con = DBConnect.DBOpen();
           User user = new User();
           DataSet ds = new DataSet();
           SqlDataAdapter sqld = new SqlDataAdapter("select [USName] ,[USPhone],[USGrade],[USLastLoginTime],[USLastLoginIp],[USRemark],[USMail],[USCount],[USId] from" + DBConfig.User + "where [USId]=" + userId, con);
           sqld.Fill(ds, "user");
           DataTable dTable = ds.Tables["user"];
           DataRowCollection rows = dTable.Rows;
           if (rows.Count > 0)
           {
             user.USName=rows[0][0]+"";
             user.USPhone = rows[0][1]+"";
             user.USGrade = Convert.ToInt32(rows[0][2]);
             user.USLastLoginTime = Convert.ToDateTime(rows[0][3]);
             user.USLastLoginIp=rows[0][4]+"";
             user.USRemark=rows[0][5]+"";
             user.USEmail = rows[0][6] + "";
             user.USCount = Convert.ToInt32(rows[0][7]);
             user.USId = Convert.ToInt32(rows[0][8]);
           }
           DBConnect.DBClose();
           return user;
       }
       public static bool Loin(string userName, string passWord)
       {
           SqlConnection con = DBConnect.DBOpen();
           StringBuilder sql = new StringBuilder();
           sql.AppendFormat("select USPassWord from {0} where USName='{1}' and USValid=1 ", DBConfig.User, userName);
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

       public static bool CountofUpdate(int userId)
       {
           SqlConnection con = DBConnect.DBOpen();
           StringBuilder sql = new StringBuilder();
           sql.AppendFormat("Update " + DBConfig.User + " set [USCount]=[USCount]+5 where [USId]=" + userId);
           SqlCommand cmd = new SqlCommand(sql.ToString(), con);
            int count = cmd.ExecuteNonQuery();
            if (count == 1)
            {
                DBConnect.DBClose();
                return true;
            }
            DBConnect.DBClose();
            return false;
       }

       public  static int PayOffForUser(int userId, int orderId)
       {
           SqlConnection con = DBConnect.DBOpen();
           DataSet ds = new DataSet();
           StringBuilder sql = new StringBuilder();
           int TKPrice = -1;
           int account = -1;
           int TKNum = 0;
           SqlDataAdapter sqld1 = new SqlDataAdapter("SELECT [TKPrice],[TKNum] FROM " + DBConfig.Order + "where TKID=" + orderId, con);
           sqld1.Fill(ds, "user");
           DataTable dTable1 = ds.Tables["user"];
           DataRowCollection rows1 = dTable1.Rows;
           if (rows1.Count > 0)
           {
               TKPrice = Convert.ToInt32(rows1[0][0]);
               TKNum = Convert.ToInt32(rows1[0][1]);
               DataSet ds1 = new DataSet();
               SqlDataAdapter sqld2 = new SqlDataAdapter("SELECT [USCount] FROM " + DBConfig.User + "where USId=" + userId, con);
               sqld2.Fill(ds1, "user");
               DataTable dTable2 = ds1.Tables["user"];
               DataRowCollection rows2 = dTable2.Rows;
               if (rows2.Count > 0)
               {
                   account = Convert.ToInt32(rows2[0][0]);
               }
               if (account < TKPrice * TKNum)
               {
                   DBConnect.DBClose();
                   return 1;
               }
               sql.AppendFormat("Update " + DBConfig.User + " set [USCount]=[USCount]-" + TKPrice + " where [USId]=" + userId);
               SqlCommand cmd = new SqlCommand(sql.ToString(), con);
               int count = cmd.ExecuteNonQuery();
               if (count == 1)
               {
                   StringBuilder sql1 = new StringBuilder();
                   sql1.AppendFormat("Update " + DBConfig.Order + " set [TKState]=2 where TKID=" + orderId);
                   SqlCommand cmd1 = new SqlCommand(sql1.ToString(), con);
                   int count1 = cmd1.ExecuteNonQuery();
                   if (count1 == 1)
                   {
                       DBConnect.DBClose();
                       return 2;
                   }
               }
           }
          
           DBConnect.DBClose();
           return 0;
       }
       public static int PayOffForDistributor(int userId, int orderId)
       {
           SqlConnection con = DBConnect.DBOpen();
           DataSet ds = new DataSet();
           StringBuilder sql = new StringBuilder();
           int TKPrice = -1;
           int account = -1;
           int TKNum = 0;
           SqlDataAdapter sqld1 = new SqlDataAdapter("SELECT [TKPrice],[TKNum] FROM " + DBConfig.Order + "where TKID=" + orderId, con);
           sqld1.Fill(ds, "user");
           DataTable dTable1 = ds.Tables["user"];
           DataRowCollection rows1 = dTable1.Rows;
           if (rows1.Count > 0)
           {
               TKPrice = Convert.ToInt32(rows1[0][0]);
               TKNum = Convert.ToInt32(rows1[0][1]);
               DataSet ds1 = new DataSet();
               SqlDataAdapter sqld2 = new SqlDataAdapter("SELECT [DTAccount] FROM " + DBConfig.Distributor + "where [DTId]=" + userId, con);
               sqld2.Fill(ds1, "user");
               DataTable dTable2 = ds1.Tables["user"];
               DataRowCollection rows2 = dTable2.Rows;
               if (rows2.Count > 0)
               {
                   account = Convert.ToInt32(rows2[0][0]);
               }
               if (account < TKPrice * TKNum)
               {
                   DBConnect.DBClose();
                   return 1;
               }
               sql.AppendFormat("Update " + DBConfig.Distributor + " set [DTAccount]=[DTAccount]-" + TKPrice + " where [DTId]=" + userId);
               SqlCommand cmd = new SqlCommand(sql.ToString(), con);
               int count = cmd.ExecuteNonQuery();
               if (count == 1)
               {
                   StringBuilder sql1 = new StringBuilder();
                   sql1.AppendFormat("Update " + DBConfig.Order + " set [TKState]=2 where TKID=" + orderId);
                   SqlCommand cmd1 = new SqlCommand(sql1.ToString(), con);
                   int count1 = cmd1.ExecuteNonQuery();
                   if (count1 == 1)
                   {
                       DBConnect.DBClose();
                       return 2;
                   }
               }
           }

           DBConnect.DBClose();
           return 0;
       }
    }
}
