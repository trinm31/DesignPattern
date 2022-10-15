namespace LeaveRequest_Ex_chainResponsibility
{
    public class LeaveRequestPipeline
    {
        public static Approver GetApprover()
        {
            var supervisor = new Supervisor();
            var manager = new DeliveryManager();
            var director = new Director();
            
            supervisor.SetNext(manager);
            manager.SetNext(director);

            return supervisor;
        }
    }
}