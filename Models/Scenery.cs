using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eBooking.Models
{
   public  class Scenery
    {
       public string SYName { get; set; }
       public String SYIntroduec { get; set; }
       public int SYSupplier { get; set; }
       public string SYImagSrc { get; set; }
       public int SYPrice { get; set; }
       public int SYId { get; set; }
       public int SYTotal { get; set; }
       public int SYUseNum { get; set; }
       public DateTime SYUseTime { get; set; }
    }
}
