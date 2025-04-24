using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Composite
{
    public interface IImageLoaderStrategy
    {
        string Load(string href);
    }
}
