using System;
using System.Collections.Generic;

namespace Chat_MediatorPattern
{
    public class ChatMediator : IChatMediator
    {
        private List<User> _users = new List<User>();
        
        public ChatMediator(string nameGroup)
        {
            Console.WriteLine(nameGroup + " group already created");
        }
        
        public void SendMessage(string msg, User user)
        {
            foreach (var userInList in _users)
            {
                if (!userInList.Equal(user))
                {
                    userInList.Receive(msg);
                }
            }
        }

        public void AddUser(User user)
        {
            Console.WriteLine(user.Name + " joined this group");
            _users.Add(user);
        }
    }
}