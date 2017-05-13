using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBooking.Models
{
    public class User
    {
        public int USId { get; set; }
        public string USName { get; set; }
        public string USPhone { get; set; }
        public string USPassWord { get; set; }
        public int USValid { get; set; }
        public DateTime USRegisterTime { get; set; }
        public DateTime USLastLoginTime { get; set; }
        public string USLastLoginIp { get; set; }
        public string USRemark { get; set; }
        public string USEmail { get; set; }
        public int USCount { get; set; }
        public int USGrade { get; set; }
    }
}