using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FundAppsCourierKata.Models
{
    public class Parcel
    {
               public int ParcelId { get; set; }
        public string  ParcelSize { get; set; }
        public string Dimension { get; set; }
        public decimal deliveryCost { get; set; }
    }
}