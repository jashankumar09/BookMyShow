using AutoMapper;
using BookMyShow.Database;
using BookMyShow.Models;
using BookMyShow.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Dto;
using BookMyShow.ViewModels.Request;

namespace BookMyShow.Services.Implementation
{
    public class ActorService : IActorService
    {
        private readonly MovieContext _appmovieContext;
        private readonly IMapper _mapper;

        public ActorService(MovieContext appmovieContext, IMapper mapper)
        {
            this._appmovieContext = appmovieContext;
            this._mapper = mapper;
        }

        public async Task<string> AddActorAsync(ActorViewModel ActorViewModel)
        {
            try
            {


                if (ActorViewModel.Age.GetType() == typeof(int))
                {
                    if (ActorViewModel.Age < 100)
                    {

                        Actor Actormodel = _mapper.Map<Actor>(ActorViewModel);

                        _appmovieContext.Actors.Add(Actormodel);
                        await _appmovieContext.SaveChangesAsync();

                    }

                }

            }

            catch (Exception e)
            {
                Console.WriteLine("Please Enter valid age", e.Message);
            }

            return "";
         
        
        }

        public IEnumerable<ActorViewModel> GetAllActors()
        {

            var Actors = _appmovieContext.Actors.ToList();
            var listofActorViewModel = _mapper.Map<IEnumerable<ActorViewModel>>(Actors);
            return listofActorViewModel;
        }

        public ActorViewModel GetActorById(int id)
        {
            var Actors = _appmovieContext.Actors.ToList();
            var Actor = Actors.Where(mov => mov.Id == id).FirstOrDefault();
            var Actorbyid = _mapper.Map<ActorViewModel>(Actor);
            return Actorbyid;

        }

        public async Task<string> DeleteActorAsync(int id)
        {
            var Actors = _appmovieContext.Actors;
            var Actor = Actors.Where(mov => mov.Id == id).FirstOrDefault();

            if (Actor == null)
            {
                return $"no Actor found for this id {id}";
            }
            _appmovieContext.Remove(Actor);

            await _appmovieContext.SaveChangesAsync();

            return "Delete Successfully";

        }

        public async Task<string> UpdateActorAsync(int id, ActorViewModel Actor)
        {
            var Actorexists = _appmovieContext.Actors.Where(mov => mov.Id == id).FirstOrDefault();

            if (Actorexists == null)
            {
                return $"no Actor exists with this id {id}";
            }


            Actorexists.Age = Actor.Age;
            Actorexists.Name = Actor.Name;


            _appmovieContext.Actors.Update(Actorexists);
            await _appmovieContext.SaveChangesAsync();

            return "Update Successfully";
        }

    }
}
