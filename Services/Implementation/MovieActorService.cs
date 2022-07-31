using AutoMapper;
using BookMyShow.Database;
using BookMyShow.Models;
using BookMyShow.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Dto;

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

        //public string AddMovieActor(Movie_ActorDto movieactorDto)
        //{
        //    var movies = _appmovieContext.Movies.ToList();
        //    var movie = movies.Where(mov => mov.Id ==movieactorDto.MovieId).FirstOrDefault();
        //    //var actors = _appmovieContext.Actors.ToList();
        //    //var actor=actors.Where(act =>act.Id==)

        //    return " ";

        //}
        //public Movie_ActorDto GetActorWithMovies(long ActorId)
        //{
        //    var actors = _appmovieContext.Actors.Where(n => n.Id ==ActorId).Select(n => new Movie_ActorDto()
        //    {
        //        ActorIds = n.Movie_Actor.Select(n => n.ActorId).ToList()
        //    }).FirstOrDefault();

        //    return actors;
        //}


        public async Task<string> AddMovieActorAsync(MovieDto movie)
        {
            var _movie = new Movie()
            {
                MovieTitle = movie.MovieTitle,
                MovieActor = movie.MovieActor,
                MovieDirector = movie.MovieDirector,
                MovieLanguage = movie.MovieLanguage,
                MovieGenre=movie.MovieGenre

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
            return "Added Successfully";
        }

        //public Movie GetMovieById(long id)
        //{
        //    var _movieWithActors = _appmovieContext.Movies.Where(n => n.Id ==id).Select(movie => new Movie()
        //    {
        //        MovieTitle = movie.MovieTitle,
        //        MovieActor = movie.MovieActor,
        //        MovieDirector = movie.MovieDirector,
        //        MovieLanguage = movie.MovieLanguage,
        //        MovieGenre = movie.MovieGenre,
        //        ActorNames = movie. Movie_Actor.Select(n => n.Actor.Name).ToList()
        //    }).FirstOrDefault();

        //    return _;
        //}

    }
}
