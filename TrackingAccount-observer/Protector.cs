using System;

namespace TrackingAccount_observer
{
    public class Protector :IObserver
    {
        public void Update(User user)
        {
            if (user.Status == LoginStatus.INVALID)
            {
                Console.WriteLine($"Protector User: {user.Name} is invalid");
                Console.WriteLine($"User with IP: {user.Ip} is block");
            }
        }
    }
}