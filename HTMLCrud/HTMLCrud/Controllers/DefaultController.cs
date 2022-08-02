﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HTMLCrud.EDM;

namespace HTMLCrud.Controllers
{
    public class DefaultController : Controller
    {
        CompanyEntities dc = new CompanyEntities();

        // GET: Default
        public ActionResult Index()
        {
            var empdata = from n in dc.tblemployees
                          select n;
            ViewBag.data = empdata.ToList();
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(FormCollection fc)
        {
            tblemployee obj = new tblemployee();
            obj.f_name = fc["txtfn"];
            obj.salary = Convert.ToInt32(fc["txtsal"]);
            obj.mobile = fc["txtmb"];
            obj.email = fc["txtem"];
            obj.gender = fc["txtgn"];

            dc.tblemployees.Add(obj);
            dc.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult Edit(int id)
        {
            var empdata = from n in dc.tblemployees
                          where n.emp_id == id
                          select n;
            ViewBag.data = empdata.FirstOrDefault();
            return View();
        }
        [HttpPost]
        public ActionResult Edit(FormCollection fc)
        {
            tblemployee obj = new tblemployee();
            obj.f_name = fc["txtfn"];
            obj.emp_id = Convert.ToInt32(fc["txtid"]);
            obj.salary = Convert.ToInt32(fc["txtsal"]);
            obj.mobile = fc["txtmb"];
            obj.email = fc["txtem"];
            obj.gender = fc["txtgn"];

            dc.Entry(obj).State = System.Data.Entity.EntityState.Modified;
            dc.SaveChanges();

            return RedirectToAction("Index");
        }

        public ActionResult Delete(int id)
        {
            var empdata = from n in dc.tblemployees
                          where n.emp_id == id
                          select n;
            ViewBag.data = empdata.FirstOrDefault();
            return View();
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteRec(int id)
        {
            dc.tblemployees.Remove(dc.tblemployees.Find(id));
            dc.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}