using AutoMapper;
using BookMyShow.Dto;
using BookMyShow.Services.Interface;
using BookMyShow.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class ActorController:ControllerBase
    {
        private readonly IActorService _actorservice;
        private readonly IMapper _mapper;


        public ActorController(IActorService actorservice, IMapper mapper)
        {
            _actorservice = actorservice;
            this._mapper = mapper;
        }
        [HttpPost("/AddActor")]
        public async Task<string> AddActorAsync(ActorViewModel Actorviewmodel)
        {
            var actormodel = _mapper.Map<ActorDto>(Actorviewmodel);
            string msg = await _actorservice.AddActorAsync(actormodel);
            return msg;

        }



        [HttpGet("/GetAllActors")]
        public IEnumerable<ActorViewModel> GetAllActors()
        {
            var Actors = _actorservice.GetAllActors();
            var actor = _mapper.Map<IEnumerable<ActorViewModel>>(Actors);
            return actor;

        }

        [HttpPost("{id}")]
        public ActorViewModel GetActorById(int id)
        {
            var Actor = _actorservice.GetActorById(id);
            var act = _mapper.Map<ActorViewModel>(Actor);

            return act;
        }


        [HttpDelete("{id}/DeleteActor")]
        public async Task<string> DeleteActor(int id)
        {
            var deleteActor = await _actorservice.DeleteActorAsync(id);
            return deleteActor;

        }


        [HttpPut("{id}/UpdateActor")]
        public async Task<string> UpdateActor(int id, ActorDto Actor)
        {
            var updateActor = await _actorservice.UpdateActorAsync(id, Actor);
            return updateActor;
        }












    }
}
