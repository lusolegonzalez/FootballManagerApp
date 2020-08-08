using System;
using System.ComponentModel.DataAnnotations;

namespace Football.Web.Models
{
    public class TournamentViewModel
    {
        public int? Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(60)]
        public string Name { get; set; }

    }
}
