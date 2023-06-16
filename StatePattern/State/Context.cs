public class Context
{
    private State currentState;

    public Context()
    {
        // 初始狀態為ConcreteStateA
        currentState = new ConcreteStateA();
    }

    public void ChangeState(State state)
    {
        currentState = state;
    }

    public void Request()
    {
        // 呼叫當前狀態的操作
        currentState.HandleRequest(this);
    }
}
