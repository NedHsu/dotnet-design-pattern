// 小組長類別
public class TeamLeader : Approver
{
    public override void ProcessRequest(LeaveRequest request)
    {
        if (request.LeaveDays <= 2)
        {
            Console.WriteLine($"小組長批准 {request.EmployeeName} 的請假申請");
        }
        else if (NextApprover != null)
        {
            NextApprover.ProcessRequest(request);
        }
    }
}
