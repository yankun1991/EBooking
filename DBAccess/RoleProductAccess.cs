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
    public class RoleProductAccess
    {
        public static bool AddRoleProduct(RoleProduct roleProduct)
        {
            SqlConnection con = DBConnect.DBOpen();
            SqlCommand cmd = new SqlCommand("insert into " + DBConfig.RoleProduct + "([RPId],[RPProductId],[RPProductName])" +
                "values(@RPId,@RPProductId,@RPProductName)", con);
            cmd.Parameters.AddWithValue("@RPId", roleProduct.RPId);
            cmd.Parameters.AddWithValue("@RPProductId", roleProduct.RPProductId);
            cmd.Parameters.AddWithValue("@RPProductName", roleProduct.RPProductName);
            int count = cmd.ExecuteNonQuery();
            if (count == 1)
            {
                DBConnect.DBClose();
                return true;
            }
            DBConnect.DBClose();
            return false;
        }
        public static DataSet ShowRoleProduct()
        {
            DataSet ds = new DataSet();
            SqlConnection con = DBConnect.DBOpen();
            SqlDataAdapter sqld = new SqlDataAdapter("SELECT [RPId]'角色产品ID',[RPProductId]'产品ID',[RPProductName]'产品名称' FROM " + DBConfig.RoleProduct + "where RPValide=1", con);
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
        public static bool DeleteRoleProduct(int RPId)
        {
            DataSet ds = new DataSet();
            SqlConnection con = DBConnect.DBOpen();
            SqlCommand cmd = new SqlCommand("update " + DBConfig.RoleProduct + "set RPValide=0 where RPID=" + RPId, con);
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