using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteRoute.Data.Model;
using EliteRoute.Services.Tokens;

namespace EliteRoute.Services.Extensions
{
    public static class HistoryExtensions
    {
        public static HistoryToken AsToken(this History history)
        {
            return new HistoryToken 
            {
                EmployeeID = history.EmployeeID,
                CreatedOn = history.CreatedOn,
                Comments = history.Comments
            };
        }
    }
}
