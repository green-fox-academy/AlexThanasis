using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TheRedditCloneRESTApi.Services;

namespace TheRedditCloneRESTApi.Controllers
{
    [Produces("application/json")]
    [Route("")]
    public class RedditController : Controller
    {
        private IService database;

        public RedditController(IService database)
        {
            this.database = database;
        }

        [HttpGet("/posts")]
        [Route("")]
        public IActionResult ListAllPosts()
        {
            return Json( new { /*posts = database.GetPosts*/ });
        }

    }
}