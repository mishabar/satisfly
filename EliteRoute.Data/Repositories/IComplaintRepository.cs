using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteRoute.Data.Model;

namespace EliteRoute.Data.Repositories
{
    public interface IComplaintRepository
    {
        Complaint Create(Complaint complaint);

        IEnumerable<Complaint> GetAllByEmail(string email);

        Complaint GetByID(string email, long id);
    }
}
