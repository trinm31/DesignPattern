using System;

namespace FacadeDesignPattern
{
    public class SMSService
    {
        public void SendSms(string phone) {
            Console.WriteLine("Sending an sms to " + phone);
        }
    }
}