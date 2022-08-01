using AutoMapper;
using BookMyShow.Dto;
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
        private readonly IMapper _mapper;


        public MovieActorController(IMovieActorService movieactorservice, IMapper mapper)
        {
            _movieactorservice = movieactorservice;
            this._mapper = mapper;
        }
        [HttpPost("/AddMovieActor")]
        public async Task<string> AddMovieActorAsync(MovieViewModel movieviewmodel)
        {
            var moviemodel = _mapper.Map<MovieDto>(movieviewmodel);

            string msg = await _movieactorservice.AddMovieActorAsync(moviemodel);
            return msg;

        }


    }
}
