using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FundAppsCourierKata.Models
{
    public class OrderlineItem
    {
        public int ItemId { get; set; }
        public Parcel parcel { get; set; }
        public int  quantity { get; set; }
        public decimal LineItemCost { get; set; }
    }
}