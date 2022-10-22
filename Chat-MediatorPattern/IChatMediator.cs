namespace Chat_MediatorPattern
{
    public interface IChatMediator
    {
        void SendMessage(string msg, User user);
        void AddUser(User user);
    }
}