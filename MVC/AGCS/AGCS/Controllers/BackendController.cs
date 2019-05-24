using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Threading;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using AGCS.Models;
using Newtonsoft.Json;

namespace AGCS.Controllers
{
    public class BackendController : Controller
    {
       
        // GET: Backend
        public ActionResult Index()
        {
            return View();
        }

        
        public ActionResult ABMClientes()
        {
            BD.BringClients();
            ViewBag.Clients = BD.ListOfClients;
            return View();
        }
        
        [HttpPost]
        public JsonResult GetDataClient(int id)
        {
            BD.BringOneClient(id);
            string JsonDataClient = JsonConvert.SerializeObject(BD.OneClient);
            return Json(JsonDataClient);            
        }
        [HttpPost]
        public bool UpdateClient(string Surname, string Name, int dni, string email, int Telephone, int Cellphone, string Town, string Address, string Province, string Leter, int Number, int Floor)
        {
            bool Succes = true;
            
            Client cUpdateClient = new Client(BD.OneClient.Id, Name, Surname,dni,email,Telephone,Cellphone, Town,Address,Province,Leter,Number,Floor);
            try
            {

                
            }
            catch
            {
                Succes = false;
            }
            
            return Succes;
        }

        // GET: Backend/Create
        public ActionResult Pruebas()
        {
            return View();
        }
        void UpdateClient(Client Updateclient)
        {

        }
    

      

        
    }
}