using System;

namespace LeaveRequest_Ex_chainResponsibility
{
    public class Director : Approver
    {
        protected override bool CanApprove(int numberOfDays)
        {
            return numberOfDays > 5;
        }

        protected override void DoApproving(LeaveRequest request)
        {
            Console.WriteLine("Leave request approved for " + request.GetDays() + " days by director");
        }
    }
}