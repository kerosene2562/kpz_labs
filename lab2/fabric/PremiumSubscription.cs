using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.fabric;

namespace lab2.fabric
{
    class PremiumSubscription : Subscription
    {
        public PremiumSubscription()
            : base("Premium", 15, 7, new List<string> { "channel1", "channel2", "channel3", "channel4", "channel5", "channel6" }) { }

        public override void showDetails()
        {
            Console.WriteLine("Premium subscription");
        }
    }
}
