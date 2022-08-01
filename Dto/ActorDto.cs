using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.Dto
{
    public class ActorDto
    {
        [Required]
        public string Name { get; set; }

       [Required]
        public int Age { get; set; }
    }
}
