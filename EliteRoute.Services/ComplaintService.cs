using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteRoute.Data.Model;
using EliteRoute.Data.Repositories;
using EliteRoute.Services.Tokens;
using EliteRoute.Services.Extensions;

namespace EliteRoute.Services
{
    public class ComplaintService : IComplaintService
    {
        private IComplaintRepository _complaintRepository;

        public ComplaintService(IComplaintRepository complaintRepository)
        {
            _complaintRepository = complaintRepository;
        }

        public ComplaintToken Create(ComplaintToken token)
        {
            Complaint complaint = _complaintRepository.Create(new Complaint
            {
                ID = (long)DateTime.UtcNow.Subtract(new DateTime(1979, 8, 8)).TotalMilliseconds,
                Email = token.Email,
                Airline = token.Airline,
                FlightNumber = token.FlightNumber,
                ConfirmationNumber = token.ConfirmationNumber,
                Issues = token.Issues,
                Comments = token.Comments,
                Status = (int)ComplaintStatus.New,
                CreatedOn = DateTime.UtcNow
            });
            return complaint.AsToken();
        }

        public IEnumerable<ComplaintToken> GetAllByEmail(string email)
        {
            return _complaintRepository.GetAllByEmail(email.ToLowerInvariant()).Select(c => c.AsToken());
        }

        public ComplaintToken GetByID(string email, long id)
        {
            return _complaintRepository.GetByID(email.ToLowerInvariant(), id).AsToken();
        }
    }
}
