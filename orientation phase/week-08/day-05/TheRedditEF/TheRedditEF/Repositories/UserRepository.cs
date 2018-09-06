using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRedditEF.Models;

namespace TheRedditEF.Repositories
{
    public class UserRepository : IGenericRepository<User>
    {
        private PostDbContext postDbContext;
        public UserRepository(PostDbContext postDbContext)
        {
            this.postDbContext = postDbContext;
        }

        public void Create(User element)
        {
            postDbContext.Users.Add(element);
            postDbContext.SaveChanges();
        }

        public void Delete(long id)
        {
            User deleteUser = postDbContext.Users.Where(d => d.Id == id).First();
            postDbContext.Users.Remove(deleteUser);
            postDbContext.SaveChanges();
        }

        public List<User> GetAllElements()
        {
            return postDbContext.Users.OrderByDescending(x => x.Id).ToList();
        }

        public User GetElementById(long id)
        {
            return postDbContext.Users.Where(x => x.Id == id).FirstOrDefault();
        }

        public void Update(User element)
        {
            postDbContext.Users.Update(element);
            postDbContext.SaveChanges();
        }
    }
}
