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

        [HttpPost]
        // El Json recibido será serializado automáticamupente al objeto nuevo cocche teniendo en cuenta que las propiedades han de tener el mismo nombre
        public JsonResult GetDataClient(int id)
        {
            string nombre = BD.ListOfClients[id].Name;
            return Json("{'Success':'true'}");            
        }

        // GET: Backend/Create
        public ActionResult Pruebas()
        {
            BD.GetClients(BD.idBusiness);
            ViewBag.Clients = BD.ListOfClients;
            ViewBag.ClientInfo = BD.GetOneClient(8, 1);
            //FUNCA ---> BD.InsertClient(new Client(-1, "pepe", "Gonzalez", 4444, "xd@xddd", 1234455555));
            //FUNCA ---> BD.DeleteClient(9);
            BD.UpdateClient(new Client(8, "Greato   ", "Daze", 1111, "Qtaro@Qstar", 1234455555));
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