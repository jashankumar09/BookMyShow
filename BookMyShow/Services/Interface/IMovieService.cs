using BookMyShow.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Services.Interface
{
    public interface IMovieService
    {

       String AddMovie(MovieViewModel movieviewmodel);
       IEnumerable<MovieViewModel> GetAllMovies();

        MovieViewModel GetMovieById(int id);

        MovieViewModel GetMovieByTitle(string title);


        MovieViewModel GetMovieByActor(string actor);

        MovieViewModel GetMovieByDirector(String director);

        MovieViewModel GetMovieByLanguage(String language);

        MovieViewModel GetMovieByGenre(string genre);
        string AddMovies(MovieViewModel movieViewModel);
    }

}
