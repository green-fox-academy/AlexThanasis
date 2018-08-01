package com.example.firstspringapp;

import org.springframework.web.bind.annotation.RequestMapping;
import org.springframework.web.bind.annotation.RestController;

@RestController
public class HelloController {

    @RequestMapping("/")
    public String index(){
        return "Hello Whatever";
    }

    @RequestMapping("/hello")
    public String sayHi(){
        return "Hello Hi";
    }
}
