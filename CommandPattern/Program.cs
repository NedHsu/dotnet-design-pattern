Chef chef = new Chef();
ICommand orderCommand = new OrderCommand(chef, "Steak");
Waiter waiter = new Waiter(orderCommand);

waiter.TakeOrder();

// 輸出:
// Chef is cooking Steak
