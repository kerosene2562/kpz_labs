using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Composite
{
    public class NetworkImageLoader : IImageLoaderStrategy
    {
        public string Load(string href)
        {
            return $"Image loaded from URL: {href}";
        }
    }
}
