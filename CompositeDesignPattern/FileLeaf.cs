using System;

namespace CompositeDesignPattern
{
    public class FileLeaf:IFileComponent
    {
        private long _size;
        private string _name;

        public FileLeaf(string name, long size)
        {
            _name = name;
            _size = size;
        }
        public void ShowProperty()
        {
            Console.WriteLine($"File name: {_name} size: {_size}");
        }

        public long TotalSize()
        {
            return _size;
        }

        public void Delete()
        {
            _size = 0;
        }
    }
}