using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AGCS.Models;

namespace AGCS.Controllers
{
    public class BackendController : Controller
    {
        public int IdBE;
        // GET: Backend
        public ActionResult Index()
        {
            return View();
        }

        // GET: Backend/Details/5
        public ActionResult ABMClientes()
        {   
            BD.BringClients();
            ViewBag.Clients = BD.ListOfClients;
            return View();
        }

        // GET: Backend/Create
        public ActionResult Pruebas()
        {
            return View();
        }

        // POST: Backend/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Backend/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Backend/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Backend/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Backend/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}