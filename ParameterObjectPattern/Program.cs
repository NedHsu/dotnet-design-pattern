// 創建比薩訂單
var order = new PizzaOrder {
    Size = "Large",
    Toppings = new List<string> { "Pepperoni", "Mushrooms" },
    DeliveryAddress = "123 Main Street"
};

// 傳遞訂單給比薩店
var pizzaShop = new PizzaShop();
pizzaShop.PlaceOrder(order);