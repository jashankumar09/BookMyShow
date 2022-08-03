

using BookMyShow.ViewModels.Request;
using BookMyShow.ViewModels.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Services.Interface
{
    public interface IActorService
    {

        Task<ResponseViewModel> AddActorAsync(ActorViewModel ActorViewModel);

        Task<ResponseViewModel> DeleteActorAsync(int id);


        Task<ResponseViewModel> UpdateActorAsync(int id, ActorViewModel Actor);
        IEnumerable<ActorViewModel> GetAllActors();

        IEnumerable<ActorViewModel> GetActorByName(string name);
    }
}
