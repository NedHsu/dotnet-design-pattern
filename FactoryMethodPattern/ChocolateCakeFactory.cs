// 具體工廠：巧克力蛋糕工廠
public class ChocolateCakeFactory : ICakeFactory
{
    public ICake CreateCake()
    {
        return new ChocolateCake();
    }
}