using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteRoute.Services.Tokens
{
    public class ComplaintToken
    {
        public long ID { get; set; }
        public string Email { get; set; }
        public int Airline { get; set; }
        public string FlightNumber { get; set; }
        public string ConfirmationNumber { get; set; }
        public int[] Issues { get; set; }
        public string Comments { get; set; }
        public int Status { get; set; }
        public IEnumerable<HistoryToken> History { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
