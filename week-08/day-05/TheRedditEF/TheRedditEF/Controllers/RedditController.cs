using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheRedditEF.Models;
using TheRedditEF.Repositories;

namespace TheRedditEF.Controllers
{
    public class RedditController : Controller
    {
        private PostRepository postRepository;
        public RedditController(PostRepository postRepository)
        {
           this.postRepository = postRepository;
        }

        public IActionResult Index()
        {
            return View();
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
            postRepository.Create(post);
            return Redirect("../index");
        }

        [HttpPost]
        public IActionResult Delete(long id)
        {
            postRepository.Delete(id);
            return Redirect("../index");
        }

        [HttpPost]
        public IActionResult Update(Post post)
        {
            postRepository.Update(post);
            return Redirect("../index");
        }

        [HttpPost]
        public IActionResult Upvote(Post post)
        {
            postRepository.Upvote(post);
            return Redirect("../Index");
        }

        [HttpPost]
        public IActionResult Down(Post post)
        {
            postRepository.Down(post);
            return Redirect("../Index");
        }

        [Route("/search")]
        public IActionResult Search(Post post)
        {
            postRepository.Update(post);
            return Redirect("../index");
        }

        public IActionResult Service(Post post)
        {
            return View();
        }
    }
}