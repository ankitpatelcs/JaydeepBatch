using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxCrud.EDM;

namespace AjaxCrud.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities dc = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        public JsonResult GetEmployees()
        {
            dc.Configuration.ProxyCreationEnabled = false;
            return Json(dc.tblemployees.ToList(), JsonRequestBehavior.AllowGet);
        }

        void FillState()
        {
            var data = from s in dc.tblstates
                       select new SelectListItem
                       {
                           Text = s.state_name,
                           Value = s.state_id.ToString()
                       };

            ViewBag.states = data.ToList();
        }

        public JsonResult GetCitiesByStateId(int id)
        {
            dc.Configuration.ProxyCreationEnabled = false;
            return Json(dc.tblcities.Where(x => x.state_id == id).ToList(),JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            FillState();
            return View();
        }
        [HttpPost]
        public string Create(tblemployee obj)
        {
            dc.tblemployees.Add(obj);
            dc.SaveChanges();
            return "Record Inserted.";
        }

        public ActionResult Edit(int id)
        {
            return View(dc.tblemployees.Find(id));
        }
        [HttpPost]
        public string Edit(tblemployee obj)
        {
            dc.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            dc.SaveChanges();
            return "Record Updated.";
        }

        public ActionResult Delete(int id)
        {
            return View(dc.tblemployees.Find(id));
        }
        [HttpPost]
        [ActionName("Delete")]
        public string DeleteRec(int id)
        {
            dc.tblemployees.Remove(dc.tblemployees.Find(id));
            dc.SaveChanges();
            return "Record Deleted.";
        }
    }
}