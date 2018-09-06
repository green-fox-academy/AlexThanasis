using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ToDOEF.Models;
using ToDOEF.Repositories;

namespace ToDOEF.Controllers
{
    public class TodoController : Controller
    {
        private ToDoRepository toDoRepository;

        public TodoController(ToDoRepository toDoRepository)
        {
            this.toDoRepository = toDoRepository;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/list")]
        public IActionResult List()
        {
            return View(toDoRepository.GetAllElements());
        }

        [Route("/add")]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddToDo(ToDo todo)
        {
            toDoRepository.Create(todo);
            return Redirect("../list");
        }

        [HttpPost]
        public IActionResult Delete(long id)
        {
            toDoRepository.Delete(id);
            return Redirect("../list");
        }

        public IActionResult Edit(long id)
        {
            ToDo selectedToDo = toDoRepository.Edit(id);
            return View(selectedToDo);
        }
        
        [HttpPost]
        public IActionResult Update(ToDo todo)
        {
            toDoRepository.Update(todo);
            return Redirect("../list");
        }

        public IActionResult Cancel()
        {
            return Redirect("../list");
        }

        public IActionResult Done(long id)
        {
            toDoRepository.Done(id);
            return Redirect("../list");
        }
        /*
        [HttpPost]
        public IActionResult Search(string todo)
        {
            ToDo chosenToDo = toDoDbContext.ToDos.Where(d => d.Title.Contains(todo)).First();
            return View("ToDo/list");
        } */

        [Route("/assignee")]
        public IActionResult Assignee()
        {
            return View();
        }

        public void AddAssignee(Assignee assignee)
        {
            toDoRepository.CreateAssignee(assignee);
        }
    }
}