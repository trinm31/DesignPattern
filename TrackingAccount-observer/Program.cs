using System;

namespace TrackingAccount_observer
{
    class Program
    {
        static void Main(string[] args)
        {
            var account1 = CreateAccount("TriNguyen", "127.0.0.1");
            account1.Login();
            account1.ChangeStatus(LoginStatus.EXPIRED);

            var account2 = CreateAccount("TriNguyen", "432144321");
            account2.Login();
        }

        private static AccountService CreateAccount(string name, string ip)
        {
            AccountService accountService = new AccountService(name, ip);
            accountService.Attach(new Logger());
            accountService.Attach(new Protector());
            accountService.Attach(new Mailer());

            return accountService;
        }
    }
}