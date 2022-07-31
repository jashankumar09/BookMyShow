
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.ViewModels
{
    public class Movie_ActorViewModel
    {

        public long MovieId { get; set; }

        //public Movie Movie { get; set; }



        public List<long> ActorIds { get; set; }
        
    }
}
