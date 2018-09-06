using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRedditCloneRESTApi.Models;

namespace TheRedditCloneRESTApi.Services
{
    public interface IService
    {
        List<Post> GetPosts();
        void AddPost(Post post);
        void UpVotePostById(int id);
        void DownVotePostById(int id);
        void DeletePost(int id);
    }
}
