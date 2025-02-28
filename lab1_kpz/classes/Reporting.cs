using lab1_kpz.interfaces;

namespace lab1_kpz.classes
{
    public class Reporting : IReporting
    {
        private Warehouse _warehouse { get; set; }
        public Reporting(Warehouse warehouse)
        {
            _warehouse = warehouse;
        }
        public void getAllProducts()
        {
            Console.WriteLine("\n\nвсі товари на складі:");
            foreach (Product item in _warehouse.getProducts())
            {
                Console.WriteLine("товар:\n" + item.getName() +
                "\nу кількості: " + item.getQuantity() + item.getUnit() +
                "\nціна за одиницю: " + item.getPrice().getMoney() +
                "\nостання доставка: " + item.getLastDeliveryDate());
            }
        }
        public void addProduct(Product item)
        {
            _warehouse.getProducts().Add(item);
            Console.WriteLine("\n\nнадходження:\n" + item.getName() +
                "\nу кількості: " + item.getQuantity() + item.getUnit() +
                "\nціна за одиницю: " + item.getPrice().getMoney() +
                "\nостання доставка: " + item.getLastDeliveryDate());
        }

        public void decreaseProduct(Product item, int quantity)
        {
            if (quantity > 0 && quantity <= item.getQuantity())
            {
                item.decreaseUnits(quantity);
                Console.WriteLine("\n\nвідвантаження:\n" + item.getName() +
                    "\nу кількості: " + quantity + item.getUnit() +
                    "\nціна за одиницю: " + item.getPrice().getMoney() + 
                    "\nзалишок на складі: " + item.getQuantity() + item.getUnit());
            }
            else
            {
                Console.WriteLine("не достатньо товару на складі!");
            }
        }

        public void decreasePriceOnProduct(Product item, Money price)
        {
            if (price != null && price < item.getPrice())
            {
                item.decreasePrice(price);
                Console.WriteLine("\n\nзменшена ціна на товар:\n" + item.getName() +
                    "\nнова ціна за одиницю: " + item.getPrice().getMoney());
            }
            else 
            { 
                Console.WriteLine("ціна менше за вказану суму для зменшення ціни"); 
            }
        }
    }
}
