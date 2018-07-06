using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRedditEF.Models;

namespace TheRedditEF.Repositories
{
    public class PostDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Post> Posts { get; set; }
        public PostDbContext(DbContextOptions<PostDbContext> options) : base(options)
        {

        }
    }
}
