// 建立組織架構
Organization organization = new Organization("ABC Company");

Department salesDepartment = new Department("Sales Department");
Department marketingDepartment = new Department("Marketing Department");

Department developmentDepartment = new Department("Development Department");
Department qaDepartment = new Department("QA Department");

Department customerServiceDepartment = new Department("Customer Service Department");

organization.AddMember(salesDepartment);
organization.AddMember(marketingDepartment);

organization.AddMember(developmentDepartment);
organization.AddMember(qaDepartment);

organization.AddMember(customerServiceDepartment);

// 顯示組織架構
organization.DisplayMemberInfo();

Console.ReadLine();