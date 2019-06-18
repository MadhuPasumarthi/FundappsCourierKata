using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FundAppsCourierKata.Models;


namespace FundAppsCourierKata.Controllers
{
    public class OrderController : Controller
    {
        private FundAppsCourierKataContext db = new FundAppsCourierKataContext();
        // GET: Order
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Create()
        {
            ViewBag.Parcel = db.Parcels.ToList();
            return View();
        }

    }
}