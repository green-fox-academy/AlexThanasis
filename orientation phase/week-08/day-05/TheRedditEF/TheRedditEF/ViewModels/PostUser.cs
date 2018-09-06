using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRedditEF.Models;

namespace TheRedditEF.ViewModels
{
    public class PostUser
    {
        public Post Post { get; set; }
        public User User { get; set; }
        public List<Post> ListOfPosts { get; set; }
        public List<User> ListOfUsers { get; set; }
    }
}
