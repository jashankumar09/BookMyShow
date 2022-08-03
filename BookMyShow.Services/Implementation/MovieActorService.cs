using AutoMapper;
using BookMyShow.Database;
using BookMyShow.Models;
using BookMyShow.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Dto;
using BookMyShow.ViewModels.Request;
using BookMyShow.ViewModels.Response;

namespace BookMyShow.Services.Implementation
{
    public class MovieActorService : IMovieActorService
    {
        private readonly MovieContext _appmovieContext;
        private readonly IMapper _mapper;


        public MovieActorService(MovieContext appmovieContext, IMapper mapper)
        {
            this._appmovieContext = appmovieContext;
            this._mapper = mapper;

        }




        public async Task<ResponseViewModel> AddMovieActorAsync(MovieViewModel movie)
        {
            try
            {
                var _movie = new Movie()
                {
                    MovieTitle = movie.MovieTitle,
                    MovieActor = movie.MovieActor,
                    MovieDirector = movie.MovieDirector,
                    MovieLanguage = movie.MovieLanguage,
                    MovieGenre = movie.MovieGenre

                };
                _appmovieContext.Movies.Add(_movie);
                await _appmovieContext.SaveChangesAsync();

                foreach (var id in movie.ActorIds)
                {
                    var _movie_actor = new MovieActor()
                    {
                        MovieId = _movie.Id,
                        ActorId = id
                    };
                    _appmovieContext.Movie_Actor.Add(_movie_actor);


                }
                await _appmovieContext.SaveChangesAsync();
                return new ResponseViewModel { Message = "Movie Added Successfully" };
            }
            catch
            {
                List<string> error = new List<string>();
                error.Add("please add movie");
                return new ResponseViewModel { Error = error };
            }
        }



    }
}
