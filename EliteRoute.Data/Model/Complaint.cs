using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace EliteRoute.Data.Model
{
    public class Complaint
    {
        [BsonId]
        public long ID { get; set; }
        public string Email { get; set; }
        public int Airline { get; set; }
        public string FlightNumber { get; set; }
        public string ConfirmationNumber { get; set; }
        public int[] Issues { get; set; }
        public string Comments { get; set; }
        public int Status { get; set; }
        public IList<History> History { get; set; }
        public Outcome Outcome { get; set; }
        public DateTime CreatedOn { get; set; }
    }
}
