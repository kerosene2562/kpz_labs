using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.abstract_fabric
{
    class KIaomiFactory : IDeviceFactory
    {
        public IProduct CreateLaptop() => new Laptop();
        public IProduct CreateNotebook() => new Notebook();
        public IProduct CreateEBook() => new EBook();
        public IProduct CreateSmartphone() => new Smartphone();
        public IBrand GetBrand() => new Kiaomi();
    }
}
