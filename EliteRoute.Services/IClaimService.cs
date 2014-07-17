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
        void Create(ComplaintToken Complaint);
    }
}
