using System;
using System.Collections.Generic;
using System.Linq;
using TheRedditEF.Models;

namespace TheRedditEF.Repositories
{
    public class PostRepository: IGenericRepository<Post>
    {
        private PostDbContext postDbContext;
        public PostRepository(PostDbContext postDbContext)
        {
            this.postDbContext = postDbContext;
        }

        public void Create(Post element)
        {
            element.CreatedAt = DateTime.Now;
            postDbContext.Posts.Add(element);
            postDbContext.SaveChanges();
        }

        public void Delete(long id)
        {
            Post deleteTodo = postDbContext.Posts.Where(d => d.Id == id).First();
            postDbContext.Posts.Remove(deleteTodo);
            postDbContext.SaveChanges();
        }

        public List<Post> GetAllElements()
        {
            return postDbContext.Posts.OrderByDescending(x=>x.Score).ToList();
        }


        public void Update(Post element)
        {
            postDbContext.Posts.Update(element);
            postDbContext.SaveChanges();
        }

    }
}
