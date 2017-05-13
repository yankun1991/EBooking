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
    /// <summary>
    /// 数据访问层：Scenery表
    /// </summary>
  public  class SceneryAccess
    {
      /// <summary>
      /// 景点添加
      /// </summary>
      /// <param name="scenery"></param>
      /// <returns></returns>
      public static bool SceneryAdd(Scenery scenery )
      {
          SqlConnection con = DBConnect.DBOpen();
          SqlCommand cmd = new SqlCommand("insert into " + DBConfig.Scenery + "(SYName,SYIntroduce,SYSupplier,SYImagSrc,SYPrice,SYTotal,SYUseTime)" +
              "values(@SYName,@SYIntroduce,@SYSupplier,@SYImagSrc,@SYPrice,@SYTotal,@SYUseTime)", con);
          cmd.Parameters.AddWithValue("@SYName",scenery.SYName );
          cmd.Parameters.AddWithValue("@SYIntroduce", scenery.SYIntroduec);
          cmd.Parameters.AddWithValue("@SYSupplier",scenery.SYSupplier);
          cmd.Parameters.AddWithValue("@SYImagSrc", scenery.SYImagSrc);
          cmd.Parameters.AddWithValue("@SYPrice",scenery.SYPrice);
          cmd.Parameters.AddWithValue("@SYTotal", scenery.SYTotal);
          cmd.Parameters.AddWithValue("@SYUseTime", scenery.SYUseTime);
          int count = cmd.ExecuteNonQuery();
          if (count == 1)
          {
              DBConnect.DBClose();
              return true;
          }
          DBConnect.DBClose();
          return false;
      }

      /// <summary>
      /// 景点展示 主页 前12条数据
      /// </summary>
      /// <returns></returns>
      public static List<Scenery> ShowImag(int pageNum)
      {
          List<Scenery> sceneryList = new List<Scenery>();
          Scenery scenery;
          SqlConnection con = DBConnect.DBOpen();
          DataSet ds = new DataSet();
          SqlDataAdapter sqld = new SqlDataAdapter("SELECT TOP 12 [SYId],[SYName],[SYIntroduce],[SYSupplier],[SYImagSrc],[SYPrice] FROM " + DBConfig.Scenery + " where SYValid=1 and SYId not in(select top ((" + pageNum + "-1)*12) SYId from " + DBConfig.Scenery + ")", con);
          sqld.Fill(ds,"user");
          DataTable dTable=ds.Tables["user"];
          DataRowCollection rows = dTable.Rows;
          if (rows.Count>0)
          {
              for (int i = 0; i < rows.Count; i++)
              {
                  scenery = new Scenery();
                  scenery.SYId=Convert.ToInt32(rows[i][0]);
                  scenery.SYName=rows[i][1].ToString();
                  scenery.SYIntroduec=rows[i][2].ToString();
                  scenery.SYSupplier = Convert.ToInt32(rows[i][3]);
                  scenery.SYImagSrc=rows[i][4].ToString();
                  scenery.SYPrice = Convert.ToInt32(rows[i][5]);
                  sceneryList.Add(scenery);
               }
          
          }
          DBConnect.DBClose();
          return sceneryList;    
      }

      /// <summary>
      /// 根据景点名称查询景点
      /// </summary>
      /// <param name="sceneryName"></param>
      /// <returns></returns>
      public static List<Scenery> Search(string sceneryName)
      {
          List<Scenery> sceneryList = new List<Scenery>();
          SqlConnection con = DBConnect.DBOpen();
           Scenery scenery;
          DataSet ds = new DataSet();
          string sql = "SELECT top 1 [SYId],[SYIntroduce],[SYName],[SYSupplier],[SYImagSrc],[SYPrice],[SYTotal],[SYUseNum],[SYUseTime] FROM [Ebooking].[dbo].[Scenery] where SYName like '%" + sceneryName + "%'";
          SqlDataAdapter sqld = new SqlDataAdapter("SELECT [SYId],[SYIntroduce],[SYName],[SYSupplier],[SYImagSrc],[SYPrice],[SYTotal] ,[SYUseNum],[SYUseTime] FROM [Ebooking].[dbo].[Scenery] where SYName like '%" + sceneryName + "%'", con);
          sqld.Fill(ds,"user");
          DataTable dTable=ds.Tables["user"];
          DataRowCollection rows = dTable.Rows;
          if (rows.Count>0)
          {
              for (int i = 0; i < rows.Count; i++)
              {
                  scenery = new Scenery();
                  scenery.SYId=Convert.ToInt32(rows[i][0]);
                  scenery.SYIntroduec = rows[i][1].ToString();
                  scenery.SYName=rows[i][2].ToString();
                  scenery.SYSupplier = Convert.ToInt32(rows[i][3]);
                  scenery.SYImagSrc=rows[i][4].ToString();
                  scenery.SYPrice = Convert.ToInt32(rows[i][5]);
                  scenery.SYTotal = Convert.ToInt32(rows[i][6]);
                  scenery.SYUseNum = Convert.ToInt32(rows[i][7]);
                  scenery.SYUseTime = Convert.ToDateTime(rows[i][8]);

                  sceneryList.Add(scenery);
              }
          
          }
          DBConnect.DBClose();

          return sceneryList;
      }
       
      /// <summary>
      /// 景点展示
      /// </summary>
      /// <returns></returns>
      public static DataSet ShowScenery()
      {
          DataSet ds = new DataSet();
          SqlConnection con = DBConnect.DBOpen();
          SqlDataAdapter sqld = new SqlDataAdapter("SELECT [SYId]'景点ID',[SYName]'景点名称',[SYValid]'景点状态',[SYPrice]'景点价格',[SYTotal]'景点门票限额',[SYUseNum]'当前售卖票数',[SYUseTime]'入园时间' FROM"+DBConfig.Scenery+"", con);
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

      /// <summary>
      /// 更具用户Id查询景点
      /// </summary>
      /// <param name="userId"></param>
      /// <returns></returns>
      public static DataSet ShowSceneryById(int userId)
      {
          DataSet ds = new DataSet();
          SqlConnection con = DBConnect.DBOpen();
          SqlDataAdapter sqld = new SqlDataAdapter("SELECT [SYId]'景点ID',[SYName]'景点名称',[SYValid]'景点状态',[SYPrice]'景点价格',[SYTotal]'景点门票限额',[SYUseNum]'当前售卖票数',[SYUseTime]'入园时间' FROM" + DBConfig.Scenery + "where [SYSupplier]="+userId, con);
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
      
      /// <summary>
      /// 删除景点根据景点Id ：置景点为无效
      /// </summary>
      /// <param name="SYId"></param>
      /// <returns></returns>
      public static bool DeleteScenery(int SYId)
      {
          DataSet ds = new DataSet();
          SqlConnection con = DBConnect.DBOpen();
          SqlCommand cmd = new SqlCommand("update " + DBConfig.Scenery + "set SYValide=0 where TKID=" + SYId, con);
          int count = cmd.ExecuteNonQuery();
          if (count == 1)
          {
              DBConnect.DBClose();
              return true;
          }
          DBConnect.DBClose();
          return false;
      }

      /// <summary>
      /// 根据景点ID查询相应的景点
      /// </summary>
      /// <param name="SYId"></param>
      /// <returns></returns>
      public static Scenery SelectById(int SYId)
      {
          SqlConnection con = DBConnect.DBOpen();
          Scenery scenery=new Scenery();
          DataSet ds = new DataSet();
          SqlDataAdapter sqld = new SqlDataAdapter("SELECT SYName'景点名称',SYIntroduce'景点简介',SYSupplier'供应商',SYImagSrc'图片',SYPrice'价格',SYTotal'门票限额',SYUseTime'入园时间', SYUseNum '当前已售卖张数' FROM " + DBConfig.Scenery + "where SYId=" + SYId, con);
          sqld.Fill(ds, "user");
          DataTable dTable = ds.Tables["user"];
          DataRowCollection rows = dTable.Rows;
          if (rows.Count > 0)
          {
              for (int i = 0; i < rows.Count; i++)
              {
                  scenery = new Scenery();
                  scenery.SYName = rows[i][0].ToString();
                  scenery.SYIntroduec = rows[i][1].ToString();
                  scenery.SYSupplier = Convert.ToInt32(rows[i][2]);
                  scenery.SYImagSrc = rows[i][3].ToString();
                  scenery.SYPrice = Convert.ToInt32(rows[i][4]);
                  scenery.SYTotal = Convert.ToInt32(rows[i][5]);
                  scenery.SYUseTime = Convert.ToDateTime(rows[i][6]);
                  scenery.SYUseNum = Convert.ToInt32(rows[i][7]);
              }
          }
          DBConnect.DBClose();
          return scenery;
      }

      /// <summary>
      /// 根据不同分销商查询景点用以显示
      /// </summary>
      /// <param name="DTId"></param>
      /// <returns></returns>
      public static DataSet selectForDistributor(int DTId)
      {
          DataSet ds = new DataSet();
          SqlConnection con = DBConnect.DBOpen();

          SqlDataAdapter sqld = new SqlDataAdapter("SELECT  [SYId]'景点Id', SYName'景点名称',SYIntroduce'景点简介',SYSupplier'供应商',SYImagSrc'图片',SYPrice'价格',SYTotal'门票限额',SYUseTime'入园时间',SYUseNum'已售卖张数'"
              +" From"+DBConfig.Scenery+" sc ,"+DBConfig.Distributor+"dt,"+DBConfig.Role+" rl,"+DBConfig.RoleProduct+"rp"
          + " where dt.DTRoleId=rl.RLId and rl.RLProductID=rp.RPId and [RPProductId]=sc.SYId and dt.DTId=" + DTId, con);
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

      /// <summary>
      /// 景点更新：供应商
      /// </summary>
      /// <param name="scenery"></param>
      /// <returns></returns>
      public static bool SceneryUpdateForSupplier(Scenery scenery)
      {
          SqlConnection con = DBConnect.DBOpen();
          SqlCommand cmd = new SqlCommand("update " + DBConfig.Scenery + "set SYName='"+scenery.SYName+"',SYIntroduce='"+scenery.SYIntroduec+"',SYSupplier="+scenery.SYSupplier+",SYImagSrc='"+scenery.SYImagSrc+"',SYPrice="+scenery.SYPrice+",SYTotal="+scenery.SYTotal+",SYUseTime='"+scenery.SYUseTime+"' where SYId=" + scenery.SYId, con);
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

      /// <summary>
      /// 门票预订成功后更新相应景点的状态
      /// </summary>
      /// <param name="order"></param>
      /// <returns></returns>
      public static bool SceneryUpdateForOrder(Oreder order)
      {

          SqlConnection con = DBConnect.DBOpen();
          SqlCommand cmd = new SqlCommand("update " + DBConfig.Scenery + " set SYUseNum=SYUseNum+" + order.TKNum + " where SYId=" + order.TKSYId + "and [SYUseTime]='"+order.TKUseTime+"'", con);
          int count = cmd.ExecuteNonQuery();
          if (count == 1)
          {
              DBConnect.DBClose();
              return true;
          }
          DBConnect.DBClose();
          return false;
      }

      /// <summary>
      /// 根据门票出行时间查询门票信息
      /// </summary>
      /// <param name="dataTime"></param>
      /// <returns></returns>
      public static bool ShowSceneryByUseTime(DateTime dataTime)
      {
          DataSet ds = new DataSet();
          SqlConnection con = DBConnect.DBOpen();
          SqlDataAdapter sqld = new SqlDataAdapter("SELECT * FROM" + DBConfig.Scenery + "where [SYUseTime]='"+dataTime+"'and SYValid=1", con);
          sqld.Fill(ds);
          if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
          {
              DBConnect.DBClose();
              return true;
          }
          DBConnect.DBClose();
          return false;
      }

      /// <summary>
      /// 管理员审核景点通过，置为有效
      /// </summary>
      /// <param name="SYId"></param>
      /// <returns></returns>
      public static bool SceneryPass(int SYId)
      {
          SqlConnection con = DBConnect.DBOpen();
          SqlCommand cmd = new SqlCommand("update " + DBConfig.Scenery + "set [SYValid]=1 where SYId=" + SYId, con);
          int count = cmd.ExecuteNonQuery();
          if (count == 1)
          {
              DBConnect.DBClose();
              return true;
          }
          DBConnect.DBClose();
          return false;
      }

      /// <summary>
      /// 展示新增景点：管理员审核使用
      /// </summary>
      /// <returns></returns>
      public static DataSet ShowSceneryForSupper()
      {
          DataSet ds = new DataSet();
          SqlConnection con = DBConnect.DBOpen();
          SqlDataAdapter sqld = new SqlDataAdapter("SELECT [SYId]'景点ID',[SYName]'景点名称',[SYValid]'景点状态',[SYPrice]'景点价格',[SYTotal]'景点门票限额' FROM" + DBConfig.Scenery + "where [SYValid]=0", con);
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


      public static int SceneryCount()
      {
          int Count=0;
          SqlConnection con = DBConnect.DBOpen();
          DataSet ds = new DataSet();
          SqlDataAdapter sqld = new SqlDataAdapter("SELECT count(*) FROM " + DBConfig.Scenery, con);
          sqld.Fill(ds, "user");
          DataTable dTable = ds.Tables["user"];
          DataRowCollection rows = dTable.Rows;
          if (rows.Count > 0)
          {
              Count = Convert.ToInt32(rows[0][0]);
          }
          DBConnect.DBClose();
          return Count;
      }
    }

}
