// 組織類別，同時也是容器節點
public class Organization : OrganizationMember
{
    private List<OrganizationMember> members = new List<OrganizationMember>();

    public Organization(string name) : base(name)
    {
    }

    public void AddMember(OrganizationMember member)
    {
        members.Add(member);
    }

    public void RemoveMember(OrganizationMember member)
    {
        members.Remove(member);
    }

    public override void DisplayMemberInfo()
    {
        Console.WriteLine("Organization: " + name);

        foreach (var member in members)
        {
            member.DisplayMemberInfo();
        }
    }
}
