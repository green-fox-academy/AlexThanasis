using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheRedditEF.Models
{
    public class User
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool IsLoggedIn { get; set; } 
        public List<Post>WrittenPosts { get; set; }
    }
}
