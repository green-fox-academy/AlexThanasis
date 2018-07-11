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
            ViewModels.PostUser redditList = new ViewModels.PostUser()
            {
                ListOfPosts = redditService.GetAllElements(),
                User = redditService.GetLoginUser(),
                ListOfUsers = redditService.GetAllUsers()
            };
            return View(redditList);
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

        [HttpPost("/Reddit/loginuser")]
        public IActionResult LoginUser(User user)
        {
            redditService.Login(user);
            return RedirectToAction("../Reddit/index");
        }

        [HttpPost("/edit")]
        public IActionResult Edit(long id)
        {
            return View(redditService.GetElementById(id));
        }

        [HttpPost]
        public IActionResult Submit(Post post)
        {
            redditService.Create(post);
            return RedirectToAction("../Reddit/index");
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
            return RedirectToAction("../Reddit/index");
        }

        [HttpPost]
        public IActionResult Down(long id)
        {
            redditService.Down(id);
            return RedirectToAction("../Reddit/index");
        }

        public IActionResult SearchPost(Post post)
        {
            List<Post> tempList = new List<Post>();
            tempList.Add(redditService.SearchPost(post));
            ViewModels.PostUser redditList = new ViewModels.PostUser()
            {
                ListOfPosts = tempList
            };
            return View("../Reddit/index", redditList);
        }

        public IActionResult Service(Post post)
        {
            return View(redditService.GetAllUsers());
        }

        public IActionResult ViewImage(long id)
        {
            return View(redditService.GetElementById(id));
        }

        public IActionResult SaveSignUp(User user)
        {
            redditService.CreateUser(user);
            return View("../index", redditService.GetAllElements());
        }

        public IActionResult Logout()
        {
            redditService.Logout();
            return View("../Reddit/login");
        }
    }
}