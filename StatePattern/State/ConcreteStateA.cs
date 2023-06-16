public class ConcreteStateA : State
{
    public void HandleRequest(Context context)
    {
        Console.WriteLine("HandleRequest in ConcreteStateA");
        // 改變狀態為ConcreteStateB
        context.ChangeState(new ConcreteStateB());
    }
}
