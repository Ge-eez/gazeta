using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Gazeta.Models
{
    public class Subscription
    {
        public int SubscriptionId { get; set; }
        public string CompanyName { get; set; }
        public string UserEmail { get; set; }
        public string CompanyProfile { get; set; }
    }
}
