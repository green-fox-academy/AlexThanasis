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
        public IActionResult Doubling(int? recieved)
        {
            if (recieved == null)
            {
                return Json(new { error = "Please, provide an input"});
            }
            else
            {
                return Json(new { received = recieved, result = recieved * 2 });
            }
        }

        [HttpGet("/greeter")]
        public IActionResult Greeter(string name, string title)
        {
            if (name != null && title != null)
            {
                return Json(new { welcome_message = "Oh hi there " + name + "my dear " + title });
            }
            else
            {
                return Json(new { error = "Please provide both the name and the title" });
            }
        }

        [HttpGet("/appenda/{appendable}")]
        public IActionResult AppendA(string appendable)
        {
            if (appendable != null)
            {
                return Json(new { appendable = appendable + "a"});
            }
            else
            {
                return StatusCode(404);
            }
        }

        [HttpPost("/dountil/{what}/{until}")]
        public IActionResult DoUntil(string what, int until)
        {
            if (what.Equals("sum"))
            {
                return Json(new {until  })    
            }
            else if (what.Equals("factor"))
            {

            }
            else
            {
                return Json(new { error = "Please provide a number!" });
            }
        }

    }
}