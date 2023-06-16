// 服務生（Invoker）
public class Waiter
{
    private readonly ICommand command;

    public Waiter(ICommand command)
    {
        this.command = command;
    }

    public void TakeOrder()
    {
        command.Execute();
    }
}

// 輸出:
// Chef is cooking Steak
