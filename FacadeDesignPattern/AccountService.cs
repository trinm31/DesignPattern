using System;

namespace FacadeDesignPattern
{
    public class AccountService
    {
        public void GetAccount(string email) {
            Console.WriteLine("Getting the account of " + email);
        }
    }
}