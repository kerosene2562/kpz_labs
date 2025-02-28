using lab1_kpz.interfaces;

namespace lab1_kpz.classes
{
    public class Product : IProduct
    {
        private string _Name { get; set; }
        private Money _Price { get; set; }
        private string _description { get; set; }
        private string _unit { get; set; }
        private int _quantity { get; set; }
        private DateTime _lastDeliveryDate { get; set; }

        public Product(string name, Money price, string description, string unit, int quantity, DateTime lastDelivery)
        {
            _Name = name;
            _Price = price;
            _description = description;
            _unit = unit;
            _quantity = quantity;
            _lastDeliveryDate = lastDelivery;
        }

        public void decreasePrice(Money money)
        {
            _Price -= money;
        }

        public void decreaseUnits(int quantity)
        {
            _quantity -= quantity;
        }

        public string getDescription() => _description;
        public string getUnit() => _unit;
        public int getQuantity() => _quantity;
        public string getName() => _Name;
        public Money getPrice() => _Price;
        public DateTime getLastDeliveryDate() => _lastDeliveryDate;
    }
}
