using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ListControl.Extension.Example.Models
{
    public class Employee
    {
        public string Name { get; set; }

        public List<int> Departments { get; set; }

        public List<SelectListItem> AllDepartmemtns
        {
            get
            {
                List<SelectListItem> items = new List<SelectListItem>();
                items.Add(new SelectListItem() { Value = "1", Text = "HR" });
                items.Add(new SelectListItem() { Value = "2", Text = "Develop" });
                return items;
            }
        }

        public int Gender { get; set; }

        public List<SelectListItem> GenderCollection
        {
            get
            {
                List<SelectListItem> items = new List<SelectListItem>();
                items.Add(new SelectListItem() { Value = "1", Text = "Male" });
                items.Add(new SelectListItem() { Value = "2", Text = "Female" });
                return items;
            }
        }
    }
}