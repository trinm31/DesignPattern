using System;

namespace LeaveRequest_Ex_chainResponsibility
{
    public class DeliveryManager : Approver
    {
        protected override bool CanApprove(int numberOfDays)
        {
            return numberOfDays <= 5 && numberOfDays > 2;
        }

        protected override void DoApproving(LeaveRequest request)
        {
            Console.WriteLine("Leave request approved for " + request.GetDays() + " days by delivery manager");
        }
    }
}