using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace eTickets.Models
{
    public class Cinema
    {
        [Key]
        public int Id { get; set; }

        [Display(Name ="Cinema Logo")]
        public string CinemaLogo { get; set; }

        [Display(Name ="Cinema Name")]
        public string  Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        //RelationsShip
        public List<Movie> Movies { get; set; }
    }
}
