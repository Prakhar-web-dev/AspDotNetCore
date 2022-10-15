using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Book_Store.Controllers
{
    public class HomeController: Controller
    {
        public ViewResult index()
        {
            //return View("aboutUs"); 
            return View();
        }

        public ViewResult aboutUs()
        {
            return View();   
        }
        public ViewResult model()
        {
            var obj = new { id = 1, title = "harry", author = "peter" };
            //return View(obj);

            return View("aboutUs", obj);  
        }
        public ViewResult ContactUs()
        {
            return View("TempView/temp.cshtml"); // for returning view from different location or differnt folder
            //return View();
        }
    }
}
