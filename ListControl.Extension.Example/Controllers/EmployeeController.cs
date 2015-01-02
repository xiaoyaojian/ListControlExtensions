using ListControl.Extension.Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListControl.Extension.Example.Controllers
{
    public class EmployeeController : Controller
    {
        public ActionResult Create()
        {
            return View(new Employee());
        }

        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}