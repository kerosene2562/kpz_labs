using lab1_kpz.classes;

namespace lab1_kpz.interfaces
{
    public interface IProduct
    {
        void decreasePrice(Money price);
        string getName();
        Money getPrice();
    }
}
