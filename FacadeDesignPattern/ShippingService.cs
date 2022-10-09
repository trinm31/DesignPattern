using System;

namespace FacadeDesignPattern
{
    public class ShippingService
    {
        public void FreeShipping() {
            Console.WriteLine("Free Shipping");
        }
 
        public void StandardShipping() {
            Console.WriteLine("Standard Shipping");
        }
 
        public void ExpressShipping() {
            Console.WriteLine("Express Shipping");
        }
    }
}