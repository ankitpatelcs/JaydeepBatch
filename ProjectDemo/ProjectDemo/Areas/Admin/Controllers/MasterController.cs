using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectDemo.EDM;

namespace ProjectDemo.Areas.Admin.Controllers
{
    public class MasterController : Controller
    {
        ecommerceEntities dc = new ecommerceEntities();
        // GET: Admin/Master
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string email = fc["email"];
            string pass = fc["password"];

            var obj = dc.tblAdmins.Where(x => x.email == email && x.password == pass).FirstOrDefault();
            if (obj!=null)
            {
                Session["AdminId"] = obj.Admin_id;
                Session["AdminName"] = obj.f_name;

                return RedirectToAction("Dashboard");
            }
            ViewBag.loginerror = "Invalid Email Or Password";
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("Login");
        }
        public ActionResult Dashboard()
        {
            return View();
        }
    }
}