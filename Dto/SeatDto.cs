using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Dto
{
    public class SeatDto
    {
        [MaxLength(100)]
        public string SeatNo { get; set; }
        public bool IsOccupied { get; set; }
        public long TheatreId { get; set; }
    }
}
