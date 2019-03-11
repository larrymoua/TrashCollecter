using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TrashCanProject.Models;
using Microsoft.AspNet.Identity;

namespace TrashCanProject.Controllers
{
    public class EmployeeController : Controller
    {
        ApplicationDbContext context;
        public EmployeeController()
        {
            context = new ApplicationDbContext();
        } 
        // GET: Employee
        public ActionResult TrashCanSchedules(string id)
        {
            var CurrentUser = User.Identity.GetUserId();
            var employeeFound = context.employees.Where(e => e.ApplicationUserId == CurrentUser).SingleOrDefault();
            var typeList = Enum.GetValues(typeof(PickUpDays))
                .Cast<PickUpDays>()
                .Select(t => new AcessClass
                {
                    pickUpDays = ((PickUpDays)t),

                });
            ViewBag.ListData = typeList;

            return View(context.trashCanSchedules.Where(t => t.ZipCode == employeeFound.ZipCode));
        }
        public ActionResult Filter(string id)
        {
            string dayofweek = System.DateTime.Now.DayOfWeek.ToString();

            var CurrentUser = User.Identity.GetUserId();
            var employeeFound = context.employees.Where(e => e.ApplicationUserId == CurrentUser).SingleOrDefault();
            var schedules = context.trashCanSchedules.Where(t => t.ZipCode == employeeFound.ZipCode);
            var filteredSchedules = context.trashCanSchedules.Where(t => t.pickUpDays.ToString() == id && t.ZipCode == employeeFound.ZipCode).ToList();

            return View(filteredSchedules);
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var schedule = context.trashCanSchedules.Find(id);
            var customerFound = context.customers.Where(e => e.CustomerId == schedule.CustomerId).SingleOrDefault();
    
                //var address = "Stavanger, Norway";

                //var locationService = new GoogleLocationService();
                //var point = locationService.GetLatLongFromAddress(address);

                //var latitude = point.Latitude;
                //var longitude = point.Longitude;

                // Save lat/long values to DB...

            return View(customerFound);
        }

        // GET: Employee/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Employee/Create
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

        // GET: Employee/Edit/5
        public ActionResult Edit(int id)
        {
            var schedule = context.trashCanSchedules.Find(id);
            return View(schedule);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, TrashCanSchedule trashCanSchedule)
        {
            //var updateEmployee = context.employees.Where(e => e.EmployeeId == employee.EmployeeId).FirstOrDefault();
            //updateEmployee.FirstName = employee.FirstName;
            //updateEmployee.LastName = employee.LastName;
            //updateEmployee.Address = employee.Address;
            //updateEmployee.ZipCode = employee.ZipCode;
            //context.SaveChanges();
            try
            {
                var updateTrashCanScheduel = context.trashCanSchedules.Where(t => t.ID == id).FirstOrDefault();
                updateTrashCanScheduel.Confirmed = trashCanSchedule.Confirmed;
                updateTrashCanScheduel.Cost = trashCanSchedule.Cost;
                context.SaveChanges();
                return RedirectToAction("TrashCanSchedules");
            }
            catch
            {
                return View();
            }
        }

        // GET: Employee/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Employee/Delete/5
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
