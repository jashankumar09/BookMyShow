using AutoMapper;
using BookMyShow.Dto;
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
        private readonly IMapper _mapper;

        public MovieController(IMovieService movieservice, IMapper mapper)
        {
            _movieservice = movieservice;
            this._mapper = mapper;
        }
        [HttpPost("/AddMovie")]
        public async Task<string> AddMovieAsync(MovieViewModel movieviewmodel)
        {
            var moviemodel = _mapper.Map<MovieDto>(movieviewmodel);
       
            string msg =await _movieservice.AddMovieAsync(moviemodel);
            return msg;

        }
        
        

        [HttpGet("/GetAllMovies")]
        public IEnumerable<MovieViewModel> GetAllMovies()

        {
           
            var movies = _movieservice.GetAllMovies();
            var movie=_mapper.Map<IEnumerable<MovieViewModel>>(movies);

            return movie;
            //var moviemodel = _mapper.Map<IEnumerable<MovieDto>>(movies);

           // return Ok(_mapper.Map<IEnumerable<MovieDto>>(movies));

            

        }

        [HttpPost("{id}")]
        public MovieViewModel GetMovieByIdAsync(int id)
        {
            var movie = _movieservice.GetMovieById(id);

            var mov = _mapper.Map<MovieViewModel>(movie);
            
            return mov;
        }
        [HttpPost("{language}/GetMovieByLanguage")]
        public IEnumerable<MovieViewModel> GetMovieByLanguage(string language)
        {
            var movie = _movieservice.GetMovieByLanguage(language);
            var mov = _mapper.Map<IEnumerable<MovieViewModel>>(movie);
            return mov;
        }

        [HttpPost("{director}/GetMovieByDirector")]
        public IEnumerable<MovieViewModel> GetMovieByDirector(string director)
        {
            var movie = _movieservice.GetMovieByDirector(director);
            var mov = _mapper.Map<IEnumerable<MovieViewModel>>(movie);
            return mov;
        }

        [HttpPost("{genre}/GetMovieByGenre")]
        public IEnumerable<MovieViewModel> GetMovieByGenre(string genre)
        {
            var movie = _movieservice.GetMovieByGenre(genre);
            var mov = _mapper.Map<IEnumerable<MovieViewModel>>(movie);
            return mov;
        }









        [HttpDelete("{id}/DeleteMovie")]
        public async Task<string> DeleteMovie(int id)
        {
            var deletemovie=await _movieservice.DeleteMovieAsync(id);
            return deletemovie;

        }


        [HttpPut("{id}/UpdateMovie")]
        public async Task<string>UpdateMovie(int id,MovieDto movie)
        {
            var updatemovie = await _movieservice.UpdateMovieAsync(id,movie);

            return updatemovie;
        }


       

    }
}

