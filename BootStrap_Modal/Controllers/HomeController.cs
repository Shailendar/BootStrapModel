using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using BootStrap_Modal.Models;

namespace BootStrap_Modal.Controllers
{
    public class HomeController : Controller
    {
        Context db = new Context();

        public ActionResult Index()
        {
            ViewModel vm = new ViewModel();
            vm.Modal = db.Modal.ToList();
            return View(vm);
        }

        public ActionResult Create()
        {
            Modal modal = new Modal();
            return View(modal);
        }
        [HttpPost]
        public ActionResult Create(Modal modal)
        {
            db.Modal.Add(modal);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult Edit(int Id)
        {
            Modal modal = db.Modal.Find(Id);
            return View(modal);
        }
        [HttpPost]
        public ActionResult Edit(Modal modal)
        {
            db.Entry(modal).State = EntityState.Modified;
            db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}