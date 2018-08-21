package com.alexsystems.foxclub.model;

import lombok.Getter;
import lombok.Setter;

import javax.persistence.Entity;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;
import javax.persistence.Id;
import java.util.Date;

@Getter
@Setter
@Entity
public class Fox {
    @Id
    @GeneratedValue(strategy = GenerationType.AUTO)
    private long id;
    private String name;
    private String descriptipn;
    private String type;
    private String color;
    private Date bornAt;
    private User user;

    public Fox(String name, String descriptipn, String type, String color, Date bornAt, User user) {
        this.name = name;
        this.descriptipn = descriptipn;
        this.type = type;
        this.color = color;
        this.bornAt = bornAt;
        this.user = user;
    }

    public Fox() {
    }
}
