namespace BankApp_Ex_CammandPattern
{
    public class OpenAccount: ICommand
    {
        private Account _account;
        public OpenAccount(Account account)
        {
            _account = account;
        }
        
        public void Execute()
        {
            _account.Open();
        }
    }
}