
// 命令實現 - 點餐命令
public class OrderCommand : ICommand
{
    private readonly Chef chef;
    private readonly string dish;

    public OrderCommand(Chef chef, string dish)
    {
        this.chef = chef;
        this.dish = dish;
    }

    public void Execute()
    {
        chef.Cook(dish);
    }
}

// 輸出:
// Chef is cooking Steak
