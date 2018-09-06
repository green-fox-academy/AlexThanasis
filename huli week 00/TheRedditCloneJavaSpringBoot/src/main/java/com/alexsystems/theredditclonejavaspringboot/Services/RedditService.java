package com.alexsystems.theredditclonejavaspringboot.Services;

import com.alexsystems.theredditclonejavaspringboot.Models.Post;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public interface RedditService {
    List<Post> FindAllPosts();
    void addPost(Post post);

    void upvoteSelectedPost(Long id);

    void downvoteSelectedPost(Long id);

    Post getPostById(Long id);
}
