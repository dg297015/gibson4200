﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using gibson4200.DAL;
using gibson4200.Models;

namespace gibson4200.Controllers
{
    public class AppointmentDetailsController : Controller
    {
        private MedicalContext db = new MedicalContext();

        // GET: AppointmentDetails
        public ActionResult Index()
        {
            var appointmentDetails = db.AppointmentDetails.Include(a => a.Appointment).Include(a => a.Patient);
            return View(appointmentDetails.ToList());
        }

        // GET: AppointmentDetails/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentDetail appointmentDetail = db.AppointmentDetails.Find(id);
            if (appointmentDetail == null)
            {
                return HttpNotFound();
            }
            return View(appointmentDetail);
        }

        // GET: AppointmentDetails/Create
        public ActionResult Create()
        {
            ViewBag.appointmentID = new SelectList(db.Appointments, "appointmentID", "description");
            ViewBag.patientID = new SelectList(db.Patients, "patientID", "description");
            return View();
        }

        // POST: AppointmentDetails/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "appointmentDetailID,prescriptionQuantityOrdered,price,appointmentID,patientID")] AppointmentDetail appointmentDetail)
        {
            if (ModelState.IsValid)
            {
                db.AppointmentDetails.Add(appointmentDetail);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.appointmentID = new SelectList(db.Appointments, "appointmentID", "description", appointmentDetail.appointmentID);
            ViewBag.patientID = new SelectList(db.Patients, "patientID", "description", appointmentDetail.patientID);
            return View(appointmentDetail);
        }

        // GET: AppointmentDetails/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentDetail appointmentDetail = db.AppointmentDetails.Find(id);
            if (appointmentDetail == null)
            {
                return HttpNotFound();
            }
            ViewBag.appointmentID = new SelectList(db.Appointments, "appointmentID", "description", appointmentDetail.appointmentID);
            ViewBag.patientID = new SelectList(db.Patients, "patientID", "description", appointmentDetail.patientID);
            return View(appointmentDetail);
        }

        // POST: AppointmentDetails/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "appointmentDetailID,prescriptionQuantityOrdered,price,appointmentID,patientID")] AppointmentDetail appointmentDetail)
        {
            if (ModelState.IsValid)
            {
                db.Entry(appointmentDetail).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.appointmentID = new SelectList(db.Appointments, "appointmentID", "description", appointmentDetail.appointmentID);
            ViewBag.patientID = new SelectList(db.Patients, "patientID", "description", appointmentDetail.patientID);
            return View(appointmentDetail);
        }

        // GET: AppointmentDetails/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AppointmentDetail appointmentDetail = db.AppointmentDetails.Find(id);
            if (appointmentDetail == null)
            {
                return HttpNotFound();
            }
            return View(appointmentDetail);
        }

        // POST: AppointmentDetails/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            AppointmentDetail appointmentDetail = db.AppointmentDetails.Find(id);
            db.AppointmentDetails.Remove(appointmentDetail);
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
