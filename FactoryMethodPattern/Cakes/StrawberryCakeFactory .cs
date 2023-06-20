// 具體工廠：草莓蛋糕工廠
class StrawberryCakeFactory : ICakeFactory
{
    public ICake CreateCake()
    {
        return new StrawberryCake();
    }
}