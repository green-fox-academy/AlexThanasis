using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheRedditCloneRESTApi.Models
{
    public class RedditRestDbContext : DbContext
    {
        public DbSet<Post>Posts { get; set; }
        public RedditRestDbContext(DbContextOptions<RedditRestDbContext> options) : base(options)
        {

        }
    }
}
