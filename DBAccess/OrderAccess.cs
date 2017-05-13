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
   public  class OrderAccess
    {
       public static bool AddOrder(Oreder order)
       {
           SqlConnection con = DBConnect.DBOpen();
           SqlCommand cmd = new SqlCommand("insert into " + DBConfig.Order + "([TKType],[TKPrice],[TKReserveTime],[TKUseTime],[TKSupplier],[TKImagSrc],[TKUserId],[TKNum],[TKSYId])" +
               "values(@TKType,@TKPrice,@TKReserveTime,@TKUseTime,@TKSupplier,@TKImagSrc,@TKUserId,@TKNum,@TKSYId)", con);
           cmd.Parameters.AddWithValue("@TKType",order.TKType);
           cmd.Parameters.AddWithValue("@TKPrice",order.TKPrice);
           cmd.Parameters.AddWithValue("@TKReserveTime",order.TKReserveTime);
           cmd.Parameters.AddWithValue("@TKUseTime",order.TKUseTime);
           cmd.Parameters.AddWithValue("@TKSupplier",order.TKSupplier);
           cmd.Parameters.AddWithValue("@TKImagSrc",order.TKImagSrc);
           cmd.Parameters.AddWithValue("@TKUserId",order.TKUserId);
           cmd.Parameters.AddWithValue("@TKNum",order.TKNum);
           cmd.Parameters.AddWithValue("@TKSYId", order.TKSYId);
           int count = cmd.ExecuteNonQuery();
           if (count == 1)
           {
               DBConnect.DBClose();
               SceneryAccess.SceneryUpdateForOrder(order);
               return true;
           }
           DBConnect.DBClose();
           return false;     
       }
       public static DataSet ShowOrder(int userId)
       {
           DataSet ds = new DataSet();
           SqlConnection con = DBConnect.DBOpen();
           SqlDataAdapter sqld = new SqlDataAdapter("SELECT [TKID] '用户名',[TKType] '票型',[TKReserveTime]'预订时间',[TKUseTime]'使用时间' ,[TKState]'门票状态',[TKPrice]'门票价格',[TKNum]'门票数量'FROM " + DBConfig.Order + "where TKValide=1 and [TKUserId]="+userId, con);
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
       public static DataSet ShowOrderOfDate(int userId)
       {
           DataSet ds = new DataSet();
           SqlConnection con = DBConnect.DBOpen();
           SqlDataAdapter sqld = new SqlDataAdapter("SELECT [TKID] '订单号',[TKType] '票型',[TKReserveTime]'预订时间',[TKUseTime]'使用时间' ,[TKState]'门票状态',[TKPrice]'门票价格',[TKNum]'门票数量'FROM " + DBConfig.Order + "where TKValide=1 and TKState=2 and [TKUseTime]<'" + DateTime.Now + "' and [TKUserId]=" + userId, con);
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
       public static bool DeleteOrder(int TKId)
       {
           DataSet ds = new DataSet();
           SqlConnection con = DBConnect.DBOpen();
           SqlCommand cmd = new SqlCommand("update "+DBConfig.Order+"set TKValide=0 where TKID="+TKId, con);
           int count = cmd.ExecuteNonQuery();
           if (count == 1)
           {
               DBConnect.DBClose();
               return true;
           }
           DBConnect.DBClose();
           return false;     
       }
       public static bool RemarkOrder(int TKId,string content)
       {
           DataSet ds = new DataSet();
           SqlConnection con = DBConnect.DBOpen();
           SqlCommand cmd = new SqlCommand("update " + DBConfig.Order + "set [TKRemark]='" + content + "' where TKRemark= 'no' and TKID=" + TKId, con);
           int count = cmd.ExecuteNonQuery();
           if (count == 1)
           {
               DBConnect.DBClose();
               return true;
           }
           DBConnect.DBClose();
           return false;
       }
       public static DataSet ShowOrderForDistributor(int USId)
       {
           DataSet ds = new DataSet();
           SqlConnection con = DBConnect.DBOpen();
           SqlDataAdapter sqld = new SqlDataAdapter("SELECT [TKID] '订单ID',[TKType] '票型',[TKReserveTime]'预订时间',[TKUseTime]'使用时间' ,[TKState]'门票状态',[TKPrice]'门票价格',[TKNum]'门票数量'FROM " + DBConfig.Order + "where TKValide=1 and TKUserId="+USId, con);
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
    }
}
