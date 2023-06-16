// 部門類別，同時也是葉子節點
public class Department : OrganizationMember
{
    public Department(string name) : base(name)
    {
    }

    public override void DisplayMemberInfo()
    {
        Console.WriteLine("Department: " + name);
    }
}
