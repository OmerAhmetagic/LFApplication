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
    public class ItemsController : Controller
    {
        private ItemDBContext db = new ItemDBContext();

        // GET: Items
        //public ActionResult Index()
        //{
        //    return View(db.Items.ToList());
        //}

        //public ActionResult Index(string searchString)
        //{
        //    var movies = from m in db.Items
        //                 select m;

        //    if (!String.IsNullOrEmpty(searchString))
        //    {
        //        movies = movies.Where(s => s.Name.Contains(searchString));
        //    }

        //    return View(movies);
        //}

        public ActionResult Index(string itemType, string searchString)
        {
            var GenreLst = new List<string>();

            var GenreQry = from d in db.Items
                           orderby d.Tag
                           select d.Tag;

            GenreLst.AddRange(GenreQry.Distinct());
            ViewBag.itemType = new SelectList(GenreLst);

            var items = from m in db.Items
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

            var GenreQry = from d in db.Items
                           orderby d.Tag
                           select d.Tag;

            GenreLst.AddRange(GenreQry.Distinct());
            ViewBag.itemType = new SelectList(GenreLst);

            var items = from m in db.Items
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

        // GET: Items/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // GET: Items/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Items/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Location,Tag,Image,Comment,PersonName,Email,Phone")] Item item, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                if (upload != null && upload.ContentLength > 0)
                {
                    //display the picture
                    //var avatar = new File
                    //{
                    //    FileName = System.IO.Path.GetFileName(upload.FileName),
                    //    FileType = FileType.Avatar,
                    //    ContentType = upload.ContentType
                    //};
                    //using (var reader = new System.IO.BinaryReader(upload.InputStream))
                    //{
                    //    avatar.Content = reader.ReadBytes(upload.ContentLength);
                    //}
                    //student.Files = new List<File> { avatar };
                }
                db.Items.Add(item);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(item);
        }

        // GET: Items/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Items/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Location,Tag,Image,Comment,PersonName,Email,Phone")] Item item)
        {
            if (ModelState.IsValid)
            {
                db.Entry(item).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(item);
        }

        // GET: Items/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Item item = db.Items.Find(id);
            if (item == null)
            {
                return HttpNotFound();
            }
            return View(item);
        }

        // POST: Items/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Item item = db.Items.Find(id);
            db.Items.Remove(item);
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
