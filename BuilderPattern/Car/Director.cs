namespace BuilderPattern.Car;

// 指揮者類
public class Director
{
    private CarBuilder carBuilder;

    public Director(CarBuilder builder)
    {
        carBuilder = builder;
    }

    public Car ConstructCar()
    {
        carBuilder.SetEngineType();
        carBuilder.SetColor();
        carBuilder.SetTireSize();
        // 可以按照需要添加其他步驟
        return carBuilder.GetCar();
    }
}