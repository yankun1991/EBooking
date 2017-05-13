using System;
namespace eBooking.DBhelper
{ 
  public static class DBConfig
  {
    public  static string Shoppingcart="[Ebooking].[dbo].[ShopingCart]";//购物车
    public static string Supplier = "[Ebooking].[dbo].[Supplier]";//供应商
    public static string Order = "[Ebooking].[dbo].[Order]";//门票
    public static string User = "[Ebooking].[dbo].[User]";//用户
    public static string Resource = "[Ebooking].[dbo].[Resource]";//资源
    public static string Distributor = "[Ebooking].[dbo].[Distributor]";//分销商
    public static string Role = "[Ebooking].[dbo].[Role]";//角色
    public static string RoleProduct = "[Ebooking].[dbo].[RoleProduct]";//角色产品
    public static string Admin = "[Ebooking].[dbo].[Admin]";//管理员
    public static string Scenery = "[Ebooking].[dbo].[Scenery]";
    public static string ApplyScenery = "[Ebooking].[dbo].[ApplyScenery]";
  }
}