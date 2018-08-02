package com.data.databasepractice.services;

import com.data.databasepractice.models.Movie;
import com.data.databasepractice.repositories.MovieRepository;
import org.springframework.beans.factory.annotation.Autowired;

import java.util.List;

public class MovieServicesImpl implements MovieServices{
    @Autowired
    MovieRepository movieRepository;

    @Override
    public List<Movie> FindAllMovies() {
        return null;
    }

    @Override
    public void save(Movie movie) {

    }
}
