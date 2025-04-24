using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Memento.Classes
{
    public class TextDocument
    {
        private string _text = string.Empty;

        public void Append(string fragment)
        {
            _text += fragment;
        }

        public void ClearAll()
        {
            _text = string.Empty;
        }

        public override string ToString() => _text;

        public Memento CreateSnapshot()
        {
            return new Memento(_text);
        }

        public void RestoreSnapshot(Memento snapshot)
        {
            _text = snapshot.SavedText;
        }

        public class Memento
        {
            internal string SavedText { get; }

            internal Memento(string state)
            {
                SavedText = state;
            }
        }
    }
}
