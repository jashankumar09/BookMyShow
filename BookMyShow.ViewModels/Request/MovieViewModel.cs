using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookMyShow.ViewModels.Request
{
    public class MovieViewModel
    {

        [Required]
        [RegularExpression(@"[a-zA-Z]([a-z A-Z]){2,60}", ErrorMessage = "Only Alphabets are allowed & Title must be of minimum 3-characters.")]
        public string MovieTitle { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-Z]([a-z A-Z]){2,60}", ErrorMessage = "Only Alphabets are allowed & Name must be of minimum 3-characters.")]
        public string MovieActor { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-Z]([a-z A-Z]){2,60}", ErrorMessage = "Only Alphabets are allowed & Name must be of minimum 3-characters.")]
        public string MovieDirector { get; set; }


        [Required]
        [RegularExpression(@"[a-zA-Z]([a-z A-Z]){2,60}", ErrorMessage = "Only Alphabets are allowed & Language must be of minimum 3-characters.")]
        public string MovieLanguage { get; set; }

        [Required]
        [RegularExpression(@"[a-zA-Z]([a-z A-Z]){2,60}", ErrorMessage = "Only Alphabets are allowed & Genre must be of minimum 3-characters.")]
        public string MovieGenre { get; set; }

        public List<long> ActorIds { get; set; }
       
    }
}
