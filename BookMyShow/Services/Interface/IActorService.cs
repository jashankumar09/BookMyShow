using BookMyShow.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Services.Interface
{
    public interface IActorService
    {

        Task<string> AddActorAsync(ActorViewModel ActorViewModel);

        Task<string> DeleteActorAsync(int id);


        Task<string> UpdateActorAsync(int id, ActorViewModel Actor);
        IEnumerable<ActorViewModel> GetAllActors();

        ActorViewModel GetActorById(int id);
    }
}
