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

       //string AddMovie(MovieViewModel movieviewmodel);
       IEnumerable<MovieViewModel> GetAllMovies();

        MovieViewModel GetMovieById(int id);

        //MovieViewModel GetMovieByTitle(string title);


        //MovieViewModel GetMovieByActor(string actor);

        //MovieViewModel GetMovieByDirector(String director);

        IEnumerable<MovieViewModel> GetMovieByLanguage(string language);

        //MovieViewModel GetMovieByGenre(string genre);
        string AddMovie(MovieViewModel movieViewModel);

        IEnumerable<MovieViewModel> GetMovieByDirector(string director);

        IEnumerable<MovieViewModel> GetMovieByGenre(string genre);


        Task<string> DeleteMovieAsync(int id);


        Task <string> UpdateMovieAsync(int id,MovieViewModel movie);








    }

}
