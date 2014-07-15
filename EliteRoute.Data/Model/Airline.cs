using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;

namespace EliteRoute.Data.Model
{
    public class Airline
    {
        [BsonId]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
