// 點一杯基本的黑咖啡
ICoffee coffee = new BlackCoffee();

// 使用裝飾器進行配料裝飾
ICoffee decoratedCoffee = new MilkDecorator(new SugarDecorator(coffee));

// 獲取咖啡描述和價格
string description = decoratedCoffee.GetDescription();
double cost = decoratedCoffee.GetCost();

Console.WriteLine("Description: " + description);
Console.WriteLine("Cost: $" + cost);