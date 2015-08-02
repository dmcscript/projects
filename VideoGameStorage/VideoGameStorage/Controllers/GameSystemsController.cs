using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using VideoGameStorage.Models;

namespace VideoGameStorage.Controllers
{
    public class GameSystemsController : Controller
    {
        private GameSystemContext db = new GameSystemContext();

        // GET: GameSystems
        public ActionResult Index()
        {
            return View(db.Systems.ToList());
        }

        // GET: GameSystems/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameSystem gameSystem = db.Systems.Find(id);
            if (gameSystem == null)
            {
                return HttpNotFound();
            }
            return View(gameSystem);
        }

        // GET: GameSystems/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: GameSystems/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "SystemID,Name,Num_Games")] GameSystem gameSystem)
        {
            if (ModelState.IsValid)
            {
                db.Systems.Add(gameSystem);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(gameSystem);
        }

        // GET: GameSystems/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameSystem gameSystem = db.Systems.Find(id);
            if (gameSystem == null)
            {
                return HttpNotFound();
            }
            return View(gameSystem);
        }

        // POST: GameSystems/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "SystemID,Name,Num_Games")] GameSystem gameSystem)
        {
            if (ModelState.IsValid)
            {
                db.Entry(gameSystem).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(gameSystem);
        }

        // GET: GameSystems/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GameSystem gameSystem = db.Systems.Find(id);
            if (gameSystem == null)
            {
                return HttpNotFound();
            }
            return View(gameSystem);
        }

        // POST: GameSystems/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GameSystem gameSystem = db.Systems.Find(id);
            db.Systems.Remove(gameSystem);
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
