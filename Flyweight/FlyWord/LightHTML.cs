using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace lab3.Flyweight.FlyWord
{
    public class LightHTML
    {
        private readonly List<string> _lines;

        public LightHTML(string filePath)
        {
            _lines = new List<string>(File.ReadAllLines(filePath));
        }

        public string ConvertToHtml()
        {
            var sb = new StringBuilder();

            for (int i = 0; i < _lines.Count; i++)
            {
                string line = _lines[i];
                HTMLElement element;

                if (i == 0)
                {
                    element = HTMLElementFactory.GetElement("h1");
                }
                else if (line.Length < 20)
                {
                    element = HTMLElementFactory.GetElement("h2");
                }
                else if (char.IsWhiteSpace(line[0]))
                {
                    element = HTMLElementFactory.GetElement("blockquote");
                }
                else
                {
                    element = HTMLElementFactory.GetElement("p");
                }

                sb.AppendLine(element.Render(line));
            }

            return sb.ToString();
        }
    }
}
