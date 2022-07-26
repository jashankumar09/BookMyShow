using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.ViewModels
{
    public class MovieBookingViewModel
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NoOfTickets { get; set; }
        public long MovieId { get; set; }
        public List<SeatViewModel> Seats { get; set; } = new List<SeatViewModel>();
    }
}
