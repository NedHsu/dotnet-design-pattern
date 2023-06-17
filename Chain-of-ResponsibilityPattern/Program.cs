// 使用範例
LeaveRequest leaveRequest = new LeaveRequest
{
    EmployeeName = "John",
    LeaveDays = 4
};

Approver teamLeader = new TeamLeader();
Approver departmentManager = new DepartmentManager();
Approver generalManager = new GeneralManager();

teamLeader.SetNextApprover(departmentManager);
departmentManager.SetNextApprover(generalManager);

teamLeader.ProcessRequest(leaveRequest);
