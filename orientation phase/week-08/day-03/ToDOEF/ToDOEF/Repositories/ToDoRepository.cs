using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDOEF.Models;

namespace ToDOEF.Repositories
{
    public class ToDoRepository : IGenericRepository<ToDo>
    {
        private ToDoDbContext toDoDbContext;
        public ToDoRepository(ToDoDbContext toDoDbContext)
        {
            this.toDoDbContext = toDoDbContext;
        }

        public void Create(ToDo element)
        {
            toDoDbContext.ToDos.Add(element);
            toDoDbContext.SaveChanges();
        }

        public void Delete(long id)
        {
            ToDo deleteTodo = toDoDbContext.ToDos.Where(d => d.Id == id).First();
            toDoDbContext.ToDos.Remove(deleteTodo);
            toDoDbContext.SaveChanges();
        }

        public List<ToDo> GetAllElements()
        {
            return toDoDbContext.ToDos.ToList();
        }

        public ToDo Edit(long id)
        {
            ToDo selectedToDo = toDoDbContext.ToDos.Where(d => d.Id == id).First();
            return selectedToDo;
        }

        public void Update(ToDo element)
        {
            toDoDbContext.ToDos.Update(element);
            toDoDbContext.SaveChanges();
        }

        public void Done(long id)
        {
            ToDo updatedToDo = toDoDbContext.ToDos.Where(d => d.Id == id).First();
            updatedToDo.IsDone = true;
            toDoDbContext.ToDos.Update(updatedToDo);
            toDoDbContext.SaveChanges();
        }

        public void CreateAssignee(Assignee assignee)
        {
            toDoDbContext.Assignees.Add(assignee);
            toDoDbContext.SaveChanges();
        }
    }
}
