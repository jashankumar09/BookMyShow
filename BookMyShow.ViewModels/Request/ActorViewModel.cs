using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.ViewModels.Request
{
    public class ActorViewModel
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public int Age { get; set; }
    }
}
