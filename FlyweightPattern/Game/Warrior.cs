
// 具體角色類別
public class Warrior : ICharacter
{
    private string name;
    private int level;

    public Warrior(string name, int level)
    {
        this.name = name;
        this.level = level;
    }

    public void Display()
    {
        Console.WriteLine($"Warrior - Name: {name}, Level: {level}");
    }
}
