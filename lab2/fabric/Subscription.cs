using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.fabric
{
    public abstract class Subscription
    {
        public string Name;
        public decimal MonthlyPay;
        public int minPeriodMonth;
        public List<string> channels;

        protected Subscription(string name, decimal monthlyPay, int minPeriodMonth, List<string> channels)
        {
            this.Name = name;
            this.MonthlyPay = monthlyPay;
            this.minPeriodMonth = minPeriodMonth;
            this.channels = channels;
        }

        public abstract void showDetails();
    }
}
