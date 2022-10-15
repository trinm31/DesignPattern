using System;

namespace LeaveRequest_Ex_chainResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
           LeaveRequestPipeline.GetApprover().ApproveLeave(new LeaveRequest(2));
           Console.WriteLine("-------");
           LeaveRequestPipeline.GetApprover().ApproveLeave(new LeaveRequest(5));
           Console.WriteLine("-------");
           LeaveRequestPipeline.GetApprover().ApproveLeave(new LeaveRequest(7));
        }
    }
}