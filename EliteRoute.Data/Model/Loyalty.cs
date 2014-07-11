using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EliteRoute.Data.Model
{
    public class Loyalty
    {
        public int Airline { get; set; }
        public int Level { get; set; }
        public bool IsElite { get; set; }
    }
}
