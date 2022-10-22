using System;

namespace Chat_MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ChatMediator mediator = new ChatMediator("Lop Khanh Phong");

            var admin = new ConcreteUser("admin", mediator);
            var tri = new ConcreteUser("tri", mediator);
            var khanh = new ConcreteUser("khanh", mediator);
            var phong = new ConcreteUser("phong", mediator);
            
            mediator.AddUser(admin);
            mediator.AddUser(tri);
            mediator.AddUser(khanh);
            mediator.AddUser(phong);
            
            tri.Send("Hi all");
        }
    }
}