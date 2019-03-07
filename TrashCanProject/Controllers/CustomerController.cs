﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCanProject.Models;
using Microsoft.AspNet.Identity;

namespace TrashCanProject.Controllers
{
    public class CustomerController : Controller
    {
        private ApplicationDbContext context;
        // GET: Customer
        public CustomerController()
        {
            context = new ApplicationDbContext();
        }
        public ActionResult CustomerTrashCanSchedule(int id)
        {
            var customersPickUpSchedule = context.trashCanSchedules.Where(s => s.CustomerId == id).ToList();
            return View(customersPickUpSchedule);
        }

        // GET: Customer/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Customer/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Customer/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Customer/Edit/5
        public ActionResult Edit(int id)
        {
            var schedule = context.trashCanSchedules.Find(id);
            return View(schedule);
        }

        // POST: Customer/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TrashCanSchedule trashCanSchedule)
        {
  
                var updateTrashCanScheduel = context.trashCanSchedules.Where(t => t.ID == id).FirstOrDefault();
                 //u.UserTypeOptions = new SelectList(
                 //new List<SelectListItem>
                 //{
                 //   new SelectListItem { Text = "Homeowner", Value = ((int)UserType.Homeowner).ToString()},
                 //   new SelectListItem { Text = "Contractor", Value = ((int)UserType.Contractor).ToString()},
                 //}, "Value", "Text");
                updateTrashCanScheduel.pickUpDays = trashCanSchedule.pickUpDays;
                updateTrashCanScheduel.ExtraPickupDate = trashCanSchedule.ExtraPickupDate;
                updateTrashCanScheduel.ZipCode = trashCanSchedule.ZipCode;
                context.SaveChanges();

                return RedirectToAction("CustomerTrashCanSchedule", new { id = updateTrashCanScheduel.CustomerId});

        }

        // GET: Customer/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Customer/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
