// 組織成員抽象類別
public abstract class OrganizationMember
{
    protected string name;

    public OrganizationMember(string name)
    {
        this.name = name;
    }

    public abstract void DisplayMemberInfo();
}
