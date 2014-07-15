using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EliteRoute.Services.Tokens;

namespace EliteRoute.Web.Models
{
    public class CreateClaimModel
    {
        [Required]
        public int Airline { get; set; }
        [Required]
        public string FlightNumber { get; set; }
        [Required]
        public string ConfirmationNumber { get; set; }
        [Required]
        public int[] Issue { get; set; }
        public string Comments { get; set; }

        public IEnumerable<SelectListItem> Airlines { get; set; }
        public IEnumerable<IssueToken> Issues { get; set; }
    }
}