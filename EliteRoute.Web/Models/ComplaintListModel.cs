using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EliteRoute.Services.Tokens;

namespace EliteRoute.Web.Models
{
    public class ComplaintListModel
    {
        public IEnumerable<ComplaintToken> Complaints { get; set; }
        public IEnumerable<AirlineToken> Airlines { get; set; }
        public IEnumerable<IssueToken> Issues { get; set; }
    }
}