using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Football.Web.Models
{
    public class MatchViewModel
    {

        public int Id { get; set; }

        [Display(Name = "Local")]
        [Required(ErrorMessage = "The {0} field is required.")]
        public TeamViewModel Local { get; set; }

        [Display(Name = "Visit")]
        [Required(ErrorMessage = "The {0} field is required.")]
        public TeamViewModel Visit { get; set; }

        public int Field { get; set; }

        [Required(ErrorMessage = "The {0} field is required.")]
        public DateTime? DateMatch { get; set; }

    }
}
