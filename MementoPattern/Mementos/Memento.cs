// 備忘錄類別，保存原發器的狀態
public class Memento
{
    public string Content { get; }

    public Memento(string content)
    {
        Content = content;
    }
}
