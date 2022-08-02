using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Statemanagement.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(FormCollection fc)
        {
            string username = fc["txtuname"];
            string password = fc["txtpass"];
            if (username=="shankar" && password=="s123")
            {
                HttpCookie couname = new HttpCookie("uname");
                couname.Value = username;
                couname.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Add(couname);

                HttpCookie copass = new HttpCookie("pass");
                copass.Value = password;
                copass.Expires = DateTime.Now.AddDays(2);
                Response.Cookies.Add(copass);
            }
            return View();
        }

        public ActionResult Qstring(int id,string name)
        {
            ViewBag.msg = $"ID: {id}, Name: {name}";
            return View();
        }
    }
}