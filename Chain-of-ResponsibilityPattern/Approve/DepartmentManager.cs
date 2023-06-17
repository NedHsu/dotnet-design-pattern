// 部門經理類別
public class DepartmentManager : Approver
{
    public override void ProcessRequest(LeaveRequest request)
    {
        if (request.LeaveDays <= 5)
        {
            Console.WriteLine($"部門經理批准 {request.EmployeeName} 的請假申請");
        }
        else if (NextApprover != null)
        {
            NextApprover.ProcessRequest(request);
        }
    }
}
