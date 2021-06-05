using Gazeta.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Data.MInterface
{
    public interface ISubscriptionRepository
    {
        IEnumerable<Subscription> GetSubscribedNewsCompany(string userEmail);
        IEnumerable<Subscription> GetSubscribedNews();

        void SubscribeNews(string userEmail, string companyName, string companyEmail);
        void UnubscribeNews(string userEmail, string companyName);
        bool CheckSubscription(string companyName, string userEmail);
    }
}
