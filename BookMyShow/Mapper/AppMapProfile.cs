using AutoMapper;
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
        CreateMap<MovieViewModel,Movie>().ReverseMap();
        CreateMap<ActorViewModel,Actor>().ReverseMap();


        }


    }
}
