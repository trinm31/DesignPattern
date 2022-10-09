using System;

namespace FacadeDesignPattern
{
    public class EmailService
    {
        public void SendMail(string mailTo) {
            Console.WriteLine("Sending an email to " + mailTo);
        }
    }
}