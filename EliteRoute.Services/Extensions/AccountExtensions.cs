using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteRoute.Data.Model;
using EliteRoute.Services.Tokens;

namespace EliteRoute.Services.Extensions
{
    public static class AccountExtensions
    {
        public static AccountToken AsToken(this Account account)
        {
            return new AccountToken 
            {
                Email = account.Email,
                FirstName = account.FirstName,
                LastName = account.LastName,
                Birthdate = account.Birthdate,
                Address1 = account.Address1,
                Address2 = account.Address2,
                Phone = account.Phone,
                Loyalties = account.Loyalties == null ? null : account.Loyalties.Select(l => l.AsToken())
            };
        }
    }
}
