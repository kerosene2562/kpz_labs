using lab1_kpz.classes;
using System.Xml.Linq;

namespace lab1_kpz.interfaces
{
    public interface IProduct
    {
        void decreasePrice(Money price);
        string getName();
        Money getPrice();
        void decreaseUnits(int quantity);
        string getDescription();
        string getUnit();
        int getQuantity();
        DateTime getLastDeliveryDate();
    }
}
