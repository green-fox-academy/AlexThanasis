package com.alexsystems.foxclub.model;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;
import java.util.List;

@Getter
@Setter

@Entity
@Table(name="users")
public class User {
    @Id
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;
    private String name;
    private String description;
    private String type;
    //private List<Fox> pets;

    public User() {
    }

    public User(String name, String description, String type) {
        this.name = name;
        this.description = description;
        this.type = type;
    }
}
