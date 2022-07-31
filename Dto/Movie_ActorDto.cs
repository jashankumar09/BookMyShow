
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Dto
{
    public class Movie_ActorDto
    {

        public long MovieId { get; set; }

        //public Movie Movie { get; set; }



        public List<long> ActorIds { get; set; }
        
    }
}
