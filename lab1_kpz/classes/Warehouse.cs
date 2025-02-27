using lab1_kpz.interfaces;

namespace lab1_kpz.classes
{
    public class Warehouse : IWarehouse
    {
        private List<Product> _product { get; set; }
        private Reporting _reporting { get; set; }

        public Warehouse()
        {
            _product = new List<Product>();
            _reporting = new Reporting(this);
        }
        public List<Product> getProducts() => _product;
        public Reporting getReporting() => _reporting;
    }
}
