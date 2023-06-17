// 老虎類別
public class Tiger : Animal
{
    public override void Accept(IAnimalVisitor visitor)
    {
        visitor.Visit(this);
    }
}
