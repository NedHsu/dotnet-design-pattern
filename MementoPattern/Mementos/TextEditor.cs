// 原發器類別，負責創建和恢復備忘錄
public class TextEditor
{
    private string _content;

    public void SetContent(string content)
    {
        _content = content;
    }

    public Memento CreateMemento()
    {
        return new Memento(_content);
    }

    public void RestoreFromMemento(Memento memento)
    {
        _content = memento.Content;
    }

    public void PrintContent()
    {
        Console.WriteLine($"Current Content: {_content}");
    }
}
