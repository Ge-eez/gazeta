using Gazeta.Data.MInterface;
using Gazeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Data.MClass
{
    public class SubscriptionRepository : ISubscriptionRepository
    {
        public ApplicationDbContext Context { get; }
        public SubscriptionRepository(ApplicationDbContext Context)
        {
            this.Context = Context;
        }


        public IEnumerable<Subscription> GetSubscribedNews()
        {
            var Subscribed = (from subscribe in Context.Subscriptions
                              select subscribe).ToList();
            return Subscribed;

        }
        public IEnumerable<Subscription> GetSubscribedNewsCompany(string userEmail)
        {
            var Subscribed = (from subscribe in Context.Subscriptions
                              where subscribe.UserEmail == userEmail
                              select subscribe).ToList();
            return Subscribed;

        }

        public void SubscribeNews(string userEmail, string companyName,string companyEmail)
        {
            Subscription subscription = new()
            {

                CompanyName = companyName,
                UserEmail = userEmail,
                CompanyEmail = companyEmail
            };
            try
            {
                Context.Add(subscription);
                Context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }


        }

        //add the code below
        public bool CheckSubscription(string companyName, string userEmail)
        {
            IEnumerable<Subscription> subscriptions = from c in Context.Subscriptions
                          where c.CompanyName == companyName && c.UserEmail == userEmail
                          select c;
            if (subscriptions.Count() != 0) return true;
            return false;
        }

        public void UnubscribeNews(string userEmail, string companyName)
        {
            Subscription subscription = Context.Subscriptions.FirstOrDefault(n => n.UserEmail == userEmail && n.CompanyName == companyName);
            Context.Subscriptions.Remove(subscription);
            Context.SaveChanges();
        }
    }
}
