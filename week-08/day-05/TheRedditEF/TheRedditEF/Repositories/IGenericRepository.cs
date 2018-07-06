using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheRedditEF.Repositories
{
    interface IGenericRepository<Type>
    {
        void Create(Type element);

        List<Type> GetAllElements();

        void Update(Type element);

        void Delete(long id);
    }
}
