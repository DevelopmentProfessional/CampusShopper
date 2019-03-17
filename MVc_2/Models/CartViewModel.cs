using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVc_2.Models
{
    public class CartViewModel
    {
        public string Location { get; set; }
        public DateTime TimeStamp { get; set; } 
        public string UserID { get; set; }
    }
}