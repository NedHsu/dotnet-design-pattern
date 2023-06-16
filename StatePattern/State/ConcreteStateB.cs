public class ConcreteStateB : State
{
    public void HandleRequest(Context context)
    {
        Console.WriteLine("HandleRequest in ConcreteStateB");
        // 改變狀態為ConcreteStateA
        context.ChangeState(new ConcreteStateA());
    }
}
