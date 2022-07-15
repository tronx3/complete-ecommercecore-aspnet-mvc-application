﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="Profile Picture is required")]
        [StringLength(50,MinimumLength = 3, ErrorMessage ="Full Name must between 3 and 50 chars")]
        public string ProfilePictureURL { get; set; }
        [Display(Name ="Full Name")]
        [Required(ErrorMessage = "Full Nameis required")]
        public string FullName { get; set; }
        [Display(Name ="Bio")]
        [Required(ErrorMessage = "Bio is required")]
        public string Bio { get; set; }

        //RelationsShips
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
