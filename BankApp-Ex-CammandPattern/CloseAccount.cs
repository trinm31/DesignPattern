namespace BankApp_Ex_CammandPattern
{
    public class CloseAccount : ICommand
    {
        private Account _account;

        public CloseAccount(Account account)
        {
            _account = account;
        }
        
        public void Execute()
        {
            _account.Close();
        }
    }
}