package com.alexsystems.theredditclonejavaspringboot.Repositories;

import com.alexsystems.theredditclonejavaspringboot.Models.Post;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

@Repository
public interface RedditRepository extends CrudRepository<Post, Long> {
}
