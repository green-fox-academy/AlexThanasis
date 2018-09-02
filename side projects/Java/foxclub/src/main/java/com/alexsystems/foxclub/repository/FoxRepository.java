package com.alexsystems.foxclub.repository;

import com.alexsystems.foxclub.model.Fox;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface FoxRepository extends CrudRepository<Fox, Long> {

    List<Fox> findAll();
}
