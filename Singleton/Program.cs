using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            CEO c1 = CEO.GetInstance();
            CEO c2 = CEO.GetInstance();
            
            if (c1 == c2)
            {
                Console.WriteLine("the same obj");
            }
            else
            {
                Console.WriteLine("not the same obj");
            }
        }
    }
}