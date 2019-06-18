using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FundAppsCourierKata.Models
{
    public class OrderlineItem
    {
        public int id { get; set; }
        public int ParcelId { get; set; }
        public int Quantity { get; set; }
        public decimal price { get; set; }
    }
}