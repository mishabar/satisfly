using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EliteRoute.Data.Model;

namespace EliteRoute.Data.Repositories
{
    public interface IAccountRepository
    {
        Account Create(Account account);

        Account FindByEmail(string email);
    }
}
