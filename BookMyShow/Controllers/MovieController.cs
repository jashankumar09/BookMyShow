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

        private readonly IMovieRepo _repository;


        public MovieController(IMovieRepo repository)
        {
            _repository = repository;
        }

        [HttpPost]
        public string AddMovie(MovieViewModel movieviewmodel)
        {

            string msg = _repository.AddMovies(movieviewmodel);
            return msg;

        }

        [HttpGet]
        public IEnumerable<MovieViewModel> GetAllMovies()
        {
            var movies = _repository.GetAllMovies();
            return movies;

        }
    }
}

