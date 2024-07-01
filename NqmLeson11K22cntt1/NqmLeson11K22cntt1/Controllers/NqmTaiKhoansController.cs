using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NqmLeson11K22cntt1.Models;
using NqmLeson11K22cntt1.ModelViews;


namespace NqmLeson11K22cntt1.Controllers
{
    public class NqmTaiKhoansController : Controller
    {
        private Nqmlesson11DbEntities db = new Nqmlesson11DbEntities();

        // GET: NqmTaiKhoans
        public ActionResult Index()
        {
            return View(db.NqmTaiKhoan.ToList());
        }

        // GET: NqmTaiKhoans/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NqmTaiKhoan nqmTaiKhoan = db.NqmTaiKhoan.Find(id);
            if (nqmTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(nqmTaiKhoan);
        }

        // GET: NqmTaiKhoans/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NqmTaiKhoans/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NqmId,NqmUseName,NqmPassword,NqmFullName,NqmAge,NqmEmail,NqmPhone,NqmStatus")] NqmTaiKhoan nqmTaiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.NqmTaiKhoan.Add(nqmTaiKhoan);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(nqmTaiKhoan);
        }

        // GET: NqmTaiKhoans/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NqmTaiKhoan nqmTaiKhoan = db.NqmTaiKhoan.Find(id);
            if (nqmTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(nqmTaiKhoan);
        }

        // POST: NqmTaiKhoans/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NqmId,NqmUseName,NqmPassword,NqmFullName,NqmAge,NqmEmail,NqmPhone,NqmStatus")] NqmTaiKhoan nqmTaiKhoan)
        {
            if (ModelState.IsValid)
            {
                db.Entry(nqmTaiKhoan).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(nqmTaiKhoan);
        }

        // GET: NqmTaiKhoans/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NqmTaiKhoan nqmTaiKhoan = db.NqmTaiKhoan.Find(id);
            if (nqmTaiKhoan == null)
            {
                return HttpNotFound();
            }
            return View(nqmTaiKhoan);
        }

        // POST: NqmTaiKhoans/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NqmTaiKhoan nqmTaiKhoan = db.NqmTaiKhoan.Find(id);
            db.NqmTaiKhoan.Remove(nqmTaiKhoan);
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
