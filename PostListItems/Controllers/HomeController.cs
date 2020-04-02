using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PostListItems.Models;

namespace PostListItems.Controllers
{
    public class Car
    {
        public string Make { get; set; }
        public string Model { get; set; }
    }

    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddCar(List<Car> cars)
        {
            return Redirect("/");
        }
    }
}
