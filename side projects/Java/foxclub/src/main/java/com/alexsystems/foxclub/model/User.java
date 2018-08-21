package com.alexsystems.foxclub.model;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import java.util.List;

@Getter
@Setter
@Entity
public class User {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private long id;
    private String name;
    private String description;
    private String type;
    private List<Fox> pets;

    public User() {
    }

    public User(String name, String description, String type) {
        this.name = name;
        this.description = description;
        this.type = type;
    }
}
