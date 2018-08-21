package com.alexsystems.foxclub.service;

import com.alexsystems.foxclub.model.Fox;
import com.alexsystems.foxclub.repository.FoxRepository;
import org.springframework.beans.factory.annotation.Autowired;

import javax.print.attribute.standard.DateTimeAtCompleted;
import java.util.List;

public class FoxServiceImplement implements FoxService {

    @Autowired
    FoxRepository foxRepository;

    @Override
    public List<Fox> FindAllFoxes() {
        return foxRepository.findAll();
    }

    @Override
    public void addFox(Fox fox) {
        //fox.setBornAt();
        foxRepository.save(fox);
    }

    @Override
    public Fox getFoxById(Long id) {
        return foxRepository.findById(id).get();
    }
}
