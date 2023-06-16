// SUV 具體汽車類別
public class SUV : Car
{
    public SUV(Engine engine) : base(engine)
    {
    }

    public override void Drive()
    {
        Console.WriteLine("Driving an SUV.");
        engine.Start();
        // 其他操作
        engine.Stop();
    }
}
