using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace RestApiWorkshop.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet("/")]
        public IActionResult Index()
        {
            return File("index.html", " text/html");
        }

        [HttpGet("/doubling")]
        public IActionResult Doubling(int? input)
        {
            if (input == null)
            {
                return Json(new { error = "Please, give me an input!"});
            }
            else
            {
                return Json(new { received = input, result = input * 2 });
            }
        }

        [HttpGet("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name != null && title != null)
            {
                return Json(new {name =  });
                return Json(new { error = "Please, give me an input!" });
            }
            else
            {
                return Json(new { received = input, result = input * 2 });
            }
            {
                "welcome_message": "Oh, hi there Petike, my dear student!"
}       
        }
    }
}