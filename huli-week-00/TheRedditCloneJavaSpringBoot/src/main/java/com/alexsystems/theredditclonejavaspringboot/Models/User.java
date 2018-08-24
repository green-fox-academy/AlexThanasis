package com.alexsystems.theredditclonejavaspringboot.Models;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;
import java.util.List;

@Getter
@Setter
@Entity
@Table(name="USER")
public class User {

    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private long id;
    private String name;
    private String description;
    private String password;
    private String email;
    private boolean activated;
    private boolean admin;
   // @OneToMany(mappedBy = "USER")
   // private List<Post> posts;

    public User() {
    }

    public User(String name, String description, String password, String email, boolean activated, boolean admin) {
        this.name = name;
        this.description = description;
        this.password = password;
        this.email = email;
        this.activated = activated;
        this.admin = admin;
    }
}
