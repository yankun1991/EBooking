using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eBooking.Models;
using System.Data.SqlClient;
using eBooking.DBhelper;
using System.Data;

namespace eBooking.DBAccess
{
 public  class RoleAccess
    {
     public static bool AddRole(Role role)
     {
         SqlConnection con = DBConnect.DBOpen();
         SqlCommand cmd = new SqlCommand("insert into " + DBConfig.Role + "([RLId],[RLModeOfSalary],[RLProductID])" +
             "values(@RLId,@RLModeOfSalary,@RLProductID)", con);
         cmd.Parameters.AddWithValue("@RLId", role.RLId);
         cmd.Parameters.AddWithValue("@RLModeOfSalary",role.RLModelOfsalary);
         cmd.Parameters.AddWithValue("@RLProductID",role.RLProductId);
         int count = cmd.ExecuteNonQuery();
         if (count == 1)
         {
             DBConnect.DBClose();
             return true;
         }
         DBConnect.DBClose();
         return false;     
     }
     public static DataSet ShowRole()
     {
         DataSet ds = new DataSet();
         SqlConnection con = DBConnect.DBOpen();
         SqlDataAdapter sqld = new SqlDataAdapter("SELECT [RLId] '角色ID',[RLModeOfSalary]'佣金模式',[RLProductID]'角色产品ID' from "+DBConfig.Role+" where RLValide=1", con);
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
     public static bool DeleteRole(int RLId)
     {
         DataSet ds = new DataSet();
         SqlConnection con = DBConnect.DBOpen();
         SqlCommand cmd = new SqlCommand("update " + DBConfig.Role + "set RLValide=0 where TKID=" + RLId, con);
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
