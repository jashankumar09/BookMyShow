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
    public class MovieService : IMovieService


    {
        private readonly MovieContext _appmovieContext;
        private readonly IMapper _mapper;


        public MovieService(MovieContext appmovieContext, IMapper mapper)
        {
            this._appmovieContext = appmovieContext;
            this._mapper = mapper;

        }
     

        public async Task<string> AddMovieAsync(MovieDto movieDto)
        {
            Movie moviemodel = _mapper.Map<Movie>(movieDto);

            _appmovieContext.Movies.Add(moviemodel);
            await _appmovieContext.SaveChangesAsync();
            return "save successfully";

        }

        public IEnumerable<MovieDto> GetAllMovies()
        {
            

            var movies = _appmovieContext.Movies.ToList();
            var listofMovieDto = _mapper.Map<IEnumerable<MovieDto>>(movies);
            return listofMovieDto;
        }



        public MovieDto GetMovieById(int id)
        {
            var movies = _appmovieContext.Movies.ToList();
            var movie = movies.Where(mov => mov.Id == id).FirstOrDefault();
            var moviebyid = _mapper.Map<MovieDto>(movie);
            return moviebyid;

        }


        public IEnumerable<MovieDto> GetMovieByLanguage(string language)
        {
            var movies = _appmovieContext.Movies.ToList();
            var Listmovie = movies.Where(mov => mov.MovieLanguage == language);
            var moviesbylanguage = _mapper.Map<IEnumerable<MovieDto>>(Listmovie);

            return moviesbylanguage;

        }

        


        public async Task<string> DeleteMovieAsync(int id)
        {
            var movies = _appmovieContext.Movies;
            var movie = movies.Where(mov => mov.Id == id).FirstOrDefault();

            if (movie == null)
            {
                return $"no movie found for this id {id}";
            }
            _appmovieContext.Remove(movie);

            await _appmovieContext.SaveChangesAsync();

            return "Delete Successfully";

        }


        public async Task<string> UpdateMovieAsync(int id,MovieDto movie)
        {
            var movieexists=_appmovieContext.Movies.Where(mov => mov.Id == id).FirstOrDefault();

            if (movieexists == null) 
            {
                return $"no movie exists with this id {id}";
            }

            movieexists.MovieActor = movie.MovieActor;
            movieexists.MovieDirector = movie.MovieDirector;
            movieexists.MovieGenre = movie.MovieGenre;
            movieexists.MovieLanguage = movie.MovieLanguage;
            movieexists.MovieTitle = movie.MovieTitle;

            _appmovieContext.Movies.Update(movieexists);
            await _appmovieContext.SaveChangesAsync();

            return "Update Successfully";
        }

        public IEnumerable<MovieDto> GetMovieByDirector(string director)
        {
            var movies = _appmovieContext.Movies.ToList();
            var Listmovie = movies.Where(mov => mov.MovieDirector == director);
            var moviesbydirector = _mapper.Map<IEnumerable<MovieDto>>(Listmovie);

            return moviesbydirector;

        }

        public IEnumerable<MovieDto> GetMovieByGenre(string genre)
        {
            var movies = _appmovieContext.Movies.ToList();
            var Listmovie = movies.Where(mov => mov.MovieDirector == genre);
            var moviesbygenre = _mapper.Map<IEnumerable<MovieDto>>(Listmovie);

            return moviesbygenre;
        }
    }

}
