// 實現基本的黑咖啡類別
public class BlackCoffee : ICoffee
{
    public string GetDescription()
    {
        return "Black Coffee";
    }

    public double GetCost()
    {
        return 2.0;
    }
}
