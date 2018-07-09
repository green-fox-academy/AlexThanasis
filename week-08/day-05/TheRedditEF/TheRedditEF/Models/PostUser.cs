using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheRedditEF.Models
{
    public class PostUser
    {
        public int Id { get; set; }
        public Post Post { get; set; }
        public int PostID { get; set; }
        public User User { get; set; }
        public int UserID { get; set; }
        public List<User> listOfUsers { get; set; }
        public List<Post> listOfPosts { get; set; }
    }
}
