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
        [RegularExpression(@"[a-zA-Z]([a-z A-Z]){2,60}", ErrorMessage = "Only Alphabets are allowed & Name must be of minimum 3-characters.")]

        public string Name { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Age must be between 0-100 in years.")]
        public int Age { get; set; }

        [Required]
        [EmailAddress]
        [RegularExpression(@"[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        public string Email { get; set; }

        [Required]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile no")]

        public long PhoneNo { get; set; }


    }
}
