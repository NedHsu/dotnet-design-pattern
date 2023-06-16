
// 中介者介面
public interface IChatMediator
{
    void AddColleague(Colleague webClient1);
    void SendMessage(string message, Colleague sender);
}

// 輸出:
// Web Client [WebClient1] sends message: Hello, everyone!
// Web Client [WebClient2] receives message: Hello, everyone!
// Mobile Client [MobileClient1] sends message: Hi, guys!
// Web Client [WebClient1] receives message: Hi, guys!
// Web Client [WebClient2] receives message: Hi, guys!
