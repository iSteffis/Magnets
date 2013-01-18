using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Magnets.Models;
using Magnets.DAL;

namespace Magnets.Controllers
{
    public class CommunityController : Controller
    {
        private MagnetsContext db = new MagnetsContext();

        //
        // GET: /Community/

        public ActionResult Index()
        {
            return View(db.Communities.ToList());
        }

        //
        // GET: /Community/Details/5

        public ActionResult Details(int id = 0)
        {
            Community community = db.Communities.Find(id);
            if (community == null)
            {
                return HttpNotFound();
            }
            return View(community);
        }

        //
        // GET: /Community/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Community/Create

        [HttpPost]
        public ActionResult Create(Community community)
        {
            if (ModelState.IsValid)
            {
                db.Communities.Add(community);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(community);
        }

        //
        // GET: /Community/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Community community = db.Communities.Find(id);
            if (community == null)
            {
                return HttpNotFound();
            }
            return View(community);
        }

        //
        // POST: /Community/Edit/5

        [HttpPost]
        public ActionResult Edit(Community community)
        {
            if (ModelState.IsValid)
            {
                db.Entry(community).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(community);
        }

        //
        // GET: /Community/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Community community = db.Communities.Find(id);
            if (community == null)
            {
                return HttpNotFound();
            }
            return View(community);
        }

        //
        // POST: /Community/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            Community community = db.Communities.Find(id);
            db.Communities.Remove(community);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}