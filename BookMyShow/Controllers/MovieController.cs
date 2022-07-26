using BookMyShow.Models;
using BookMyShow.Services.Interface;
using BookMyShow.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MovieController : ControllerBase
    {

        private readonly IMovieService _movieservice;


        public MovieController(IMovieService movieservice)
        {
            _movieservice = movieservice;
        }
        [HttpPost]
        public string AddMovie(MovieViewModel movieviewmodel)
        {

            string msg = _movieservice.AddMovies(movieviewmodel);
            return msg;

        }
        
        

        [HttpGet]
        public IEnumerable<MovieViewModel> GetAllMovies()
        {
            var movies = _movieservice.GetAllMovies();
            return movies;

        }

        [HttpPost("{id}")]
        public MovieViewModel GetMovieById(int id)
        {
            var movie = _movieservice.GetMovieById(id);
            return movie;
        }
        [HttpPost("{language}/GetMovieByLanguage")]
        public IEnumerable<MovieViewModel> GetMovieByLanguage(string language)
        {
            var movie = _movieservice.GetMovieByLanguage(language);
            return movie;
        }


    }
}

