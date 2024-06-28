using OopStudy.SharedContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OopStudy.SubscriptionContext
{
    public class Student : Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public User User { get; set; }
        public IList<Subscription> Subscriptions { get; set; }
        public bool IsPremium => Subscriptions.Any(x => !x.IsInactive);
    }
}
