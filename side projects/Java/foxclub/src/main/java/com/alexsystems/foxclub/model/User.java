package com.alexsystems.foxclub.model;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;
import java.util.List;

@Getter
@Setter

@Entity
@Table(name="User")
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
