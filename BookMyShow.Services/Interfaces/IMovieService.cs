using BookMyShow.Dto;
using BookMyShow.Models;
using BookMyShow.ViewModels;
using BookMyShow.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Services.Interface
{
    public interface IMovieService
    {


       IEnumerable<MovieViewModel> GetAllMovies();

        MovieViewModel GetMovieById(int id);


        IEnumerable<MovieViewModel> GetMovieByLanguage(string language);

     
        Task<string> AddMovieAsync(MovieViewModel MovieViewModel);

        IEnumerable<MovieViewModel> GetMovieByDirector(string director);

        IEnumerable<MovieViewModel> GetMovieByGenre(string genre);


        Task<string> DeleteMovieAsync(int id);


        Task <string> UpdateMovieAsync(int id,MovieViewModel movie);








    }

}
