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
        public ActionResult Single(int id)
        {
            return View(dc.tblproducts.Find(id));
        }

        public string AddToCart(int id)
        {
            int userid = Convert.ToInt32(Session["UserId"].ToString());

            var cartobj = dc.tblcarts.Where(c => c.product_id == id && c.user_id == userid).FirstOrDefault();
            if (cartobj == null)
            {
                tblcart obj = new tblcart();
                obj.product_id = id;
                obj.qty = 1;
                obj.user_id = userid;

                dc.tblcarts.Add(obj);
                dc.SaveChanges();
            }
            else
            {
                cartobj.qty += 1;
                dc.Entry(cartobj).State = System.Data.Entity.EntityState.Modified;
                dc.SaveChanges();
            }

            return "Product added to cart.";
        }

        public ActionResult Cart()
        {
            int userid = Convert.ToInt32(Session["UserId"].ToString());
            return View(dc.tblcarts.Where(c=>c.user_id==userid).ToList());
        }
        public ActionResult Delete(int id)
        {
            dc.tblcarts.Remove(dc.tblcarts.Find(id));
            dc.SaveChanges();
            return RedirectToAction("Cart");
        }

        [HttpPost]
        public string UpdateCartQty(int id, int qty)
        {
            var obj = dc.tblcarts.Find(id);
            obj.qty = qty;

            dc.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            dc.SaveChanges();
            return "Cart Qty updated.";
        }
    }
}