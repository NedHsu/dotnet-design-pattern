// 備忘錄管理者類別，負責保存和恢復備忘錄
public class MementoManager
{
    private Stack<Memento> _mementos = new Stack<Memento>();

    public void SaveMemento(Memento memento)
    {
        _mementos.Push(memento);
    }

    public Memento PopMemento()
    {
        return _mementos.Pop();
    }
}
