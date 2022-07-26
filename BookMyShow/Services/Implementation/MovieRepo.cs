using AutoMapper;
using BookMyShow.Database;
using BookMyShow.Models;
using BookMyShow.ViewModels;
using BookMyShow.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Services.Implementation
{
    public class MovieRepo : IMovieRepo

    {
        private readonly MovieContext _appmovieContext;
        private readonly IMapper _mapper;


        public MovieRepo(MovieContext appmovieContext,IMapper mapper)
        {
            this._appmovieContext = appmovieContext;
            this._mapper = mapper;

        }
        public string AddMovie(MovieViewModel movieviewmodel)
        {
            throw new NotImplementedException();
        }

        public string AddMovies(MovieViewModel movieViewModel)
        {
            Movie moviemodel = _mapper.Map<Movie>(movieViewModel);

            _appmovieContext.Movies.Add(moviemodel);
            _appmovieContext.SaveChanges();

            return "save successfully";

        }

        public IEnumerable<MovieViewModel> GetAllMovies()
        {
            //var commands = new List<MovieViewModel>
            //{
            //    new MovieViewModel { MovieTitle = "Boil corn", MovieActor = "Boil Water", MovieDirector = "kettle &Pan",MovieLanguage="English",MovieGenre="Comedy" },
            //    new MovieViewModel { MovieTitle = "Boil corn", MovieActor = "Boil Water", MovieDirector = "kettle &Pan",MovieLanguage="English",MovieGenre="Comedy" },
            //    new MovieViewModel {MovieTitle = "Boil corn", MovieActor = "Boil Water", MovieDirector = "kettle &Pan",MovieLanguage="English",MovieGenre="Comedy"}


            //};
            //return commands;

            var movies = _appmovieContext.Movies.ToList();
            var listofMovieViewmodel = _mapper.Map<IEnumerable<MovieViewModel>>(movies);

            return listofMovieViewmodel;

        }

        public MovieViewModel GetMovieByActor(string actor)
        {
            throw new NotImplementedException();
        }

        public MovieViewModel GetMovieByDirector(string director)
        {
            throw new NotImplementedException();
        }

        public MovieViewModel GetMovieByGenre(string genre)
        {
            throw new NotImplementedException();
        }

        public MovieViewModel GetMovieById(int id)
        {
            var movies = _appmovieContext.Movies.ToList();
            var movie = movies.Where(mov => mov.MovieId == id).FirstOrDefault();
            var moviebyid= _mapper.Map<MovieViewModel>(movie);
            return moviebyid;

        }
        

        public MovieViewModel GetMovieByLanguage(string language)
        {
            throw new NotImplementedException();
        }

        public MovieViewModel GetMovieByTitle(string title)
        {
            throw new NotImplementedException();
        }
    }
}
