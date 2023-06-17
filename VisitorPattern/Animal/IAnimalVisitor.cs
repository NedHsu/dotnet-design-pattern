
// 抽象動物訪問者
public interface IAnimalVisitor
{
    void Visit(Lion lion);
    void Visit(Tiger tiger);
    void Visit(Giraffe giraffe);
}
