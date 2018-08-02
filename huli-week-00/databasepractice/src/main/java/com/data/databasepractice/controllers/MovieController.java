package com.data.databasepractice.controllers;

import com.data.databasepractice.services.MovieServices;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;

@Controller
public class MovieController {

    @Autowired
    MovieServices movieServices;

    @GetMapping("")
    public String renderIndex(Model model){
        model.addAttribute("movies", movieServices.FindAllMovies());
        return "index";
    }
}
