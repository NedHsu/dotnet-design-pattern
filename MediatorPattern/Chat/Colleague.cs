
// 使用者（Colleague）抽象類別
public abstract class Colleague
{
    protected readonly IChatMediator mediator;
    protected readonly string name;

    public Colleague(IChatMediator mediator, string name)
    {
        this.mediator = mediator;
        this.name = name;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
}
