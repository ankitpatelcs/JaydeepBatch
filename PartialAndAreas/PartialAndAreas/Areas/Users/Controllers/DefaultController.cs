using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PartialAndAreas.Areas.Users.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Users/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}