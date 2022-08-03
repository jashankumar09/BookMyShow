using BookMyShow.Dto;
using BookMyShow.Models;
using BookMyShow.ViewModels;
using BookMyShow.ViewModels.Request;
using BookMyShow.ViewModels.Response;
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

     
        Task<ResponseViewModel> AddMovieAsync(MovieViewModel MovieViewModel);

        IEnumerable<MovieViewModel> GetMovieByDirector(string director);

        IEnumerable<MovieViewModel> GetMovieByGenre(string genre);


        Task<ResponseViewModel> DeleteMovieAsync(int id);


        Task <ResponseViewModel> UpdateMovieAsync(int id,MovieViewModel movie);








    }

}
