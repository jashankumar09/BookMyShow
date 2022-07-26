using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.ViewModels
{
    public class MovieViewModel
    {

        [Required]
        public string MovieTitle { get; set; }

        [Required]
        public string MovieActor { get; set; }

        [Required]
        public string MovieDirector { get; set; }


        [Required]
        public string MovieLanguage { get; set; }


        [Required]
        public string MovieGenre { get; set; }
    }
}
