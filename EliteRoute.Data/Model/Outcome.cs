using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EliteRoute.Data.Model
{
    public class Outcome
    {
        public bool Acknoledged { get; set; }
        public int RefundType { get; set; }
        public long RefundAmount { get; set; }
    }
}
