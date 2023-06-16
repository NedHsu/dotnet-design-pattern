namespace PrototypePattern.Toy;
// 定義原型介面
public interface IToyPrototype
{
    IToyPrototype Clone();
    void Play();
}
