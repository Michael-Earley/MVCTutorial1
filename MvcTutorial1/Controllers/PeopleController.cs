using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Acme.Intranet.Models;

namespace Acme.Intranet.Controllers
{
    public class PeopleController : Controller
    {
        //
        // GET: /People/

        public ActionResult Index()
        {
            return View();
        }

        //
        // GET: /People/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /People/Create

        public ActionResult Create()
        {
            ViewBag.Title = "New Person";
            return View();
        } 

        //
        // POST: /People/Create

        [HttpPost]
        public ActionResult Create(Person person)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Create");
            }
            catch
            {
                return View();
            }
        }
        
        //
        // GET: /People/Edit/5
 
        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /People/Edit/5

        [HttpPost]
        public ActionResult Edit(int id, Person person)
        {
            try
            {
                // TODO: Add update logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /People/Delete/5
 
        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /People/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, Person person)
        {
            try
            {
                // TODO: Add delete logic here
 
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
