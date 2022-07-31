using BookMyShow.Dto;
using BookMyShow.Models;
using BookMyShow.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Services.Interface
{
    public interface IMovieService
    {


       IEnumerable<MovieDto> GetAllMovies();

        MovieDto GetMovieById(int id);


        IEnumerable<MovieDto> GetMovieByLanguage(string language);

     
        Task<string> AddMovieAsync(MovieDto MovieDto);

        IEnumerable<MovieDto> GetMovieByDirector(string director);

        IEnumerable<MovieDto> GetMovieByGenre(string genre);


        Task<string> DeleteMovieAsync(int id);


        Task <string> UpdateMovieAsync(int id,MovieDto movie);








    }

}
