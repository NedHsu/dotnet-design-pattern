// 抽象處理者類別
public abstract class Approver
{
    protected Approver NextApprover;

    public void SetNextApprover(Approver nextApprover)
    {
        NextApprover = nextApprover;
    }

    public abstract void ProcessRequest(LeaveRequest request);
}
