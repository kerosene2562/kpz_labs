using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace lab3.Composite
{
    public class ValidationVisitor : IVisitor
    {
        public List<string> Errors { get; private set; } = new List<string>();

        public void Visit(LightElementNode elementNode)
        {
            if (string.IsNullOrWhiteSpace(elementNode.TagName))
            {
                Errors.Add("Element with empty tag name found.");
            }

            if (elementNode.Closing == ClosingType.Normal && elementNode.Children.Count == 0)
            {
                Errors.Add($"<{elementNode.TagName}> is not self-closing but has no children.");
            }
        }

        public void Visit(LightTextNode textNode)
        {
            if (string.IsNullOrWhiteSpace(textNode.InnerHTML()))
            {
                Errors.Add("Empty text node found.");
            }
        }
    }

}
