using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EliteRoute.Web.Models
{
    public class ComplaintDetailsModel
    {
        public Services.Tokens.ComplaintToken Complaint { get; set; }

        public IList<Services.Tokens.AirlineToken> Airlines { get; set; }

        public IList<Services.Tokens.IssueToken> Issues { get; set; }
    }
}