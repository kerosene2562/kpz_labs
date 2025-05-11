using System.Collections.Generic;
using lab3.Composite;

namespace lab3.Iterators
{
    public class BFSIterator : Iterator
    {
        private readonly Queue<LightNode> queue;
        private LightNode current;

        public BFSIterator(LightNode root)
        {
            queue = new Queue<LightNode>();
            queue.Enqueue(root);
        }

        public override LightNode Current() => current;

        public override int Key() => queue.Count;

        public override bool MoveNext()
        {
            if (queue.Count == 0)
                return false;

            current = queue.Dequeue();

            if (current is LightElementNode element)
            {
                foreach (var child in element.Children)
                {
                    queue.Enqueue(child);
                }
            }

            return true;
        }

        public override void Reset()
        {
            queue.Clear();
            current = null;
        }
    }
}
