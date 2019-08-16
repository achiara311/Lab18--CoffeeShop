using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab18CoffeeShop.Models;

namespace Lab18CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View(new RegisterUser()); 
        }

        [HttpGet]
        public IActionResult Registration()
        {
            return View(new RegisterUser());
        }
        
        [HttpPost]
        public IActionResult Registration(RegisterUser heyThere)
        {
            return RedirectToAction("Summary", heyThere);
        }

        public IActionResult Summary(RegisterUser heyThere)
        {
            return View(heyThere);
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
