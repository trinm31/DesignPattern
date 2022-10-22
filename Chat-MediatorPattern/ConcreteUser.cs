using System;

namespace Chat_MediatorPattern
{
    public class ConcreteUser : User
    {
        public ConcreteUser(string name, ChatMediator mediator) : base(name, mediator)
        {
        }

        public override void Send(string msg)
        {
            Console.WriteLine("---");
            Console.WriteLine(Name + " is sending message: " + msg);
            Mediator.SendMessage(msg, this);
        }

        public override void Receive(string msg)
        {
            Console.WriteLine("---");
            Console.WriteLine(Name + " is received message: " + msg);
        }
    }
}