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


        public ActorController(IActorService actorservice)
        {
            _actorservice = actorservice;
        }
        [HttpPost("/AddActor")]
        public async Task<string> AddActorAsync(ActorViewModel Actorviewmodel)
        {

            string msg = await _actorservice.AddActorAsync(Actorviewmodel);
            return msg;

        }



        [HttpGet("/GetAllActors")]
        public IEnumerable<ActorViewModel> GetAllActors()
        {
            var Actors = _actorservice.GetAllActors();
            return Actors;

        }

        [HttpPost("{id}")]
        public ActorViewModel GetActorById(int id)
        {
            var Actor = _actorservice.GetActorById(id);
            return Actor;
        }


        [HttpDelete("{id}/DeleteActor")]
        public async Task<string> DeleteActor(int id)
        {
            var deleteActor = await _actorservice.DeleteActorAsync(id);
            return deleteActor;

        }


        [HttpPut("{id}/UpdateActor")]
        public async Task<string> UpdateActor(int id, ActorViewModel Actor)
        {
            var updateActor = await _actorservice.UpdateActorAsync(id, Actor);
            return updateActor;
        }












    }
}
