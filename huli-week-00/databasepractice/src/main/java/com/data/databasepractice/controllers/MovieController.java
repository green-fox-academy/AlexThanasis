package com.data.databasepractice.controllers;

import com.data.databasepractice.models.Movie;
import com.data.databasepractice.services.MovieServices;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.GetMapping;
import org.springframework.web.bind.annotation.PostMapping;
import org.springframework.web.bind.annotation.RestController;

import java.util.List;

@RestController
public class MovieController {

    @Autowired
    MovieServices movieServices;

    @GetMapping("/list")
    public ResponseEntity<?> renderMovieList(){
        List<Movie> movieList = movieServices.FindAllMovies();
        return ResponseEntity.status(HttpStatus.OK).body(movieList);
    }

    @PostMapping("/add")
    public void addMovie(Movie movie){
        movieServices.save(movie);
    }



}
