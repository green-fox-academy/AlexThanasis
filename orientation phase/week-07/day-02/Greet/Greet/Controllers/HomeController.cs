using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Greet.Models;

namespace Greet.Controllers
{
    public class HomeController : Controller
    {
        Greeting greeting = new Greeting();
        public IActionResult Index(string input)
        {
            greeting.Name = input;

            return View(greeting.Text);
        }

        public IActionResult Greet(string input)
        {
            greeting.Name = input;

            return View(greeting.Text);
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
