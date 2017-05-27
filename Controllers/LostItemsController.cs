using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LFApplication.Models;

namespace LFApplication.Controllers
{
    public class LostItemsController : Controller
    {
        private ItemDBContext db = new ItemDBContext();

        // GET: LostItems
        public ActionResult Index(string itemType, string searchString)
        {
            var GenreLst = new List<string>();

            var GenreQry = from d in db.LostItems
                           orderby d.Tag
                           select d.Tag;

            GenreLst.AddRange(GenreQry.Distinct());
            ViewBag.itemType = new SelectList(GenreLst);

            var items = from m in db.LostItems
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(s => s.Name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(itemType))
            {
                items = items.Where(x => x.Tag == itemType);
            }

            return View(items);
        }

        public ActionResult IndexZ(string itemType, string searchString)
        {
            var GenreLst = new List<string>();

            var GenreQry = from d in db.LostItems
                           orderby d.Tag
                           select d.Tag;

            GenreLst.AddRange(GenreQry.Distinct());
            ViewBag.itemType = new SelectList(GenreLst);

            var items = from m in db.LostItems
                        select m;

            if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(s => s.Name.Contains(searchString));
            }

            if (!string.IsNullOrEmpty(itemType))
            {
                items = items.Where(x => x.Tag == itemType);
            }

            return View(items);
        }

        // GET: LostItems/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LostItem lostItem = db.LostItems.Find(id);
            if (lostItem == null)
            {
                return HttpNotFound();
            }
            return View(lostItem);
        }

        // GET: LostItems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: LostItems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Location,Tag,Image,Comment,PersonName,Email,Phone")] LostItem lostItem)
        {
            if (ModelState.IsValid)
            {
                db.LostItems.Add(lostItem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(lostItem);
        }

        // GET: LostItems/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LostItem lostItem = db.LostItems.Find(id);
            if (lostItem == null)
            {
                return HttpNotFound();
            }
            return View(lostItem);
        }

        // POST: LostItems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Location,Tag,Image,Comment,PersonName,Email,Phone")] LostItem lostItem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(lostItem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(lostItem);
        }

        // GET: LostItems/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            LostItem lostItem = db.LostItems.Find(id);
            if (lostItem == null)
            {
                return HttpNotFound();
            }
            return View(lostItem);
        }

        // POST: LostItems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            LostItem lostItem = db.LostItems.Find(id);
            db.LostItems.Remove(lostItem);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
