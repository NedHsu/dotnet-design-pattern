// 總經理類別
public class GeneralManager : Approver
{
    public override void ProcessRequest(LeaveRequest request)
    {
        if (request.LeaveDays > 5)
        {
            Console.WriteLine($"總經理批准 {request.EmployeeName} 的請假申請");
        }
    }
}
