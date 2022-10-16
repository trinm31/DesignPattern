using System;
using System.Collections.Generic;

namespace UndoRedo_CommandPattern
{
    public class Document
    {
        private Stack<string> _lines = new Stack<string>();

        public void Write(string text)
        {
            _lines.Push(text);
        }

        public void EraseLast()
        {
            if (_lines.Count > 0)
            {
                _lines.Pop();
            }
        }

        public void ReadDocument()
        {
            foreach (var line in _lines)
            {
                Console.WriteLine(line);
            }
        }
    }
}