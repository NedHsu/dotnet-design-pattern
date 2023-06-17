// 具體訪問者，用於實現不同的操作
public class AnimalOperationVisitor : IAnimalVisitor
{
    public void Visit(Lion lion)
    {
        Console.WriteLine("測量獅子體重");
    }

    public void Visit(Tiger tiger)
    {
        Console.WriteLine("給老虎餵食");
    }

    public void Visit(Giraffe giraffe)
    {
        Console.WriteLine("觀察長頸鹿行為");
    }
}
