using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using View_Flow.Models;

namespace View_Flow.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetEmployee();
            return View(data);
        }
       
        private Employee GetEmployee()
        {
            return new Employee()
            {
                id = 1,
                name = "Vaari",
                designation = "Software Developer"
            };
        }
        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact(string name)
        {
            return View();
        }


    }
}