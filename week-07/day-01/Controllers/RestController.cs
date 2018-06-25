using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorld.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [Route("api")]
    public class RestController : Controller
    {   
        [Route("greeting")]
        public IActionResult Greeting(string name)
        {
            Greeting greet = new Greeting(name);

            return new JsonResult(greet);
        }

    }
}
