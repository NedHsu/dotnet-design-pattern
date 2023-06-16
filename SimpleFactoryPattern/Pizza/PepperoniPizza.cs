// 具體的火腿披薩
public class PepperoniPizza : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing Pepperoni Pizza");
    }

    public override void Bake()
    {
        Console.WriteLine("Baking Pepperoni Pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting Pepperoni Pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing Pepperoni Pizza");
    }
}