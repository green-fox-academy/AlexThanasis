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
        private ToDoDbContext toDoDbContext;

        public TodoController(ToDoDbContext toDoDbContext)
        {
            this.toDoDbContext = toDoDbContext;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Route("/list")]
        public IActionResult List()
        {
            return View(toDoDbContext.ToDos.ToList());
        }

        [Route("/add")]
        public IActionResult Add()
        {
            return View(toDoDbContext.ToDos.ToList());
        }

        [HttpPost]
        public IActionResult AddToDo(ToDo todo)
        {
            toDoDbContext.ToDos.Add(todo);
            toDoDbContext.SaveChanges();
            return Redirect("../list");
        }

        [HttpPost]
        public IActionResult Delete(long id)
        {
            ToDo deleteTodo = toDoDbContext.ToDos.Where(d => d.Id == id).First();
            toDoDbContext.ToDos.Remove(deleteTodo);
            toDoDbContext.SaveChanges();
            return Redirect("../list");
        }

        public IActionResult Edit(long id)
        {
            ToDo selectedToDo = toDoDbContext.ToDos.Where(d => d.Id == id).First();
            return View(selectedToDo);
        }
        
        [HttpPost]
        public IActionResult Update(ToDo todo)
        {
            toDoDbContext.ToDos.Update(todo);
            toDoDbContext.SaveChanges();
            return Redirect("../list");
        }

        public IActionResult Cancel()
        {
            return Redirect("../list");
        }

        public IActionResult Done(long id)
        {
            ToDo updatedToDo = toDoDbContext.ToDos.Where(d => d.Id == id).First();
            toDoDbContext.ToDos.Update(updatedToDo);
            toDoDbContext.SaveChanges();
            return Redirect("../list");
        }
    }
}