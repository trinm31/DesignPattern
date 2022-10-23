using System;
using System.Collections.Generic;

namespace TrackingAccount_observer
{
    public class AccountService : ISubject
    {
        private User _user;
        private List<IObserver> _observers = new List<IObserver>();

        public AccountService(string name, string ip)
        {
            _user = new User();
            _user.Name = name;
            _user.Ip = ip;
        }
        
        public void Attach(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
            }
        }

        public void Detach(IObserver observer)
        {
            if (_observers.Contains(observer))
            {
                _observers.Remove(observer);
            }
        }

        public void NotifyAllObserver()
        {
            foreach (var observer in _observers)
            {
                observer.Update(_user);
            }
        }

        public void ChangeStatus(LoginStatus status)
        {
            _user.Status = status;
            Console.WriteLine("Status is changed");
            this.NotifyAllObserver();
        }

        public void Login()
        {
            if (!IsValidIp())
            {
                _user.Status = LoginStatus.INVALID;
            }
            else if (IsValidName())
            {
                _user.Status = LoginStatus.SUCCESS;
            }
            else
            {
                _user.Status = LoginStatus.FAILURE;
            }

            Console.WriteLine("login is handled");
            
            this.NotifyAllObserver();
        }

        private bool IsValidIp()
        {
            return "127.0.0.1".Equals(_user.Ip);
        }

        private bool IsValidName()
        {
            return "TriNguyen".Equals(_user.Name);
        }
    }
}