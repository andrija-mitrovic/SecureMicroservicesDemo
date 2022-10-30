﻿using Movies.Client.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Movies.Client.ApiServices
{
    public class MovieApiService : IMovieApiService
    {
        public async Task<Movie> CreateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }

        public async Task DeleteMovie(string id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<Movie> GetMovie(int id)
        {
            throw new System.NotImplementedException();
        }

        public async Task<IEnumerable<Movie>> GetMovies()
        {
            var movieList = new List<Movie>();
            movieList.Add(new Movie()
            {
                Id = 1,
                Genre = "Comics",
                Title = "asd",
                Rating = "9.2",
                ImageUrl = "images/src",
                ReleaseDate = DateTime.Now,
                Owner = "swn"
            });

            return await Task.FromResult(movieList);
        }

        public async Task<Movie> UpdateMovie(Movie movie)
        {
            throw new System.NotImplementedException();
        }
    }
}
