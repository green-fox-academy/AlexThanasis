using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRedditEF.Models;

namespace TheRedditEF.ViewModels
{
    public class PostUser
    {
        public Post post;
        public User user;
        public List<Post> listOfPosts;
        public List<User> listOfUsers;
    }
}
