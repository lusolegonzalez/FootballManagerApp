using Football.Model.Entities;
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

        [Display(Name = "TournamentType")]
        [Required(ErrorMessage = "The {0} field is required.")]
        public TournamentType TournamentType { get; set; }

        [Display(Name = "InitDate")]
        [Required(ErrorMessage = "The {0} field is required.")]
        public DateTime InitDate { get; set; }

        [Display(Name = "FinishDate")]
        [Required(ErrorMessage = "The {0} field is required.")]
        public DateTime FinishDate { get; set; }

        [Display(Name = "PointsForWin")]
        [Required(ErrorMessage = "The {0} field is required.")]
        public int PointsForWin { get; set; }

        [Display(Name = "PointsForLost")]
        [Required(ErrorMessage = "The {0} field is required.")]
        public int PointsForLost { get; set; }

        [Display(Name = "PointsForDraw")]
        [Required(ErrorMessage = "The {0} field is required.")]
        public int PointsForDraw { get; set; }
    }
}
