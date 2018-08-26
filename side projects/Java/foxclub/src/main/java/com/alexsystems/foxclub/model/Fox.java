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
    @GeneratedValue(strategy = GenerationType.IDENTITY)
    private Long id;

    private String name;
    private String descriptipn;
    private String type;
    private String color;
    private Date bornAt;
    //private User user;

    public Fox(String name, String descriptipn, String type, String color, Date bornAt /*, User user*/) {
        this.name = name;
        this.descriptipn = descriptipn;
        this.type = type;
        this.color = color;
        this.bornAt = bornAt;
        //this.user = user;
    }

    public Fox() {
    }
}
