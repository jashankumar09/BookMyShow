using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Models
{
    public class Seat
    {
        [Key]
        [Required]
        public int Id { get; set; }
        [MaxLength(100)]
        public string SeatNo { get; set; }
        public bool IsOccupied { get; set; }
        public long TheatreId { get; set; }
    }
}
