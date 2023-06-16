
// 具體使用者（Concrete Colleague） - 網頁客戶端
public class WebClientColleague : Colleague
{
    public WebClientColleague(IChatMediator mediator, string name) : base(mediator, name)
    {
    }

    public override void Send(string message)
    {
        Console.WriteLine($"Web Client [{name}] sends message: {message}");
        mediator.SendMessage(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"Web Client [{name}] receives message: {message}");
    }
}

// 輸出:
// Web Client [WebClient1] sends message: Hello, everyone!
// Web Client [WebClient2] receives message: Hello, everyone!
// Mobile Client [MobileClient1] sends message: Hi, guys!
// Web Client [WebClient1] receives message: Hi, guys!
// Web Client [WebClient2] receives message: Hi, guys!
