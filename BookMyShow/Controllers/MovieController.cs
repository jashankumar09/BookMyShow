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
        [HttpPost("/AddMovie")]
        public async Task<string> AddMovieAsync(MovieViewModel movieviewmodel)
        {

            string msg =await _movieservice.AddMovieAsync(movieviewmodel);
            return msg;

        }
        
        

        [HttpGet("/GetAllMovies")]
        public IEnumerable<MovieViewModel> GetAllMovies()
        {
            var movies = _movieservice.GetAllMovies();
            return movies;

        }

        [HttpPost("{id}")]
        public MovieViewModel GetMovieByIdAsync(int id)
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

        [HttpPost("{director}/GetMovieByDirector")]
        public IEnumerable<MovieViewModel> GetMovieByDirector(string director)
        {
            var movie = _movieservice.GetMovieByDirector(director);
            return movie;
        }

        [HttpPost("{genre}/GetMovieByGenre")]
        public IEnumerable<MovieViewModel> GetMovieByGenre(string genre)
        {
            var movie = _movieservice.GetMovieByGenre(genre);
            return movie;
        }









        [HttpDelete("{id}/DeleteMovie")]
        public async Task<string> DeleteMovie(int id)
        {
            var deletemovie=await _movieservice.DeleteMovieAsync(id);
            return deletemovie;

        }


        [HttpPut("{id}/UpdateMovie")]
        public async Task<string>UpdateMovie(int id,MovieViewModel movie)
        {
            var updatemovie = await _movieservice.UpdateMovieAsync(id,movie);
            return updatemovie;
        }


       

    }
}

