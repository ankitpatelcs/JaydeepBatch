using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Modalpopup.EDM;

namespace Modalpopup.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities _entity = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View(_entity.tblemployees.ToList());
        }

        public ActionResult Create(int? id)
        {
            if (id==null || id==0)
            {
                return View();
            }
            else
            {
                return View(_entity.tblemployees.Find(id));
            }
        }
        [HttpPost]
        public ActionResult Create(tblemployee obj)
        {
            _entity.tblemployees.Add(obj);
            _entity.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}