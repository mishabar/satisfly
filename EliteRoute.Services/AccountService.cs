using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteRoute.Data.Model;
using EliteRoute.Data.Repositories;
using EliteRoute.Data.Utilities;
using EliteRoute.Services.Exceptions;
using EliteRoute.Services.Tokens;
using EliteRoute.Services.Extensions;

namespace EliteRoute.Services
{
    public class AccountService : IAccountService
    {
        private IAccountRepository _accountRepository;

        public AccountService(IAccountRepository accountRepository)
        {
            _accountRepository = accountRepository;
        }

        public AccountToken Create(string email, string password, string firstName, string lastName, DateTime birthdate, string[] address)
        {
            if (_accountRepository.FindByEmail(email.ToLowerInvariant()) != null)
                throw new DuplicateAccountException();

            Account account = new Account { Email = email.ToLowerInvariant(), Password = PasswordHash.CreateHash(password), FirstName = firstName, LastName = lastName, Birthdate = birthdate, Address1 = address[0], Address2 = address.Length > 1 ? address[1] : null };
            account = _accountRepository.Create(account);
            return account.AsToken();
        }

        public Tokens.AccountToken UpdateEliteStatus(string email, IList<Tokens.LoyaltyToken> loyalties)
        {
            throw new NotImplementedException();
        }

        public Tokens.AccountToken UpdateBillingInfo(string email, Tokens.BillingInfoToken billingInfo)
        {
            throw new NotImplementedException();
        }

        public AccountToken Get(string email)
        {
            return _accountRepository.FindByEmail(email.ToLowerInvariant()).AsToken();
        }

        public AccountToken Authenticate(string email, string password)
        {
            Account account = _accountRepository.FindByEmail(email.ToLowerInvariant());
            if (account != null)
            {
                if (PasswordHash.ValidatePassword(password, account.Password))
                {
                    return account.AsToken();
                }
            }
            return null;
        }
    }
}
