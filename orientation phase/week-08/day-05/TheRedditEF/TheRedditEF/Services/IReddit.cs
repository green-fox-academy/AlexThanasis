using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRedditEF.Models;

namespace TheRedditEF.Services
{
    interface IReddit
    {
        Post Edit(long id);
        void Upvote(long id);
        void Down(long id);
    }
}
