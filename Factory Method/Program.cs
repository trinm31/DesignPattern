using System;

namespace Factory_Method
{
    class Program
    {
        static void Main(string[] args)
        {
            // array of creators
            Creator[] creators = new Creator[2];

            creators[0] = new ConcreteCreatorA();
            creators[1] = new ConcreteCreatorB();

            foreach (var creator in creators)
            {
                Product product = creator.FactoryMethod();
                Console.WriteLine($"created {product.GetType().Name}");
            }
        }
    }
}