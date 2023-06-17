// 長頸鹿類別
public class Giraffe : Animal
{
    public override void Accept(IAnimalVisitor visitor)
    {
        visitor.Visit(this);
    }
}
