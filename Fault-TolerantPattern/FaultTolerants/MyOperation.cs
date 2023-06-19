
// 實現具體的操作類別
public class MyOperation : IFaultTolerantOperation
{
    public void Execute()
    {
        // 執行具體的操作
        // 在這個範例中，假設操作可能會引發例外
        // 我們將在容錯模式中處理這些例外
        throw new Exception("Something went wrong.");
    }
}
