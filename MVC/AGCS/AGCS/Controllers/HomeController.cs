﻿using System;
using System.Collections.Generic;using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AGCS.Models;

namespace AGCS.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            BD.Conect();
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        
    }
}
