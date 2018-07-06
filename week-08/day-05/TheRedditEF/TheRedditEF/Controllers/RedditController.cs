using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheRedditEF.Models;
using TheRedditEF.Repositories;
using TheRedditEF.Services;

namespace TheRedditEF.Controllers
{
    public class RedditController : Controller
    {
        private RedditService redditService;
        public RedditController(RedditService redditService)
        {
            this.redditService = redditService;
        }
        public IActionResult Index()
        {
            return View(redditService.GetAllElements());
        }

        [Route("/createpost")]
        public IActionResult CreatePost ()
        {
            return View("submit");
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Submit(Post post)
        {
            redditService.Create(post);
            return View("../Reddit/index", redditService.GetAllElements());
        }

        [HttpPost]
        public IActionResult Delete(long id)
        {
            redditService.Delete(id);
            return Redirect("../index");
        }

        [HttpPost]
        public IActionResult Update(Post post)
        {
            redditService.Update(post);
            return Redirect("../index");
        }

        [HttpPost]
        public IActionResult Upvote(long id)
        {
            redditService.Upvote(id);
            return View("../Reddit/index", redditService.GetAllElements());
        }

        [HttpPost]
        public IActionResult Down(long id)
        {
            redditService.Down(id);
            return View("../Reddit/index", redditService.GetAllElements());
        }

        [Route("/search")]
        public IActionResult Search(Post post)
        {
            redditService.Update(post);
            return Redirect("../index");
        }

        public IActionResult Service(Post post)
        {
            return View();
        }

        public IActionResult ViewImage(Post post)
        {
            return View(post);
        }

    }
}