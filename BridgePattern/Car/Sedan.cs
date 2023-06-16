
// Sedan 具體汽車類別
public class Sedan : Car
{
    public Sedan(Engine engine) : base(engine)
    {
    }

    public override void Drive()
    {
        Console.WriteLine("Driving a sedan.");
        engine.Start();
        // 其他操作
        engine.Stop();
    }
}
