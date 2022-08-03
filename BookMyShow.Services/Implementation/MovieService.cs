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
    public class MovieService : IMovieService


    {
        private readonly MovieContext _appmovieContext;
        private readonly IMapper _mapper;


        public MovieService(MovieContext appmovieContext, IMapper mapper)
        {
            this._appmovieContext = appmovieContext;
            this._mapper = mapper;

        }
     

        public async Task<ResponseViewModel> AddMovieAsync(MovieViewModel movieViewModel)
        {
            Movie moviemodel = _mapper.Map<Movie>(movieViewModel);

            try
            {


                _appmovieContext.Movies.Add(moviemodel);
                await _appmovieContext.SaveChangesAsync();
                return new ResponseViewModel { Message = "Movie Added Successfully" };

            }
            catch
            {
                List<string> error = new List<string>();
                return new ResponseViewModel { Error = error };

            }
        }

        public IEnumerable<MovieViewModel> GetAllMovies()
        {
            

            var movies = _appmovieContext.Movies.ToList();
            var listofMovieViewModel = _mapper.Map<IEnumerable<MovieViewModel>>(movies);
            return listofMovieViewModel;
        }



        public MovieViewModel GetMovieById(int id)
        {
            var movies = _appmovieContext.Movies.ToList();
            var movie = movies.Where(mov => mov.Id == id).FirstOrDefault();
            var moviebyid = _mapper.Map<MovieViewModel>(movie);
            return moviebyid;

        }


        public IEnumerable<MovieViewModel> GetMovieByLanguage(string language)
        {
            
            var movies = _appmovieContext.Movies.ToList();
            var Listmovie = movies.Where(mov => mov.MovieLanguage.ToUpper() == language.ToUpper());
            var moviesbylanguage = _mapper.Map<IEnumerable<MovieViewModel>>(Listmovie);

            return moviesbylanguage;

        }

        


        public async Task<ResponseViewModel> DeleteMovieAsync(int id)
        {
            var movies = _appmovieContext.Movies;
            var movie = movies.Where(mov => mov.Id == id).FirstOrDefault();

            if (movie == null)
            {
                List<string> error = new List<string>();
                error.Add("no Movie exists with this id");

                return new ResponseViewModel { Error = error };

            }
            _appmovieContext.Remove(movie);

            await _appmovieContext.SaveChangesAsync();

            return new ResponseViewModel { Message = "Delete Successfully" };

        }


        public async Task<ResponseViewModel> UpdateMovieAsync(int id,MovieViewModel movie)
        {
            var movieexists=_appmovieContext.Movies.Where(mov => mov.Id == id).FirstOrDefault();

            if (movieexists == null) 
            {
                List<string> error = new List<string>();
                error.Add("no Actor exists with this id");

                return new ResponseViewModel { Error = error };

            }

            movieexists.MovieActor = movie.MovieActor;
            movieexists.MovieDirector = movie.MovieDirector;
            movieexists.MovieGenre = movie.MovieGenre;
            movieexists.MovieLanguage = movie.MovieLanguage;
            movieexists.MovieTitle = movie.MovieTitle;

            _appmovieContext.Movies.Update(movieexists);
            await _appmovieContext.SaveChangesAsync();

            return new ResponseViewModel { Message = "update successfully" };
        }

        public IEnumerable<MovieViewModel> GetMovieByDirector(string director)
        {
            var movies = _appmovieContext.Movies.ToList();
            var Listmovie = movies.Where(mov => mov.MovieDirector.ToUpper() == director.ToUpper());
            var moviesbydirector = _mapper.Map<IEnumerable<MovieViewModel>>(Listmovie);

            return moviesbydirector;

        }

        public IEnumerable<MovieViewModel> GetMovieByGenre(string genre)
        {
            var movies = _appmovieContext.Movies.ToList();
            var Listmovie = movies.Where(mov => mov.MovieGenre.ToUpper() == genre.ToUpper());
            var moviesbygenre = _mapper.Map<IEnumerable<MovieViewModel>>(Listmovie);

            return moviesbygenre;
        }
    }

}
