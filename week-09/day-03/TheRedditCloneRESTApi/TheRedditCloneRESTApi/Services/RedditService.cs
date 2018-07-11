using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRedditCloneRESTApi.Models;
using TheRedditCloneRESTApi.Repositories;

namespace TheRedditCloneRESTApi.Services
{
    public class RedditService : IService
    {
        private PostRepository postRepository;

        public RedditService(PostRepository postRepository)
        {
            this.postRepository = postRepository;
        }

        public void AddPost(Post post)
        {
            postRepository.Create(post);
        }

        public void DeletePost(int id)
        {
            throw new NotImplementedException();
        }

        public void DownVotePostById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Post> GetPosts()
        {
            return postRepository.Read();
        }

        public void UpVotePostById(int id)
        {
            throw new NotImplementedException();
        }

        void IService.AddPost(Post post)
        {
            throw new NotImplementedException();
        }
        void IService.UpVotePostById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
