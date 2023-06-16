
// 投影機子系統
public class Projector
{
    public void TurnOn()
    {
        Console.WriteLine("Projector is turned on.");
    }

    public void TurnOff()
    {
        Console.WriteLine("Projector is turned off.");
    }

    public void SetInput(string input)
    {
        Console.WriteLine("Projector input is set to " + input);
    }
}
