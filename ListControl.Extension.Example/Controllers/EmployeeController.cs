using ListControl.Extension.Example.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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

        // GET: Employee/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Employee employee = new Employee()
            {
                Name = "Temp",
                Departments = new List<int> { 1, 2 },
                Gender = 1
            };
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        // POST: Employee/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Name,Departments,Gender")] 
            Employee employee)
        {
            if (ModelState.IsValid)
            {
                //db.Entry(employee).State = EntityState.Modified;
                //db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }
    }
}