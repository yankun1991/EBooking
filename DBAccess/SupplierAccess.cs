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
  public class SupplierAccess
    {
      public static bool Loin(string userName, string passWord)
      {
          SqlConnection con = DBConnect.DBOpen();
          StringBuilder sql = new StringBuilder();
          sql.AppendFormat("select SPPassWord from {0} where SPName='{1}'and [SPValide]=1", DBConfig.Supplier, userName);
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
      public static int Select(string userName)
      {
          SqlConnection con = DBConnect.DBOpen();
          StringBuilder sql = new StringBuilder();
          sql.AppendFormat("select top 1 SPID from {0} where SPName='{1}'", DBConfig.Supplier, userName);
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
      public static DataSet Select()
      {
          DataSet ds = new DataSet();
          SqlConnection con = DBConnect.DBOpen();
          SqlDataAdapter sqld = new SqlDataAdapter("SELECT [SPID]'供应商ID',[SPLocation]'所在地',[SPName]'供应商名称',[SPValide]'供应商状态',[SPRemark]'备注' from "+DBConfig.Supplier+" ", con);
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
      public static bool DeleteSupplier(int SPId)
      {
          DataSet ds = new DataSet();
          SqlConnection con = DBConnect.DBOpen();
          SqlCommand cmd = new SqlCommand("update " + DBConfig.Supplier + "set SPValide=0 where SPID=" + SPId, con);
          int count = cmd.ExecuteNonQuery();
          if (count == 1)
          {
              DBConnect.DBClose();
              return true;
          }
          DBConnect.DBClose();
          return false;
      }
      public static bool AddSupplier(Supplier supplier)
      {
          SqlConnection con = DBConnect.DBOpen();
          SqlCommand cmd = new SqlCommand("insert into " + DBConfig.Supplier + "([SPID],[SPPassWord],[SPLocation],[SPName],[SPRemark])" +
              "values(@SPID,@SPPassWord,@SPLocation,@SPName,@SPRemark)", con);
          cmd.Parameters.AddWithValue("@SPID",supplier.SPId);
          cmd.Parameters.AddWithValue("@SPPassWord",supplier.SPPassWord);
          cmd.Parameters.AddWithValue("@SPLocation",supplier.SPLocation);
          cmd.Parameters.AddWithValue("@SPName",supplier.SPName);
          cmd.Parameters.AddWithValue("@SPRemark",supplier.SPRemark);
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
