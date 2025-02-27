using lab1_kpz.interfaces;

namespace lab1_kpz.classes
{
    public class Money : IDisplayItem, IMoney
    { 
        private string _currency { get; set; }
        private int _whole {  get; set; }
        private int _fraction { get; set; }
        private Dictionary<string, (string, string)> _allCurrency = new Dictionary<string, (string, string)>
        {
            {"UAH", ("грн" ,"коп.") },
            {"USD", ("дол.", "ц.") },
            {"EUR", ("євро", "єц.") }
        };

        public Money(string currancy ,int whole, int fraction)
        {
            _currency = currancy;
            _whole = whole; 
            _fraction = fraction;
        }

        public void display()
        {
            Console.Write(this._whole + _allCurrency[_currency].Item1 + this._fraction + _allCurrency[_currency].Item2);
        }

        public string getMoney()
        {
            return (this._whole + _allCurrency[_currency].Item1 + " " + this._fraction + _allCurrency[_currency].Item2);
        }

        public void setWhole(int whole)
        {
            this._whole = whole;
        }

        public void setFraction(int fraction)
        {
            this._fraction = fraction;
        }

        public static Money operator - (Money a, Money b)
        {
            if (a._currency == b._currency)
            {
                int totalA = a._whole * 100 + a._fraction;
                int totalB = b._whole * 100 + b._fraction;
                int result = totalA - totalB;

                a.setWhole(result / 100);
                a.setFraction(result % 100);
                return a;
            }
            else
            {
                Console.WriteLine("валюти не співпадають!!!");
                return a;
            }
        }

        public static bool operator < (Money a, Money b)
        {
            int totalA = a._whole * 100 + a._fraction;
            int totalB = b._whole * 100 + b._fraction;

            return totalA < totalB;
        }

        public static bool operator > (Money a, Money b)
        {
            int totalA = a._whole * 100 + a._fraction;
            int totalB = b._whole * 100 + b._fraction;

            return totalA > totalB;
        }

    }
}
