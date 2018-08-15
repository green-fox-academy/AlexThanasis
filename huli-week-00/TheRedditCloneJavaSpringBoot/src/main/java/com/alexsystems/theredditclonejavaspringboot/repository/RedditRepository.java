package com.alexsystems.theredditclonejavaspringboot.repository;

import com.alexsystems.theredditclonejavaspringboot.model.Post;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface RedditRepository extends CrudRepository<Post, Long> {

    List<Post>findAll();
}
