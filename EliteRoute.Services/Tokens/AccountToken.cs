using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteRoute.Services.Tokens
{
    public class AccountToken
    {
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public DateTime Birthdate { get; set; }
        public IEnumerable<LoyaltyToken> Loyalties { get; set; }
        public long TotalRefunds { get; set; }
        public long TotalMiles { get; set; }
        public long TotalMoney { get; set; }
    }
}
