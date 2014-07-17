using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteRoute.Data.Model;
using EliteRoute.Services.Tokens;

namespace EliteRoute.Services.Extensions
{
    public static class LoyaltyExtensions
    {
        public static LoyaltyToken AsToken(this Loyalty loyalty)
        {
            return new LoyaltyToken 
            {
                Airline = loyalty.Airline,
                Level = loyalty.Level,
                IsElite = loyalty.IsElite,
                Number = loyalty.Number
            };
        }
    }
}
