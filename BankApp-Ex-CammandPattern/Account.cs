using System;

namespace BankApp_Ex_CammandPattern
{
    public class Account
    {
        private string _name;

        public Account(string name)
        {
            _name = name;
        }

        public void Open()
        {
            Console.WriteLine($"Account {_name} Opened");
        }
        
        public void Close()
        {
            Console.WriteLine($"Account {_name} Closed");
        }
    }
}