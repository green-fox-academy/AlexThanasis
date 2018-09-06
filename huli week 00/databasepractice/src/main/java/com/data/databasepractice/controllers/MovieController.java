package com.data.databasepractice.controllers;

import com.data.databasepractice.models.Movie;
import com.data.databasepractice.services.MovieServices;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Controller;
import org.springframework.ui.Model;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.ModelAttribute;
import org.springframework.web.bind.annotation.PostMapping;

@Controller
public class MovieController {

    @Autowired
    MovieServices movieServices;

    @GetMapping("")
    public String renderIndex(Model model){
        movieServices.save(new Movie("The Departed", 7));
        model.addAttribute("movies", movieServices.FindAllMovies());
        //model.addAttribute("newMovie", new Movie());
        return "index";
    }

    @PostMapping("addMovie")
    public String addMovie(@ModelAttribute Movie movie){
        movieServices.save(movie);
        return "redirect: index";
    }
}
