namespace BuilderPattern.Car;

// 具體汽車建造者類
public class ConcreteCarBuilder : CarBuilder
{
    public ConcreteCarBuilder()
    {
        car = new Car();
    }

    public override void SetEngineType()
    {
        car.EngineType = "V8";
    }

    public override void SetColor()
    {
        car.Color = "Red";
    }

    public override void SetTireSize()
    {
        car.TireSize = "18 inches";
    }
}