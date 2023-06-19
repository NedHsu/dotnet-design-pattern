
// 汽車類別
public class Car
{
    public string Make { get; set; }
    public string Model { get; set; }

    public Car(string make, string model)
    {
        Make = make;
        Model = model;
    }

    public void Drive()
    {
        Console.WriteLine($"Driving {Make} {Model}");
    }
}
