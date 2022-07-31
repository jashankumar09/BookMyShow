using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class MovieActor
    {
        public long Id { get; set; }

        public long MovieId { get; set; }

        public Movie Movie { get; set; }



        public long ActorId { get; set; }
        public Actor Actor { get; set; }
    }
}
