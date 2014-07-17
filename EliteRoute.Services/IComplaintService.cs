using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteRoute.Services.Tokens;

namespace EliteRoute.Services
{
    public interface IComplaintService
    {
        ComplaintToken Create(ComplaintToken complaint);

        IEnumerable<ComplaintToken> GetAllByEmail(string email);

        ComplaintToken GetByID(string email, long id);
    }
}
