using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Magnets.Models;

namespace Magnets.Controllers
{
    public class CommunityController : Controller
    {
        private MagnetsContext db = new MagnetsContext();

        //
        // GET: /Community/

        public ActionResult Index()
        {
            return View(db.Houses.ToList());
        }

        //
        // GET: /Community/Details/5

        public ActionResult Details(int id = 0)
        {
            House community = db.Houses.Find(id);
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
        public ActionResult Create(House community)
        {
            if (ModelState.IsValid)
            {
                db.Houses.Add(community);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(community);
        }

        //
        // GET: /Community/Edit/5

        public ActionResult Edit(int id = 0)
        {
            House community = db.Houses.Find(id);
            if (community == null)
            {
                return HttpNotFound();
            }
            return View(community);
        }

        //
        // POST: /Community/Edit/5

        [HttpPost]
        public ActionResult Edit(House community)
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
            House community = db.Houses.Find(id);
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
            House community = db.Houses.Find(id);
            db.Houses.Remove(community);
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