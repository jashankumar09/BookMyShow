using AutoMapper;
using BookMyShow.Database;
using BookMyShow.Models;
using BookMyShow.Services.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BookMyShow.Dto;

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

        public async Task<string> AddActorAsync(ActorDto ActorDto)
        {
            try
            {


                if (ActorDto.Age.GetType() == typeof(int))
                {
                    if (ActorDto.Age<100)
                    {

                        Actor Actormodel = _mapper.Map<Actor>(ActorDto);

                        _appmovieContext.Actors.Add(Actormodel);
                        await _appmovieContext.SaveChangesAsync();
                        
                    }

                }

            }
            catch (Exception)
            {
                return "age is numeric";
            }
            return "please enter valid age";
        }

        public IEnumerable<ActorDto> GetAllActors()
        {

            var Actors = _appmovieContext.Actors.ToList();
            var listofActorDto = _mapper.Map<IEnumerable<ActorDto>>(Actors);
            return listofActorDto;
        }

        public ActorDto GetActorById(int id)
        {
            var Actors = _appmovieContext.Actors.ToList();
            var Actor = Actors.Where(mov => mov.Id == id).FirstOrDefault();
            var Actorbyid = _mapper.Map<ActorDto>(Actor);
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

        public async Task<string> UpdateActorAsync(int id, ActorDto Actor)
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
