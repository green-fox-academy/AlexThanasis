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

        public User GetLoginUser()
        {
            User loginnedUser = userRepository.GetAllElements().Where(u => u.IsLoggedIn == true).FirstOrDefault();
            return loginnedUser;
        }

        public void Login(User user)
        {
            if (TestLoginUser(user))
            {
                User currentUser = userRepository.GetAllElements().Where(u => u.Name == user.Name).FirstOrDefault();
                currentUser.IsLoggedIn = true;
                userRepository.Update(currentUser);
            }
            else
            {
            }
        }

        public bool TestLoginUser(User user)
        {
            var currentUser = userRepository.GetAllElements().Where(u => u.Name == user.Name).FirstOrDefault();
            if (currentUser.Password == user.Password)
            {
                return true;
            }
            else
            {
                return false;
            }
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

        public void Update(Post post)
        {
            postRepository.Update(post);
        }

        public List<Post> GetAllElements()
        {
            return postRepository.GetAllElements();
        }

        public Post GetElementById(long id)
        {
            return postRepository.GetElementById(id);
        }

        public void Create(Post element)
        {
            postRepository.Create(element);
        }

        public Post SearchPost(Post post)
        {
            var searchingPost = postRepository.GetAllElements().Where(s => s.Content.Contains(post.Content)).First();
            return searchingPost;
        }

        public User EditUser(long id)
        {
            var editUser = userRepository.GetAllElements().Where(x => x.Id == id).First();
            return editUser;
        }

        public void DeleteUser(long id)
        {
            userRepository.Delete(id);
        }

        public void UpdateUser(User user)
        {
            userRepository.Update(user);
        }

        public List<User> GetAllUsers()
        {
            return userRepository.GetAllElements();
        }

        public User GetUSerById(long id)
        {
            return userRepository.GetElementById(id);
        }

        public bool TestUser(User user)
        {
            if (userRepository.GetAllElements().Where(x => x.Name == user.Name).First().Password == user.Password )
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public void CreateUser(User user)
        {
            userRepository.Create(user);
        }

        public User SearchUser(User user)
        {
            var searchingUser = userRepository.GetAllElements().Where(s => s.Name.Contains(user.Name)).First();
            return searchingUser;
        }

        public void Logout()
        {
            var userToLogOut = userRepository.GetAllElements().Where(x => x.IsLoggedIn == true).First();
            userToLogOut.IsLoggedIn = false;
            userRepository.Update(userToLogOut);
        }
    }
}
