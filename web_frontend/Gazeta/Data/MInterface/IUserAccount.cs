using Gazeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Data.MInterface
{
    //public interface IUserAccount
    //{
    //    Dictionary<string, string> UserLogin(string email, string password);
    //    Dictionary<string, string> CompanyLogin(string email, string password);
    //    void RegisterUser(User user);
    //    void RegisterCompany(Company company);
    //}
    public interface IUserAccount
    {
        Dictionary<string, string> UserLogin(string email, string password);
        Dictionary<string, string> CompanyLogin(string email, string password);
        void RegisterUser(User user);
        void RegisterCompanies(Company company);
    }
}
