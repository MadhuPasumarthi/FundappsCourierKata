using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FundAppsCourierKata.Models
{
    public class Order
    {
        public int Orderid { get; set; }
        public List<OrderlineItem> orderlineItems { get; set; }
        public bool speedyShipment { get; set; }

        public decimal cost { get; set; }
    }
}