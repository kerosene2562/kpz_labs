using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.fabric;

namespace lab2.fabric
{
    class EducationSubscription : Subscription
    {
        public EducationSubscription()
            :base("Education", 2, 1, new List<string> { "channel4", "channel5", "channel6" }) { }

        public override void showDetails()
        {
            Console.WriteLine("Domestic subscription");
        }
    }
}
