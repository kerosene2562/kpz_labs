using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Composite
{
    public class CustomElementNode : LightElementNode
    {
        public CustomElementNode(string tagName)
            : base(tagName, DisplayType.Block, ClosingType.Normal) { }


        protected override void OnCreated()
        {
            Console.WriteLine("Елемент створений: " + TagName);
        }

        protected override void OnInserted()
        {
            Console.WriteLine("Елемент вставлений: " + TagName);
        }

        protected override void OnRemoved()
        {
            Console.WriteLine("Елемент видалений: " + TagName);
        }

        protected override void OnStylesApplied()
        {
            Console.WriteLine("Стилі застосовані до елемента: " + TagName);
        }

        protected override void OnClassListApplied()
        {
            Console.WriteLine("Клас застосований до елемента: " + TagName);
        }

        protected override void OnTextRendered()
        {
            Console.WriteLine("Текст відображений для елемента: " + TagName);
        }
    }


}
