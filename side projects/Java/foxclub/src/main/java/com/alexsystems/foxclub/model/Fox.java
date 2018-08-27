package com.alexsystems.foxclub.model;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.*;
import java.util.Date;

@Getter
@Setter

@Entity
@Table(name="foxes")
public class Fox {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private Long id;

    private String name;
    private String description;
    private String type;
    private String color;
    private Date bornAt;
    @ManyToOne
    private User user;

    public Fox(String name, String description, String type, String color, Date bornAt /*, User user*/) {
        this.name = name;
        this.description = description;
        this.type = type;
        this.color = color;
        this.bornAt = bornAt;
        //this.user = user;
    }

    public Fox() {
    }
}
