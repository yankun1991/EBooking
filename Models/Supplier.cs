using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBooking.Models
{
    public class Supplier
    {
        public int SPId { get; set; }
        public string SPPassWord { get; set; }
        public string SPLocation { get; set; }
        public string SPName { get; set; }
        public int SPValide { get; set; }
        public string SPRemark { get; set; }
    }
}