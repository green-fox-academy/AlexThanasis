package com.data.databasepractice.services;

import com.data.databasepractice.models.Movie;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public interface MovieServices {
    List<Movie> FindAllMovies();

    void save(Movie movie);
}
