using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using TrashCanProject.Models;

namespace TrashCanProject.Controllers
{
    public class HomeController : Controller
    {
        ApplicationDbContext context;
        public HomeController()
        {
            context = new ApplicationDbContext();
        }
        public ActionResult Index()
        {
            var CurrentUser = User.Identity.GetUserId();

            if (User.IsInRole("Employee"))
            {
                var employeeFound = context.employees.Where(e => e.ApplicationUserId == CurrentUser).SingleOrDefault();
                return RedirectToAction("TrashCanSchedules", "Employee", new { id = employeeFound.EmployeeId});
            }
            else if (User.IsInRole("Customer"))
            {
                var customerFound = context.customers.Where(e => e.ApplicationUserId == CurrentUser).SingleOrDefault();     
                return RedirectToAction("CustomerTrashCanSchedule", "Customer", new { id = customerFound.CustomerId });
            }

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}