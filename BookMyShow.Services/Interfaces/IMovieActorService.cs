﻿
using BookMyShow.ViewModels.Request;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Services.Interface
{
    public interface IMovieActorService
    {
    
        Task<string> AddMovieActorAsync(MovieViewModel movie);
       

    }
}