using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using FundAppsCourierKata.Models;

namespace FundAppsCourierKata.Controllers
{
    public class CostController : ApiController
    {
        // GET: api/Cost
        private FundAppsCourierKataContext db = new FundAppsCourierKataContext();
        public List<Parcel> Get()
        {
            return db.Parcels.ToList<Parcel>();
        }

        // GET: api/Cost/5
        public string Get(int id)
        {
            return "value";
        }

        public List<Parcel> Get(string Size)
        {
            var _parcel = from m in db.Parcels
                         where m.ParcelSize== Size
                         select m;


           
            return _parcel.ToList<Parcel>();
        }

        // POST: api/Cost
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/Cost/5
        public void Put(int id, [FromBody]string value)
        {

        }

    
    // DELETE: api/Cost/5
    public void Delete(int id)
        {
        }
    }
}
