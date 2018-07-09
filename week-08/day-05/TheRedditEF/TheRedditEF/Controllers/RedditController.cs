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

        public IActionResult Signup()
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

        public IActionResult SearchPost(Post post)
        {
            List<Post> tempList = new List<Post>();
            tempList.Add(redditService.SearchPost(post));
            return View("../Reddit/index", tempList);
        }

        public IActionResult Service(Post post)
        {
            return View(redditService.GetAllUsers());
        }

        public IActionResult ViewImage(Post post)
        {
            return View(post);
        }

        public IActionResult SaveSignUp(User user)
        {
            redditService.CreateUser(user);
            return View("../index", redditService.GetAllElements());
        }

        public IActionResult LoginResult(User user)
        {
            if (redditService.TestUser(user))
            {
                redditService.GetAllUsers().Where(x => x.Name == user.Name).First().IsLoggedIn = true; ;
            }
            return View("../Reddit/index");
        }
        public IActionResult SaveSignUpTest()
        {
            User user = new User()
            {
                Name = "TestMan",
                Email = "wtf@wtf.hu",
                IsLoggedIn = true,
                Password = "123test"
            };
            
            redditService.CreateUser(user);
            return View("../Reddit/index", redditService.GetAllElements());
        }

        public IActionResult Logout()
        {
            redditService.Logout();
            return View("../Reddit/login");
        }
    }
}