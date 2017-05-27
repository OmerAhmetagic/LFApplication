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
    public class HomeController : Controller
    {
        private ItemDBContext db = new ItemDBContext();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult IndexZ()
        {
            return View();
        }

        public ActionResult AboutZ()
        {
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult ContactZ()
        {
            return View();
        }
    }
}