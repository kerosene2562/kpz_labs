using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.fabric
{
    class MobileApp : ISubscriptionFactory
    {
        public Subscription CreateSubscription(string type)
        {
            Subscription sub = type switch
            {
                "Domestic" => new Domesticsubscription(),
                "Education" => new EducationSubscription(),
                "Premium" => new PremiumSubscription(),
            };
            return sub;
        }
        
    }
}
