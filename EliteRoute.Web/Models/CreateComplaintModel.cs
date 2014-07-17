using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EliteRoute.Services.Tokens;

namespace EliteRoute.Web.Models
{
    public class CreateComplaintModel
    {
        [Required]
        public int Airline { get; set; }
        [Required]
        [Display(Name = "Flight Number")]
        public string FlightNumber { get; set; }
        [Required]
        [Display(Name = "Confirmation Number")]
        public string ConfirmationNumber { get; set; }
        [Required]
        public int[] Issue { get; set; }
        public string Comments { get; set; }
        public string Error { get; set; }

        public IEnumerable<SelectListItem> Airlines { get; set; }
        public IEnumerable<IssueToken> Issues { get; set; }
    }
}