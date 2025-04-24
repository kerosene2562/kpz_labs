using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Composite
{
    class LightImageNode : LightNode
    {
        public string Src { get; set; }
        private IImageLoaderStrategy _loaderStrategy;

        public LightImageNode(string href)
        {
            Src = href;
            SetStrategy(href);
        }

        private void SetStrategy(string href)
        {
            if (href.StartsWith("http://") || href.StartsWith("https://"))
                _loaderStrategy = new NetworkImageLoader();
            else
                _loaderStrategy = new FileImageLoader();
        }

        public override string OuterHTML()
        {
            return $"<img src=\"{Src}\" alt=\"{_loaderStrategy.Load(Src)}\" />";
        }

        public override string InnerHTML()
        {
            return string.Empty;
        }
    }
}
