namespace LeaveRequest_Ex_chainResponsibility
{
    public class LeaveRequest
    {
        private int _days;

        public LeaveRequest(int days)
        {
            _days = days;
        }

        public int GetDays()
        {
            return _days;
        }
    }
}