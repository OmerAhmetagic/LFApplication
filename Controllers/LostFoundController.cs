using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data;
using System.Data.Entity;
using LFApplication.Models;
namespace LFApplication.Controllers
{
    public class LostFoundController : Controller
    {
        private ItemDBContext db = new ItemDBContext();

        // GET: LostFound
        public ActionResult Index()
        {
            //var results = db.Items.ToList();
            //var res = results.OrderByDescending(x => x.DateCreated).Take(3);

            //return View(res);
            return View();
        }

        public ActionResult ILostItems()
        {
            return View();
        }

        public ActionResult IFoundItems()
        {
            return View();
        }

        public ActionResult LostItems()
        {
            return View();
        }

        public ActionResult FoundItems()
        {
            return View();
        }
    }
}