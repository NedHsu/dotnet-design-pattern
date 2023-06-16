
// 實現代理編輯類別
public class EditorProxy : IEditor
{
    private IWriter _writer;

    public EditorProxy(IWriter writer)
    {
        _writer = writer;
    }

    public void Edit(string content)
    {
        Console.WriteLine("Proxy: Request received for editing");
        // 執行額外的編輯操作
        string editedContent = content.ToUpper();
        // 將編輯後的內容傳遞給寫作家進行寫作
        _writer.Write(editedContent);
        Console.WriteLine("Proxy: Editing completed");
    }
}
