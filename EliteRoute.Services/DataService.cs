using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteRoute.Services.Tokens;

namespace EliteRoute.Services
{
    public class DataService : IDataService
    {
        public IList<IssueToken> GetIssues()
        {
            return new IssueToken[] { new IssueToken { ID = 1, Name = "Baggage" }, new IssueToken { ID = 2, Name = "Cancelation" }, new IssueToken { ID = 3, Name = "Delay" }, new IssueToken { ID = 4, Name = "Overbooking" }, new IssueToken { ID = 5, Name = "Poor In-Flight Experience" }, new IssueToken { ID = 6, Name = "Other" } };
        }

        public IList<AirlineToken> GetAirlines()
        {
            return new AirlineToken[] { new AirlineToken { ID = 1, Name = "American Airlines", Image = "american.jpg" }, new AirlineToken { ID = 2, Name = "Delta", Image = "delta.jpg" }, new AirlineToken { ID = 3, Name = "United Airlines", Image = "united.png" } };
        }
    }
}
