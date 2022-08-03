
using BookMyShow.ViewModels.Request;
using BookMyShow.ViewModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Services.Interface
{
    public interface IMovieActorService
    {
    
        Task<ResponseViewModel> AddMovieActorAsync(MovieViewModel movie);
       

    }
}
