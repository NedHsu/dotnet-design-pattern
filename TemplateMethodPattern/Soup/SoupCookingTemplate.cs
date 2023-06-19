// 模板類別，定義煮湯的流程
public abstract class SoupCookingTemplate
{
    public void CookSoup()
    {
        PrepareIngredients();
        Cook();
        Season();
        Serve();
    }

    protected abstract void PrepareIngredients();

    protected abstract void Cook();

    protected abstract void Season();

    protected virtual void Serve()
    {
        Console.WriteLine("Serve the soup in a bowl.");
    }
}
