using Gazeta.Data.MInterface;
using Gazeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Data.MClass
{
    public class UserAccount : IUserAccount
    {
        public GazetaWebContext Context { get; }
        public UserAccount(GazetaWebContext context)
        {
            Context = context;
        }

        

        public IEnumerable<string> Login(string email, string password)
        {
            List<string> response = new List<string>();
            var list = Context.Accounts.FirstOrDefault(u=> u.Email == email && u.Password == password);

            if(list.Role == "user")
            {
                var user = Context.Users.FirstOrDefault(u => u.Email == email);
                
                response.Add(user.Name);
                response.Add(user.Email);
            }
            else
            {
                var company = Context.Companies.FirstOrDefault(u => u.Email == email);

                response.Add(company.CompanyName);
                response.Add(company.Email);
                response.Add(company.ProfileImage);
            }

           

            return response;
        }
        public void RegisterUser(User user)
        {
            Context.Add(user);
            Context.SaveChanges();

            //add user to Account table
            Account account = new Account();
            account.Email = user.Email;
            account.Password = user.Password;
            account.Role = "user";
            Context.Add(account);
            Context.SaveChanges();
        }

        public void RegisterCompany(Company company)
        {
            Context.Add(company);
            Context.SaveChanges();


            //add company to Account table
            Account account = new Account();
            account.Email = company.Email;
            account.Password = company.Password;
            account.Role = "company";
            Context.Add(account);
            Context.SaveChanges();
        }
    }
}
