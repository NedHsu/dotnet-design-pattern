// 獅子類別
public class Lion : Animal
{
    public override void Accept(IAnimalVisitor visitor)
    {
        visitor.Visit(this);
    }
}
