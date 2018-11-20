using ProjetoModeloDDD.MVC.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoModeloDDD.MVC.Controllers
{
    public class PlanoController : Controller
    {
        // GET: Plano
        public ActionResult Index()
        {
            return View();
        }

        // GET: Plano/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Plano/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Plano/Create
        [HttpPost]
        public ActionResult Create(PlanoViewModel plano)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Plano/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Plano/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
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

        // GET: Plano/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Plano/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
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
