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
        public ActionResult TrashCanSchedules()
        {
            return View(context.trashCanSchedules.Select(t => t));
        }

        // GET: Employee/Details/5
        public ActionResult Details(int id)
        {
            var CurrentUser = User.Identity;
          

            return View();
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
            Employee findEmployee = context.employees.Where(e => e.EmployeeId == id).SingleOrDefault();
            return View(findEmployee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
          
            try
            {
                var updateEmployee = context.employees.Where(e => e.EmployeeId == employee.EmployeeId).FirstOrDefault();
                updateEmployee.FirstName = employee.FirstName;
                updateEmployee.LastName = employee.LastName;
                updateEmployee.Address = employee.Address;
                updateEmployee.ZipCode = employee.Address;
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
