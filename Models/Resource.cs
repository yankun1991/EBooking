using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
namespace eBooking.Models
{
    public class Resource
    {
        public int REId { get; set; }
        public string REName { get; set; }
        public int RESupplierId { get; set; }
        public int RETotal { get; set; }
        public int REUseNum { get; set; }
        public DateTime REUseTime{ get; set; }
        public int REPrice { get; set; }
    }
}