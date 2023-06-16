// 具體的蘑菇披薩
public class MushroomPizza : Pizza
{
    public override void Prepare()
    {
        Console.WriteLine("Preparing Mushroom Pizza");
    }

    public override void Bake()
    {
        Console.WriteLine("Baking Mushroom Pizza");
    }

    public override void Cut()
    {
        Console.WriteLine("Cutting Mushroom Pizza");
    }

    public override void Box()
    {
        Console.WriteLine("Boxing Mushroom Pizza");
    }
}