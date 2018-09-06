using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDOEF.Models
{
    public class Assignee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public List<ToDo> AssignedToDos { get; set; }
    }
}
