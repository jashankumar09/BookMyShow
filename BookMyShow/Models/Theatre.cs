using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class Theatre
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [MaxLength(60)]
        public string TheatreName { get; set; }

        public int TotalSeats { get; set; }

        public bool IsBooked { get; set; }

        public List<Seat> Seats { get; set; } = new List<Seat>();
    }
}
