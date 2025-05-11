using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3.Composite
{
    public class EnabledState : ILightNodeState
    {
        public string Render(LightNode node, int indentLevel)
        {
            string indent = new string(' ', indentLevel * 2);
            return $"{indent}{node.OuterHTML()}";
        }

        public void HandleEvent(LightNode node, string eventType)
        {
            Console.WriteLine($"[Enabled] Обробка події '{eventType}' для елемента: {node.OuterHTML()}");
        }
    }
}
