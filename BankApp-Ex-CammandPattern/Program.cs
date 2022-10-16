using System;

namespace BankApp_Ex_CammandPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Account account = new Account("Tri");

            ICommand open = new OpenAccount(account); 
            ICommand close = new OpenAccount(account);

            BankApp bankApp = new BankApp();
            bankApp.Click(open);
            bankApp.Click(close);
        }
    }
}