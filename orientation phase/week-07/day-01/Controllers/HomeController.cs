using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return Content("hellóka");
        }

        [Route("hello")]
        public IActionResult Hello(string name)
        {
            return Content("hello miszter " + name + "!");
        }

    }
}