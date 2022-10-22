using System;

namespace Chat_MediatorPattern
{
    public abstract class User
    {
        protected IChatMediator Mediator;
        public string Name { get; set; }

        public User(string name, IChatMediator chatMediator)
        {
            Name = name;
            Mediator = chatMediator;
        }

        public abstract void Send(string msg);
        
        public abstract void Receive(string msg);

        public bool Equal(Object obj)
        {
            if (obj == null)
            {
                return false;
            }

            if (this.GetType() != obj.GetType())
            {
                return false;
            }

            User user = (User)obj;
            return Name.Equals(user.Name);
        }
    }
}