using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Composite
{
    public class DisabledState : ILightNodeState
    {
        public string Render(LightNode node, int indentLevel)
        {
            string indent = new string(' ', indentLevel * 2);
            return $"{indent}<!-- Disabled element: {node.OuterHTML()} -->";
        }

        public void HandleEvent(LightNode node, string eventType)
        {
            Console.WriteLine($"[Disabled] Подія '{eventType}' ігнорується для: {node.OuterHTML()}");
        }
    }
}
