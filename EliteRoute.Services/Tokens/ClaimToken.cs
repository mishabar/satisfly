using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteRoute.Services.Tokens
{
    public class ClaimToken
    {
        public long ID { get; set; }
        public int Airline { get; set; }
        public string FlightNumber { get; set; }
        public string ConfirmationNumber { get; set; }
        public string Comments { get; set; }
        public IList<HistoryToken> History { get; set; }
    }
}
