package com.data.databasepractice.services;

import com.data.databasepractice.models.Movie;
import com.data.databasepractice.repositories.MovieRepository;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.stereotype.Service;

import java.util.List;

@Service
public class MovieServicesImpl implements MovieServices{
    @Autowired
    MovieRepository movieRepository;

    @Override
    public List<Movie> FindAllMovies() {
        return movieRepository.findAll();
    }

    @Override
    public void save(Movie movie) {

    }
}
