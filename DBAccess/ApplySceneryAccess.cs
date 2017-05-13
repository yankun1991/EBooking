using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using eBooking.DBhelper;
using System.Data.SqlClient;
using eBooking.Models;
using System.Data;

namespace eBooking.DBAccess
{
 public class ApplySceneryAccess
    {
     public static bool AddApply(ApplyScenery applyScenery)
     {
         SqlConnection con = DBConnect.DBOpen();
         SqlCommand cmd = new SqlCommand("insert into " + DBConfig.ApplyScenery + "([ASDTId],[ASSYId])" +
             "values(@ASDTId,@ASSYId)", con);
         cmd.Parameters.AddWithValue("@ASDTId",applyScenery.ASDTId);
         cmd.Parameters.AddWithValue("@ASSYId",applyScenery.ASSYId);
         int count = cmd.ExecuteNonQuery();
         if (count == 1)
         {
             DBConnect.DBClose();
             return true;
         }
         DBConnect.DBClose();
         return false;
     }
     public static DataSet selectForApply(int DTId)
     {
         DataSet ds = new DataSet();
         SqlConnection con = DBConnect.DBOpen();

         SqlDataAdapter sqld = new SqlDataAdapter("SELECT [ASId]'记录ID',[ASSYId]'申请景点Id',[ASState]'申请状态' FROM " + DBConfig.ApplyScenery + "where  [ASDTId]="+DTId, con);
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
     public static DataSet selectForApply()
     {
         DataSet ds = new DataSet();
         SqlConnection con = DBConnect.DBOpen();

         SqlDataAdapter sqld = new SqlDataAdapter("SELECT [ASId]'记录ID',[ASSYId]'申请景点Id',[ASDTId]'分销商ID',[ASState]'申请状态' FROM " + DBConfig.ApplyScenery, con);
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
     public static bool AgreeAP(int APId)
     {
         DataSet ds = new DataSet();
         SqlConnection con = DBConnect.DBOpen();
         SqlCommand cmd = new SqlCommand("update " + DBConfig.ApplyScenery + "set ASState=1 where ASId=" + APId, con);
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
