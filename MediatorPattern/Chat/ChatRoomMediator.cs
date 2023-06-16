
// 具體中介者（Concrete Mediator） - 聊天室
public class ChatRoomMediator : IChatMediator
{
    private readonly List<Colleague> colleagues;

    public ChatRoomMediator()
    {
        colleagues = new List<Colleague>();
    }

    public void AddColleague(Colleague colleague)
    {
        colleagues.Add(colleague);
    }

    public void SendMessage(string message, Colleague sender)
    {
        foreach (var colleague in colleagues)
        {
            if (colleague != sender)
            {
                colleague.Receive(message);
            }
        }
    }
}

// 輸出:
// Web Client [WebClient1] sends message: Hello, everyone!
// Web Client [WebClient2] receives message: Hello, everyone!
// Mobile Client [MobileClient1] sends message: Hi, guys!
// Web Client [WebClient1] receives message: Hi, guys!
// Web Client [WebClient2] receives message: Hi, guys!
