namespace PrototypePattern.Toy;
public class BearToy : IToyPrototype
{
    public IToyPrototype Clone()
    {
        // 使用淺層複製，即創建一個新實例並複製成員的值
        return (IToyPrototype)MemberwiseClone();
    }

    public void Play()
    {
        Console.WriteLine("Playing with a bear toy!");
    }
}
