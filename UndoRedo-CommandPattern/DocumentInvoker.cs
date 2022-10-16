using System;
using System.Collections.Generic;

namespace UndoRedo_CommandPattern
{
    public class DocumentInvoker
    {
        private Stack<ICommand> _undoCommands = new Stack<ICommand>();
        private Stack<ICommand> _redoCommands = new Stack<ICommand>();

        private Document _document = new Document();

        public void Undo()
        {
            if (_undoCommands.Count > 0)
            {
                var cmd = _undoCommands.Pop();
                cmd.Undo();
                _redoCommands.Push(cmd);
            }
            else
            {
                Console.WriteLine("Nothing to undo");
            }
        }
        
        public void Redo()
        {
            if (_redoCommands.Count > 0)
            {
                var cmd = _redoCommands.Pop();
                cmd.Redo();
                _undoCommands.Push(cmd);
            }
            else
            {
                Console.WriteLine("Nothing to Redo");
            }
        }

        public void Write(string text)
        {
            var cmd = new DocumentEditerCommand(_document, text);
            _undoCommands.Push(cmd);
            _redoCommands.Clear();
        }

        public void Read()
        {
            _document.ReadDocument();
        }
    }
}