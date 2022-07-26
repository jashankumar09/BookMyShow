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
        
        //Get api/GetAllMovies

        [HttpGet]
        public IEnumerable<MovieViewModel> GetAllMovies()
        {
            var movies = _movieservice.GetAllMovies();
            return movies;

        }
    }
}

