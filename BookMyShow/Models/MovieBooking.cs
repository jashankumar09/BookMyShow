using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class MovieBooking
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public int NoOfTickets { get; set; }
        public long MovieId { get; set; }
        public List<Seat> Seats { get; set; } = new List<Seat>();
    }
}
