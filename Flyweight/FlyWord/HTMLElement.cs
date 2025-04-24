using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Flyweight.FlyWord
{
    public class HTMLElement
    {
        public string TagName { get; }

        public HTMLElement(string tagName)
        {
            TagName = tagName;
        }

        public string Render(string content)
        {
            return $"<{TagName}>{content}</{TagName}>";
        }
    }

    public static class HTMLElementFactory
    {
        private static readonly Dictionary<string, HTMLElement> _elements = new();

        public static HTMLElement GetElement(string tagName)
        {
            if (!_elements.ContainsKey(tagName))
            {
                _elements[tagName] = new HTMLElement(tagName);
            }
            return _elements[tagName];
        }
    }
}
