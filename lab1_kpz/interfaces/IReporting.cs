using lab1_kpz.classes;

namespace lab1_kpz.interfaces
{
    public interface IReporting
    {
        void getAllProducts();
        void addProduct(Product item);
        void decreaseProduct(Product item, int quantity);
        void decreasePriceOnProduct(Product item, Money price);
    }
}
