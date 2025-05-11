using System.Collections.Generic;

namespace lab3.classes
{
    public class CommandManager
    {
        private readonly Stack<ICommand> _history = new();

        public void ExecuteCommand(ICommand command)
        {
            command.Execute();
            _history.Push(command);
        }

        public void UndoLast()
        {
            if (_history.Count > 0)
            {
                var command = _history.Pop();
                command.Undo();
            }
        }

        public void ClearHistory()
        {
            _history.Clear();
        }
    }
}
