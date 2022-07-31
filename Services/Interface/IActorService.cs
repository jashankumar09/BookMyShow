using BookMyShow.Dto;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Services.Interface
{
    public interface IActorService
    {

        Task<string> AddActorAsync(ActorDto ActorDto);

        Task<string> DeleteActorAsync(int id);


        Task<string> UpdateActorAsync(int id, ActorDto Actor);
        IEnumerable<ActorDto> GetAllActors();

        ActorDto GetActorById(int id);
    }
}
