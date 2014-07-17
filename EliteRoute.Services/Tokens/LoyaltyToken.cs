using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteRoute.Services.Tokens
{
    public class LoyaltyToken
    {
        public int Airline { get; set; }
        public int Level { get; set; }
        public bool IsElite { get; set; }
        public string Number { get; set; }
    }
}
