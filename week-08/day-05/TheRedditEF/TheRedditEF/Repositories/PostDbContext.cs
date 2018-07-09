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
        /*
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostUser>()
            .HasKey(bc => new { bc.PostID, bc.UserID });

            modelBuilder.Entity<PostUser>()
                .HasOne(ba => ba.Post)
                .WithMany(b => b.Users)
                .HasForeignKey(bc => bc.PostID);

            modelBuilder.Entity<PostUser>()
                .HasOne(bc => bc.User)
                .WithMany(c => c.WrtittenPosts)
                .HasForeignKey(bc => bc.UserID);
        }*/
    }
}
