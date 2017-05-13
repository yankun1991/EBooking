using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace eBooking.Models
{
    public class Distributor
    {
        public int DTId { get; set; }
        public string DTName { get; set; }
        public int DTRoleId{get;set;}
        public string DTAccount{get;set;}
        public string DTAccountMoney{get;set;}
        public int DTDeposit{get;set;}
        public int DTValid { get; set; }
        public string DTPassWord { get; set; }
        public string DTRemark { get; set; }
    }

}