using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Composite
{
    public enum DisplayType { Block, Inline }
    public enum ClosingType { SelfClosing, Normal }
    public class LightElementNode : LightNode
    {
        public string TagName { get; }
        public DisplayType Display { get; }
        public ClosingType Closing { get; }
        public List<string> CssClasses { get; }
        public List<LightNode> Children { get; }

        public LightElementNode(string tagName, DisplayType display, ClosingType closing)
        {
            TagName = tagName;
            Display = display;
            Closing = closing;
            CssClasses = new List<string>();
            Children = new List<LightNode>();
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
        }

        public void AddChild(LightNode child)
        {
            Children.Add(child);
        }

        public override string OuterHTML()
        {
            StringBuilder html = new StringBuilder();
            html.Append($"<{TagName}");

            if (CssClasses.Count > 0)
            {
                html.Append(" class=\"" + string.Join(" ", CssClasses) + "\"");
            }

            if (Closing == ClosingType.SelfClosing)
            {
                html.Append(" />");
                return html.ToString();
            }

            html.Append(">");
            html.Append(InnerHTML());
            html.Append($"</{TagName}>");

            return html.ToString();
        }

        public override string InnerHTML()
        {
            StringBuilder html = new StringBuilder();
            foreach (var child in Children)
            {
                html.Append(child.OuterHTML());
            }
            return html.ToString();
        }
    }
}
