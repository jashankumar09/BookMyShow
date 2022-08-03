using AutoMapper;
using BookMyShow.Dto;
using BookMyShow.Services.Interface;
using BookMyShow.ViewModels;
using BookMyShow.ViewModels.Request;
using BookMyShow.ViewModels.Response;
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
        public async Task<ResponseViewModel> AddActorAsync(ActorViewModel Actorviewmodel)
        {
           // var actormodel = _mapper.Map<ActorDto>(Actorviewmodel);
            var addactor = await _actorservice.AddActorAsync(Actorviewmodel);
            return addactor;

        }



        [HttpGet("/GetAllActors")]
        public IEnumerable<ActorViewModel> GetAllActors()
        {
            var Actors = _actorservice.GetAllActors();
            var actor = _mapper.Map<IEnumerable<ActorViewModel>>(Actors);
            return actor;

        }
        [HttpGet("{name}/GetActorByName")]
        public IEnumerable<ActorViewModel> GetActorByName(string name)
        {
            var Actor = _actorservice.GetActorByName(name);
            var act = _mapper.Map<IEnumerable<ActorViewModel>>(Actor);

            return act;
        }


        [HttpDelete("{id}/DeleteActor")]
        public async Task<ResponseViewModel> DeleteActor(int id)
        {
            var deleteActor = await _actorservice.DeleteActorAsync(id);
            return deleteActor;

        }


        [HttpPut("{id}/UpdateActor")]
        public async Task<ResponseViewModel> UpdateActor(int id, ActorViewModel Actor)
        {
           // var act = _mapper.Map<ActorDto>(Actor);
            var updateActor = await _actorservice.UpdateActorAsync(id, Actor);
            return updateActor;
        }












    }
}
