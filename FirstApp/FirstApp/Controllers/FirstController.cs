using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using FirstApp.Models;

namespace FirstApp.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Empdata()
        {
            List<Employee> li = new List<Employee>();

            li.Add(new Employee { empid=1,fname="Jaydeep",email="j@gmail.com" });
            li.Add(new Employee { empid=2,fname="Akshay",email="ak@gmail.com" });
            li.Add(new Employee { empid=3,fname="Rakesh",email="rk@gmail.com" });
            li.Add(new Employee { empid=4,fname="Shankar",email="s@gmail.com" });

            return View(li);
        }
    }
}