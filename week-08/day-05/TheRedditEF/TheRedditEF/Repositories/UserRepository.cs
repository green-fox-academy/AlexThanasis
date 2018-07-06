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
            throw new NotImplementedException();
        }

        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        public List<User> GetAllElements()
        {
            throw new NotImplementedException();
        }

        public void Update(User element)
        {
            throw new NotImplementedException();
        }
    }
}
