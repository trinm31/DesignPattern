using System;

namespace BankApp_Ex_CammandPattern
{
    public class BankApp
    {
        public void Click(ICommand command)
        {
            Console.WriteLine($"user wanna {command.GetType().Name} account");
            command.Execute();
        }
    }
}