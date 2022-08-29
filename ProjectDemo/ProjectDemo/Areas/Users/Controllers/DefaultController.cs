using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ProjectDemo.EDM;

namespace ProjectDemo.Areas.Users.Controllers
{
    public class DefaultController : Controller
    {
        ecommerceEntities dc = new ecommerceEntities();
        // GET: Users/Default
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(FormCollection fc)
        {
            string email = fc["email"];
            string pass = fc["password"];

            var obj = dc.tblUsers.Where(x => x.email == email && x.password == pass).FirstOrDefault();
            if (obj != null)
            {
                Session["UserId"] = obj.user_id;
                Session["UserName"] = obj.f_name;

                return RedirectToAction("HomePage");
            }
            ViewBag.loginerror = "Invalid Email Or Password";
            return View();
        }
        public ActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Register(FormCollection fc)
        {
            return View();
        }
        public ActionResult Logout()
        {
            Session.Abandon();
            return RedirectToAction("HomePage");
        }
        public ActionResult HomePage()
        {
            return View();
        }
        public ActionResult Products()
        {
            return View(dc.tblproducts.ToList());
        }
    }
}