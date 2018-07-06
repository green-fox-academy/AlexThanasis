using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheRedditEF.Models;
using TheRedditEF.Repositories;

namespace TheRedditEF.Services
{
    public class RedditService : IReddit
    {
        private PostRepository postRepository;
        private UserRepository userRepository;
        public RedditService(PostRepository postRepository, UserRepository userRepository)
        {
            this.postRepository = postRepository;
            this.userRepository = userRepository;
        }

        public void Upvote(long id)
        {
            postRepository.GetAllElements().Where(x => x.Id == id).First().Score += 1;
            postRepository.Update(postRepository.GetAllElements().Where(x => x.Id == id).First());
        }

        public void Down(long id)
        {
            postRepository.GetAllElements().Where(x => x.Id == id).First().Score -= 1;
            postRepository.Update(postRepository.GetAllElements().Where(x => x.Id == id).First());
        }

        public Post Edit(long id)
        {
            var selectedTodo = postRepository.GetAllElements().Where(x => x.Id == id).First();
            return selectedTodo;
        }

        public void Delete(long id)
        {
            postRepository.Delete(id);
        }

        internal void Update(Post post)
        {
            postRepository.Update(post);
        }

        public List<Post> GetAllElements()
        {
            return postRepository.GetAllElements();
        }

        public void Create(Post element)
        {
            postRepository.Create(element);
        }

    }
}
