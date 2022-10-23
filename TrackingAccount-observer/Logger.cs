using System;

namespace TrackingAccount_observer
{
    public class Logger : IObserver
    {
        public void Update(User user)
        {
            Console.WriteLine($"Logger: {user}");
        }
    }
}