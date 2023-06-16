
// 具體使用者（Concrete Colleague） - 行動客戶端
public class MobileClientColleague : Colleague
{
    public MobileClientColleague(IChatMediator mediator, string name) : base(mediator, name)
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine($"Mobile Client [{name}] sends message: {message}");
        mediator.SendMessage(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"Mobile Client [{name}] receives message: {message}");
    }
}

// 輸出:
// Web Client [WebClient1] sends message: Hello, everyone!
// Web Client [WebClient2] receives message: Hello, everyone!
// Mobile Client [MobileClient1] sends message: Hi, guys!
// Web Client [WebClient1] receives message: Hi, guys!
// Web Client [WebClient2] receives message: Hi, guys!
