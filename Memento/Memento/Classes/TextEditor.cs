using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Classes
{
    public class TextEditor
    {
        private readonly TextDocument _file = new TextDocument();
        private readonly Stack<TextDocument.Memento> _snapshots = new Stack<TextDocument.Memento>();

        public void AppendText(string newText)
        {
            _snapshots.Push(_file.CreateSnapshot());
            _file.Append(newText);
        }

        public void Revert()
        {
            if (_snapshots.TryPop(out var previousVersion))
            {
                _file.RestoreSnapshot(previousVersion);
            }
            else
            {
                Console.WriteLine("Історія порожня, нічого скасувати!");
            }
        }

        public void DisplayContent()
        {
            Console.WriteLine($"Поточний текст: \"{_file}\"");
        }
    }
}
