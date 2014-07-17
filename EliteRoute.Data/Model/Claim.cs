using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteRoute.Data.Model
{
    public class Complaint
    {
        public long ID { get; set; }
        public int Airline { get; set; }
        public string FlightNumber { get; set; }
        public string ConfirmationNumber { get; set; }
        public string Comments { get; set; }
        public IList<History> History { get; set; }
        public int Status { get; set; }
        public Outcome Outcome { get; set; }
    }
}
