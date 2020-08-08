using System;
using System.ComponentModel.DataAnnotations;

namespace Football.Web.Models
{
    public class TeamViewModel
    {
        public int? Id { get; set; }

        [Display(Name = "Name")]
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(60)]
        public string Name { get; set; }

        [Display(Name = "Type")]
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(60)]
        public string Type { get; set; }

    }
}
