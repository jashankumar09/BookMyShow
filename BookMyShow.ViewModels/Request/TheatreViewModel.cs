using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.ViewModels.Request
{
    public class TheatreViewModel
    {
        [MaxLength(60)]
        public string TheatreName { get; set; }

        public int TotalSeats { get; set; }

        public bool IsBooked { get; set; }

        public List<SeatViewModel> Seats { get; set; } = new List<SeatViewModel>();
    }
}
