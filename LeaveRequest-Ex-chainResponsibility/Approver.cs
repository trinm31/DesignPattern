using System;

namespace LeaveRequest_Ex_chainResponsibility
{
    public abstract class Approver
    {
        protected Approver _nextApprover;

        public void SetNext(Approver approver)
        {
            _nextApprover = approver;
        }

        public void ApproveLeave(LeaveRequest request)
        {
            if (CanApprove(request.GetDays()))
            {
                Console.WriteLine("Checking permission for " + GetType().Name);
                DoApproving(request);
            }

            if (_nextApprover != null)
            {
                _nextApprover.ApproveLeave(request);
            }
        }

        protected abstract Boolean CanApprove(int numberOfDays);

        protected abstract void DoApproving(LeaveRequest request);
    }
}