using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab2.fabric;

namespace lab2.fabric
{
    class Domesticsubscription : Subscription
    {
        public Domesticsubscription()
            :base("Domestic", 5, 3, new List<string> { "channel1" , "channel2", "channel3" }) { }

        public override void showDetails()
        {
            Console.WriteLine("Education subscription");
        }
    }
}
