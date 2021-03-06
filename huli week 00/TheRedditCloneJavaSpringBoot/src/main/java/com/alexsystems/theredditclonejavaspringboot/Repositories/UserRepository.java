package com.alexsystems.theredditclonejavaspringboot.Repositories;

import com.alexsystems.theredditclonejavaspringboot.Models.User;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface UserRepository extends CrudRepository<User, Long> {
    User findOneByEmail(String email);
    User findOneByName(String name);
}
