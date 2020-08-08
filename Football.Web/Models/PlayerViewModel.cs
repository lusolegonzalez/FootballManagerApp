using System;
using System.ComponentModel.DataAnnotations;

namespace Football.Web.Models
{
    public class PlayerViewModel
    {
        public int? Id { get; set; }

        [Display(Name = "FirstName")]
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(60)]
        public string FirstName { get; set; }

        [Display(Name = "LastName")]
        [Required(ErrorMessage = "The {0} field is required.")]
        [StringLength(60)]
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Document { get; set; }
        public TeamViewModel Team { get; set; }

    }
}
