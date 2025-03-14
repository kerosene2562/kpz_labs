using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2.abstract_fabric
{
    interface IDeviceFactory
    {
        IProduct CreateLaptop();
        IProduct CreateNotebook();
        IProduct CreateSmartphone();
        IProduct CreateEBook();
        IBrand GetBrand();
    }
}
