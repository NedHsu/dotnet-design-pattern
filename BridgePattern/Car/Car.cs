
// 汽車抽象類別
public abstract class Car
{
    protected Engine engine;

    public Car(Engine engine)
    {
        this.engine = engine;
    }

    public abstract void Drive();
}
