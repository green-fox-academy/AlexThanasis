package com.alexsystems.foxclub.model;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;
import java.util.ArrayList;
import java.util.Collection;
import java.util.List;
import java.util.Set;

@Getter
@Setter

@Entity
@Table(name="users")
public class User {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;
    private String name;
    private String description;
    private String type;

    @OneToMany
    @JoinTable(name = "USER_FOX", joinColumns = @JoinColumn(name = "USER_ID"),
    inverseJoinColumns = @JoinColumn(name = "FOX_ID"))
    private Collection<Fox> pets = new ArrayList<Fox>();

    public User() {
    }

    public User(String name, String description, String type) {
        this.name = name;
        this.description = description;
        this.type = type;
    }
}
