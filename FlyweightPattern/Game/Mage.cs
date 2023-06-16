public class Mage : ICharacter
{
    private string name;
    private int level;

    public Mage(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    public void Display()
    {
        Console.WriteLine($"Mage - Name: {name}, Level: {level}");
    }
}
