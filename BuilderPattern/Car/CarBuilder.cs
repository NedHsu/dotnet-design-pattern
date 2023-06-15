namespace BuilderPattern.Car;
// 汽車建造者抽象類
public abstract class CarBuilder
{
    protected Car car;

    public Car GetCar()
    {
        return car;
    }

    public abstract void SetEngineType();
    public abstract void SetColor();
    public abstract void SetTireSize();
    // 其他建造方法...
}