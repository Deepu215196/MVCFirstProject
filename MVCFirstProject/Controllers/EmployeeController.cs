using MVCFirstProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeInfo()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 1001,
                EmployeeName = "Deepu Mohan",
                EmployeeLocation = "Chennai"
            };
            return View(employee);
        }
    }
}