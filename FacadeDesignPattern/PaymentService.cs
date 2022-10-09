using System;

namespace FacadeDesignPattern
{
    public class PaymentService
    {
        public void PaymentByPaypal() {
            Console.WriteLine("Payment by Paypal");
        }
 
        public void PaymentByCreditCard() {
            Console.WriteLine("Payment by Credit Card");
        }
 
        public void PaymentByEbankingAccount() {
            Console.WriteLine("Payment by E-banking account");
        }
 
        public void PaymentByCash() {
            Console.WriteLine("Payment by cash");
        }
    }
}