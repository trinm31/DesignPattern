using System;

namespace AdapterDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Adaptee adaptee = new Adaptee();
            var target = new Adapter(adaptee);

            Console.WriteLine(target.GetRequest());
        }
    }
}