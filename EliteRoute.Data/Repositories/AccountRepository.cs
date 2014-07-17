using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteRoute.Data.Model;
using MongoDB.Driver;
using MongoDB.Driver.Builders;

namespace EliteRoute.Data.Repositories
{
    public class AccountRepository : IAccountRepository
    {
        MongoCollection<Account> _collection = null;

        public AccountRepository(MongoDatabase db)
        {
            _collection = db.GetCollection<Account>("accounts");
        }

        public Account FindByEmail(string email)
        {
            return _collection.FindOne(Query<Account>.EQ(a => a.Email, email));
        }

        public Account Create(Account account)
        {
            if (FindByEmail(account.Email) == null)
            {
                _collection.Save(account);
                return account;
            }

            throw new InvalidOperationException("Duplicate email");
        }
    }
}
