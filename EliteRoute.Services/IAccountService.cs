using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteRoute.Services.Tokens;

namespace EliteRoute.Services
{
    public interface IAccountService
    {
        AccountToken Create(string email, string password, string firstName, string lastName, DateTime birthdate, string[] address);
        AccountToken UpdateEliteStatus(string email, IList<LoyaltyToken> loyalties);
        AccountToken UpdateBillingInfo(string email, BillingInfoToken billingInfo);
        AccountToken Get(string email);
        AccountToken Authenticate(string email, string password);
    }
}
