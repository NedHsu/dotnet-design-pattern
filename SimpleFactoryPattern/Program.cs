SimplePizzaFactory factory = new SimplePizzaFactory();

// 客戶點餐：芝士披薩
Pizza cheesePizza = factory.CreatePizza("cheese");
cheesePizza.Prepare();
cheesePizza.Bake();
cheesePizza.Cut();
cheesePizza.Box();

Console.WriteLine();

// 客戶點餐：蘑菇披薩
Pizza mushroomPizza = factory.CreatePizza("mushroom");
mushroomPizza.Prepare();
mushroomPizza.Bake();
mushroomPizza.Cut();
mushroomPizza.Box();