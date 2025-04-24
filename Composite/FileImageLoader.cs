using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Composite
{
    public class FileImageLoader : IImageLoaderStrategy
    {
        public string Load(string href)
        {
            return $"Image loaded from file: {Path.GetFileName(href)}";
        }
    }
}
