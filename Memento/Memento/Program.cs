using Memento.Classes;
using System.Text;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            var editor = new TextEditor();

            editor.AppendText("File ");
            editor.DisplayContent();

            editor.AppendText("for lab4");
            editor.DisplayContent();

            Console.WriteLine("\n— Скасування останньої дії —");
            editor.Revert();
            editor.DisplayContent();

            Console.WriteLine("\n— Спроба скасування ще раз —");
            editor.Revert();
            editor.DisplayContent();

            Console.WriteLine("\n— Ще одна спроба скасувати (історія пуста) —");
            editor.Revert();
        }
    }
}