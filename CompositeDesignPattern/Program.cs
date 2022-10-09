using System;
using System.Collections.Generic;

namespace CompositeDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var file1 = new FileLeaf("file 1", 5);
            var file2 = new FileLeaf("file 2", 69);
            var file3 = new FileLeaf("file 3", 123);

            List<IFileComponent> files = new List<IFileComponent>() { file1, file2, file3 };
            var folder = new FolderComposite(files);
            folder.ShowProperty();
            folder.Delete();
            Console.WriteLine(folder.TotalSize());
        }
    }
}