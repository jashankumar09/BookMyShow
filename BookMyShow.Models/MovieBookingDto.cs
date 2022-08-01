using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Dto
{
    public class MovieBookingDto
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NoOfTickets { get; set; }
        public long MovieId { get; set; }
        //public List<SeatDto> Seats { get; set; } = new List<SeatDto>();
    }
}
