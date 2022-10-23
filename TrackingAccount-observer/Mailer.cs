using System;

namespace TrackingAccount_observer
{
    public class Mailer:IObserver
    {
        public void Update(User user)
        {
            if (user.Status == LoginStatus.EXPIRED)
            {
                Console.WriteLine($"Mailer {user} is expired and email is sent to notify");
            }
        }
    }
}