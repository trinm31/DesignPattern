using System;

namespace UndoRedo_CommandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            DocumentInvoker invoker = new DocumentInvoker();
            
            invoker.Write("1st text");
            invoker.Undo();
            invoker.Read(); // empty
            
            invoker.Redo();
            //invoker.Read(); // 1st text
            
            invoker.Write("2st text");
            invoker.Write("3st text");
            //invoker.Read();
            invoker.Undo();
            invoker.Undo();
            invoker.Redo();
            invoker.Read();
        }
    }
}