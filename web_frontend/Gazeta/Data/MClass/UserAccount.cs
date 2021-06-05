using Gazeta.Data.MInterface;
using Gazeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Data.MClass
{
    //public class UserAccount : IUserAccount
    //{
    //    public ApplicationDbContext Context { get; }
    //    public UserAccount(ApplicationDbContext context)
    //    {
    //        Context = context;
    //    }



    //    public Dictionary<string, string> UserLogin(string email, string password)
    //    {
    //        var user = Context.Users.FirstOrDefault(u => u.UserEmail == email && u.UserPassword == password);
    //        if (user != null)
    //        {
    //            Dictionary<string, string> c = new Dictionary<string, string>();
    //            c.Add("name", user.UserName);
    //            c.Add("email", user.UserEmail);

    //            return c;
    //        }
    //        return null;


    //    }
    //    public Dictionary<string, string> CompanyLogin(string email, string password)
    //    {
    //        var company = Context.Companies.FirstOrDefault(u => u.CompanyEmail == email && u.CompanyPassword == password);
    //        if (company != null)
    //        {
    //            Dictionary<string, string> c = new Dictionary<string, string>();
    //            c.Add("companyName", company.CompanyName);
    //            c.Add("owner", company.Owner);
    //            c.Add("email", company.CompanyEmail);
    //            c.Add("profile", company.ProfileImage);
    //            return c;
    //        }
    //        return null;
    //    }

    //    public void RegisterUser(User user)
    //    {
    //        Context.Add(user);
    //        Context.SaveChanges();

    //    }

    //    public void RegisterCompany(Company company)
    //    {
    //        Context.Add(company);
    //        Context.SaveChanges();


    //        //add company to Account table

    //    }


    //}
    public class UserAccount : IUserAccount
    {
        public ApplicationDbContext Context { get; }
        public UserAccount(ApplicationDbContext context)
        {
            Context = context;
        }



        public Dictionary<string, string> UserLogin(string email, string password)
        {
            var user = Context.Users.FirstOrDefault(u => u.UserEmail == email);
            if (user != null)
            {
                Dictionary<string, string> c = new Dictionary<string, string>();
                c.Add("name", user.UserName);
                c.Add("email", user.UserEmail);

                return c;
            }
            return null;


        }
        public Dictionary<string, string> CompanyLogin(string email, string password)
        {
            var company = Context.Companies.FirstOrDefault(u => u.CompanyEmail == email);
            if (company != null)
            {
                Dictionary<string, string> c = new Dictionary<string, string>();
                c.Add("companyName", company.CompanyName);
                c.Add("owner", company.Owner);
                c.Add("email", company.CompanyEmail);
                c.Add("password", company.CompanyPassword);
                c.Add("profile", company.ProfileImage);
                return c;
            }
            return null;
        }

        public void RegisterUser(User user)
        {
            Context.Add(user);
            Context.SaveChanges();

            //add user to Account table
            Account account = new Account();
            account.Email = user.UserEmail;
            account.Password = user.UserPassword;
            account.Role = "user";
            Context.Add(account);
            Context.SaveChanges();
        }

        public async void RegisterCompanies(Company company)
        {
            // Context.Add(company);
            // Context.SaveChanges();
            try
            {
                Context.Add(company);
                await Context.SaveChangesAsync();
            }

            catch (Exception)
            {
                // throw new CustomException("Couldn't save the changes", e);
                throw;
            }


            //add company to Account table
            Account account = new Account();
            account.Email = company.CompanyEmail;
            account.Password = company.CompanyPassword;
            account.Role = "company";
            Context.Add(account);
            Context.SaveChanges();
        }


    }

}
