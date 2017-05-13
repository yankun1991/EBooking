using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace eBooking.Models 
{
    public class ShopingCart
    {
        public int SCId { get;set;}
        public string SCGoodName { get; set; }
        public string SCGoodIntroduce { get; set; }
        public int SCGoodPrice { get; set; }
        public int SCState { get; set; }
        public int SCGoodNum { get; set; }
        public DateTime SCGoodAddTime { get; set; }
        public int SCGoodId { get; set; }
    }
}