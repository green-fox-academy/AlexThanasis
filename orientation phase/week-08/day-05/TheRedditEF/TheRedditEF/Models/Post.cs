using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace TheRedditEF.Models
{
    public class Post
    {
        public long Id { get; set; }
        public string Content { get; set; }
        public string Url { get; set; }
        public DateTime CreatedAt { get; set; }
        [DefaultValue(0)]
        public int Score { get; set; }
        public User User { get; set; }
        public long UserID { get; set; }
    }
}
