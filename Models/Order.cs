using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace eBooking.Models
{
    public class Oreder
    {
        public int TKId { get; set; }
        public int TKType { get; set; }
        public int TKPrice { get; set; }
        public DateTime TKReserveTime { get; set; }
        public DateTime TKUseTime { get; set; }
        public int TKValide { get; set; }
        public int TKSupplier { get; set; }
        public int TKState { get; set; }
        public string TKRemark { get; set; }
        public string TKImagSrc { get;set; }
        public int TKUserId { get; set; }
        public int TKNum { get; set; }
        public int TKSYId { get; set; }
    }
}