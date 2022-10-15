using System;

namespace LeaveRequest_Ex_chainResponsibility
{
    public class Supervisor : Approver
    {
        protected override bool CanApprove(int numberOfDays)
        {
            return numberOfDays <= 3;
        }

        protected override void DoApproving(LeaveRequest request)
        {
            Console.WriteLine("Leave request approved for " + request.GetDays() + " days by supervisor");
        }
    }
}