// 具體的湯類別，實現模板類別中的具體步驟
public class TomatoSoup : SoupCookingTemplate
{
    protected override void PrepareIngredients()
    {
        Console.WriteLine("Prepare tomatoes, onions, and garlic.");
    }

    protected override void Cook()
    {
        Console.WriteLine("Cook the ingredients in a pot.");
    }

    protected override void Season()
    {
        Console.WriteLine("Season with salt, pepper, and basil.");
    }
}
