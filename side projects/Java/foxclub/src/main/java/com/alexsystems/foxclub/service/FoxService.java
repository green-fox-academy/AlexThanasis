package com.alexsystems.foxclub.service;

import com.alexsystems.foxclub.model.Fox;
import org.springframework.data.repository.CrudRepository;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public interface FoxService {

    List<Fox> FindAllFoxes();
    void addFox(Fox fox);
    Fox getFoxById(Long id);

}
