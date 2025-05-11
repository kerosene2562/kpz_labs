using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using lab3.classes;

namespace lab3.Composite
{
    public enum DisplayType { Block, Inline }
    public enum ClosingType { SelfClosing, Normal }
    public class LightElementNode : LightNode
    {
        public ILightNodeState State { get; set; } = new EnabledState();
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
            OnCreated();
        }
        protected virtual void OnCreated() { }
        protected virtual void OnInserted() { }
        protected virtual void OnRemoved() { }
        protected virtual void OnStylesApplied() { }
        protected virtual void OnClassListApplied() { }
        protected virtual void OnTextRendered() { }

        public override void Insert()
        {
            OnInserted(); 
            foreach (var child in Children)
            {
                child.Insert();
            }
        }

        public override void Remove()
        {
            OnRemoved(); 
            foreach (var child in Children)
            {
                child.Remove(); 
            }
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.Visit(this);
            foreach (var child in Children)
            {
                child.Accept(visitor); 
            }
        }

        public void HandleEvent(string eventType)
        {
            State.HandleEvent(this, eventType);
        }

        public string RenderWithState(int indentLevel = 0)
        {
            return State.Render(this, indentLevel);
        }

        public void AddClass(string className)
        {
            CssClasses.Add(className);
            OnClassListApplied(); 
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
