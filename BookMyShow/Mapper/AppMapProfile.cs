using AutoMapper;
using BookMyShow.Dto;
using BookMyShow.Models;
using BookMyShow.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Mapper
{
    public class AppMapProfile:Profile
    {
        public AppMapProfile()
        {
          CreateMap<Movie,MovieViewModel>().ReverseMap();
          CreateMap<Actor,ActorViewModel>().ReverseMap();


           CreateMap<Movie,MovieDto>().ReverseMap();
           CreateMap<Actor,ActorDto>().ReverseMap();
           CreateMap<MovieActor, Movie_ActorDto>().ReverseMap();

            CreateMap<MovieViewModel, MovieDto>().ReverseMap();
            CreateMap<ActorViewModel, ActorDto>().ReverseMap();
            CreateMap<Movie_ActorViewModel, Movie_ActorDto>().ReverseMap();




        }


    }
}
