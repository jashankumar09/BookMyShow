using BookMyShow.Services.Implementation;
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
    [Route("api/[controller]")]
    [ApiController]
    public class MovieActorController : ControllerBase


    {
        private readonly IMovieActorService _movieactorservice;


        public MovieActorController(IMovieActorService movieactorservice)
        {
            _movieactorservice = movieactorservice;
        }
        [HttpPost("/AddMovieActor")]
        public async Task<string> AddMovieActorAsync(MovieViewModel movieviewmodel)
        {

            string msg = await _movieactorservice.AddMovieActorAsync(movieviewmodel);
            return msg;

        }

        //[HttpGet("getactorwithmoviesbyid/{id}")]
        //public async Task<MovieViewModel> GetMovieByIdAsync(long id)
        //{
        //    var response = await _movieactorservice.GetMovieById(id);
        //    return response;
        //}
    }
}
