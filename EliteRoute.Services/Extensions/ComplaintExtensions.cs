using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteRoute.Data.Model;
using EliteRoute.Services.Tokens;

namespace EliteRoute.Services.Extensions
{
    public static class ComplaintExtensions
    {
        public static ComplaintToken AsToken(this Complaint complaint)
        {
            return new ComplaintToken 
            { 
                ID = complaint.ID,
                Email = complaint.Email,
                Airline = complaint.Airline,
                FlightNumber = complaint.FlightNumber,
                ConfirmationNumber = complaint.ConfirmationNumber,
                Issues = complaint.Issues,
                Status = complaint.Status,
                Comments = complaint.Comments,
                History = complaint.History == null ? null : complaint.History.Select(h => h.AsToken()),
                CreatedOn = complaint.CreatedOn
            };
        }
    }
}
