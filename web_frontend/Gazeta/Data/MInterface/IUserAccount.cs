using Gazeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Data.MInterface
{
    interface IUserAccount
    {
        IEnumerable<string> Login(string email, string password);
        void RegisterUser(User user);
        void RegisterCompany(Company company);
    }
}
