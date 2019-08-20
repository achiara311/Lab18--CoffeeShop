using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab18CoffeeShop.Models;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Http;

namespace Lab18CoffeeShop.Controllers
{
    public class HomeController : Controller
    {
        List<RegisterUser> registerstuff = new List<RegisterUser>();
       
        
        public IActionResult Home()
        {
            return View(registerstuff);
        }

        public IActionResult Index()
        {
            return View(new RegisterUser()); 
        }
        public IActionResult ListOfRegisteredUsers()
        {
            string myList = HttpContext.Session.GetString("ListOfPeople");
            registerstuff = JsonConvert.DeserializeObject<List<RegisterUser>>(myList);
            return View(registerstuff); 
           
        }
        
        [HttpGet]
        public IActionResult Registration()
        {
            return View(new RegisterUser());
        }
        
        [HttpPost]
        public IActionResult Registration(RegisterUser heyThere)
        {
           
            if (ModelState.IsValid)
            {//this is where you create your sessions
                string registerLoginJSon = HttpContext.Session.GetString("ListOfPeople");
                if(registerLoginJSon != null)
                {
                    registerstuff = JsonConvert.DeserializeObject<List<RegisterUser>>(registerLoginJSon);
                }
                
                registerstuff.Add(heyThere);
                HttpContext.Session.SetString("ListOfPeople", JsonConvert.SerializeObject(registerstuff));

                return RedirectToAction("Summary", heyThere); //makes validation work
            }
            else
            {
                return View(heyThere);
            }
            

        }

        public IActionResult Summary(RegisterUser heyThere)
        {
            return View(heyThere);
            
        }

       /* 
        [HttpPost] //HttpGet is created by default?
        public IActionResult DisplayInfo(RegisterUser user)
        {
            if (ModelState.IsValid)
            {
                return View(user); //sees if it matches datatypes and annotations
            }
            else
            {
                return View("Index", user); //goes to Error in the HomeController
            }
        */

        public IActionResult LoginForm()
        {
            return View();
        }
        [HttpPost]
        public IActionResult SaveLoginInfo(RegisterUser guy, string SaveLogin)
        {
            if (SaveLogin == "yes")
            {
                //add a cookie to the browser to save the user's payment information
                CookieOptions option = new CookieOptions();
                Response.Cookies.Append("UserLoginName", guy.UserName, option); //cant store entire object in cookie
                //include properties that you want to keep
                Response.Cookies.Append("UserLoginPassword", guy.Password, option);
                //Response.Cookies.Append("CreditCardNumber", credit.Number, option);
            }
           // return RedirectToAction("Index", guy);
            return RedirectToAction("Home", guy);
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
