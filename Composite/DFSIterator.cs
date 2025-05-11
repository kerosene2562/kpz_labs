using System.Collections.Generic;
using lab3.Composite;

namespace lab3.Iterators
{
    public class DFSIterator : Iterator
    {
        private readonly Stack<(LightNode node, int index)> stack;
        private LightNode current;

        public DFSIterator(LightNode root)
        {
            stack = new Stack<(LightNode, int)>();
            stack.Push((root, 0));
        }

        public override LightNode Current() => current;

        public override int Key() => stack.Count;

        public override bool MoveNext()
        {
            if (stack.Count == 0)
                return false;

            var (node, _) = stack.Pop();
            current = node;

            if (node is LightElementNode element)
            {
                for (int i = element.Children.Count - 1; i >= 0; i--)
                {
                    stack.Push((element.Children[i], i));
                }
            }

            return true;
        }

        public override void Reset()
        {
            stack.Clear();
            current = null;
        }
    }
}
