package com.alexsystems.theredditclonejavaspringboot.Services;

import com.alexsystems.theredditclonejavaspringboot.Models.Post;
import com.alexsystems.theredditclonejavaspringboot.Repositories.RedditRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class RedditServiceImplem implements RedditService{

    @Autowired
    RedditRepository redditRepository;

    @Override
    public List<Post> FindAllPosts() {
        return redditRepository.findAll();
    }

    @Override
    public void addPost(Post post) {

    }
}
