using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCFirstProject.Models;

namespace MVCFirstProject.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult EmployeeInfo()
        {
            Employee employee = new Employee()
            {
                EmployeeId = 215016,
                EmployeeName = "saikumar",
                EmployeeLocation = "Bangalore"
            };
            return View(employee);
        }
    }
}
