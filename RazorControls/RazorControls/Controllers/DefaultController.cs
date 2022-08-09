using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RazorControls.EDM;

namespace RazorControls.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities dc = new CompanyEntities();
        // GET: Default
        public ActionResult Index()
        {
            return View();
        }

        void FillStates()
        {
            //var data = dc.tblstates.ToList();
            //List<SelectListItem> li = new List<SelectListItem>();
            //foreach (var item in data)
            //{
            //    li.Add(new SelectListItem { Text = item.state_name, Value = item.state_id.ToString() });
            //}
            //ViewBag.states = li;

            var data = from s in dc.tblstates
                       select new SelectListItem
                       {
                           Text = s.state_name,
                           Value=s.state_id.ToString()
                       };

            ViewBag.states = data.ToList();
        }
        public ActionResult Create()
        {
            FillStates();
            return View();
        }
        [HttpPost]
        public ActionResult Create(tblemployee obj)
        {

            dc.tblemployees.Add(obj);
            dc.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}